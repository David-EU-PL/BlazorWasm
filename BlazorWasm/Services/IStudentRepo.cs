using BlazorWasm.Models;

namespace BlazorWasm.Services
{
    public interface IStudentRepo
    {
        List<Student> Get();
        void Add();
    }
}
