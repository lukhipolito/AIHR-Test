using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkloadCalculator.Shared;

namespace WorkloadCalculator.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudyPlanController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;
        private readonly HttpContext _httpContext;

        private static readonly string sessionKey = "StudyPlans";

        public StudyPlanController(ILogger<CourseController> logger, IServiceProvider services)
        {
            _logger = logger;
            _httpContext = services.GetRequiredService<IHttpContextAccessor>().HttpContext;
        }

        [HttpGet]
        public IList<StudyPlan> Get()
        {
            var sessionPlans = _httpContext.Session.GetString(sessionKey);
            if (!string.IsNullOrEmpty(sessionPlans))
            {
                return JsonConvert.DeserializeObject<IList<StudyPlan>>(sessionPlans);
            }

            _logger.LogError("Courses not found");
            return new List<StudyPlan>();
        }

        [HttpPost]
        public void Post([FromBody] StudyPlan studyPlan)
        {
            var plans = new List<StudyPlan>();
            var sessionPlans = _httpContext.Session.GetString(sessionKey);
            if (!string.IsNullOrEmpty(sessionPlans))
            {
                plans = JsonConvert.DeserializeObject<IList<StudyPlan>>(sessionPlans).ToList();
                if (!plans.Contains(studyPlan))
                {
                    plans.Add(studyPlan);
                }
            }
            else
            {
                plans.Add(studyPlan);
            }
            _httpContext.Session.SetString(sessionKey, JsonConvert.SerializeObject(plans));
        }
    }
}
