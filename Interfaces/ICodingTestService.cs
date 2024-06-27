using CodingTestAPI.Model;
using System.Globalization;

namespace CodingTestAPI.Interfaces
{
    public interface ICodingTestService
    {
        Task<List<CodingTest>> DisplayResult(string[] inputItems );
    }
}
