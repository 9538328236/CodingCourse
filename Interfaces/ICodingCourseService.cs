using CodingTestAPI.Model;

namespace CodingTestAPI.Interfaces
{
    public interface ICodingCourseService
    {
        Task<List<CodingCourse>> GetAllCodingCourseAsync();
        Task<List<CodingCourse>> GetAllCodingCourseByIdAsync(int id);
        Task<int> AddAsync(CodingCourse codingCourse);
    }
}
