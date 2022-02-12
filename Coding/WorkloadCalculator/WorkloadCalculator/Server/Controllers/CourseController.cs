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
    public class CourseController : ControllerBase
    {
        private readonly ILogger<CourseController> _logger;
        private readonly HttpContext _httpContext;


        private static readonly string sessionKey = "Courses";

        public CourseController(ILogger<CourseController> logger, IServiceProvider services)
        {
            _logger = logger;
            _httpContext = services.GetRequiredService<IHttpContextAccessor>().HttpContext;

            #region Courses DB Population
            //Initialing the variable to simulate a pre-populated database
            var courses = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Name = "Blockchain and HR",
                    Duration = 8
                },
                new Course
                {
                    Id = 2,
                    Name = "Compensation & Benefits",
                    Duration = 32
                },
                new Course
                {
                    Id = 3,
                    Name = "Digital HR",
                    Duration = 40
                },
                new Course
                {
                    Id = 4,
                    Name = "Digital HR Strategy",
                    Duration = 10
                },
                new Course
                {
                    Id = 5,
                    Name = "Digital HR Transformation",
                    Duration = 8
                },
                new Course
                {
                    Id = 6,
                    Name = "Diversity & Inclusion",
                    Duration = 20
                },
                new Course
                {
                    Id = 7,
                    Name = "Employee Experience & Design Thinking",
                    Duration = 12
                },
                new Course
                {
                    Id = 8,
                    Name = "Employer Branding",
                    Duration = 6
                },
                new Course
                {
                    Id = 9,
                    Name = "Global Data Integrity",
                    Duration = 12
                },
                new Course
                {
                    Id = 10,
                    Name = "Hiring & Recruitment Strategy",
                    Duration = 15
                },
                new Course
                {
                    Id = 11,
                    Name = "HR Analytics Leader",
                    Duration = 21
                },
                new Course
                {
                    Id = 12,
                    Name = "HR Business Partner 2.0",
                    Duration = 40
                },
                new Course
                {
                    Id = 13,
                    Name = "HR Data Analyst",
                    Duration = 18
                },
                new Course
                {
                    Id = 14,
                    Name = "HR Data Science in R",
                    Duration = 12
                },
                new Course
                {
                    Id = 15,
                    Name = "HR Data Visualization",
                    Duration = 12
                },
                new Course
                {
                    Id = 16,
                    Name = "HR Metrics & Reporting",
                    Duration = 40
                },
                new Course
                {
                    Id = 17,
                    Name = "Learning & Development",
                    Duration = 30
                },
                new Course
                {
                    Id = 18,
                    Name = "Organizational Development",
                    Duration = 30
                },
                new Course
                {
                    Id = 19,
                    Name = "People Analytics",
                    Duration = 40
                },
                new Course
                {
                    Id = 20,
                    Name = "Statistics in HR",
                    Duration = 15
                },
                new Course
                {
                    Id = 21,
                    Name = "Strategic HR Leadership",
                    Duration = 34
                },
                new Course
                {
                    Id = 22,
                    Name = "Strategic HR Metrics",
                    Duration = 17
                },
                new Course
                {
                    Id = 23,
                    Name = "Talent Acquisition",
                    Duration = 40
                }

            };

            _httpContext.Session.SetString(sessionKey, JsonConvert.SerializeObject(courses));
            #endregion


        }

        [HttpGet]
        public IList<Course> Get()
        {
            var sessionCourses = _httpContext.Session.GetString(sessionKey);
            if (!string.IsNullOrEmpty(sessionCourses))
            {
                return JsonConvert.DeserializeObject<IList<Course>>(sessionCourses);
            }

            _logger.LogError("Courses not found");
            return null;
        }
    }
}
