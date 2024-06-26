using CodingTestAPI.Interfaces;
using CodingTestAPI.Model;

namespace CodingTestAPI.Services
{
    public class CodingCourseService : ICodingCourseService
    {
        private readonly List<CodingCourse> _codingCourses;

        public CodingCourseService()
        {
            _codingCourses = new List<CodingCourse>() { 
            new CodingCourse{ Id= 1, CourseName = ".Net Full Stack", DurationInMonth = 3, CourseCost = 1200},
            new CodingCourse{ Id= 2, CourseName = "Angular", DurationInMonth = 2, CourseCost = 2000},
            new CodingCourse{ Id= 3, CourseName = "Python", DurationInMonth = 6, CourseCost = 7000}

            };
        }

        public async Task<int> AddAsync(CodingCourse codingCourse)
        {
           if(codingCourse != null)
            {
                _codingCourses.Add(codingCourse);
                return _codingCourses.Count();
            }
           else { return 0; }
        }

        public async Task<List<CodingCourse>> GetAllCodingCourseAsync()
        {
           return _codingCourses;
        }

        public async Task<List<CodingCourse>> GetAllCodingCourseByIdAsync(int id)
        {
            return _codingCourses.Where(c => c.Id == id).ToList();
        }
    }
}
