using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkloadCalculator.Shared
{
    public class StudyPlan
    {
        public StudyPlan()
        {
            CreationDate = DateTime.Now;
        }

        public StudyPlan(DateTime startDate, DateTime endDate, IList<Course> courses, int preferredHoursPerDay = 4)
        {
            StartDate = startDate;
            EndDate = endDate;
            Courses = courses;
            PreferredHoursPerDay = preferredHoursPerDay;
            if (PreferredHoursPerDay < 1)
            {
                PreferredHoursPerDay = 1;
            }

            if (PreferredHoursPerDay > 4)
            {
                PreferredHoursPerDay = 4;
            }

            TotalHoursCourses = Courses.Sum(x => x.Duration);
            TotalHoursTimeSpan = (int)Math.Ceiling((EndDate - StartDate).TotalHours);
            TotalHoursAvailable = (int)Math.Ceiling((double)TotalHoursTimeSpan / (24 / PreferredHoursPerDay));

            HoursPerWeekRecommended = HoursPerWeek();
            TotalWeeks = CalculateTotalWeeks();

            CreationDate = DateTime.Now;
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IList<Course> Courses { get; set; }
        public int PreferredHoursPerDay { get; set; }

        public int HoursPerWeekRecommended { get; set; }

        public int TotalWeeks { get; set; }

        // This is the total amount of hours it takes to make all the selected courses
        public int TotalHoursCourses { get; set; }

        // This is the total amount of hours we have in the period selected
        public int TotalHoursTimeSpan { get; set; }

        // This is the total amount of hours that are available for the student. 
        // It considers 1/6 of the total hours because the student shouldn't commit hours of the day reserved for other activities (eg: sleep, work, rest, entertainment)
        public int TotalHoursAvailable { get; set; }

        public DateTime CreationDate { get; set; }


        private int HoursPerWeek()
        {
            return PreferredHoursPerDay * 7;
        }

        private int CalculateTotalWeeks()
        {
            if (TotalHoursAvailable >= 28)
            {
                return Convert.ToInt32(Math.Ceiling((double)TotalHoursAvailable / 28));
            }

            return 1;
        }
    }
}
