using IdentityPractice.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<IEnumerable<Student>> GetAllStudentsAsync()
    {
        return await _studentRepository.GetAllAsync();
    }

    public async Task<Student> GetStudentByIdAsync(int id)
    {
        return await _studentRepository.GetByIdAsync(id);
    }

    public async Task AddStudentAsync(Student student)
    {
        await _studentRepository.AddAsync(student);
    }

    public async Task UpdateStudentAsync(int id, Student student)
    {
        await _studentRepository.UpdateAsync(student);
    }

    public async Task DeleteStudentAsync(int id)
    {
        await _studentRepository.DeleteAsync(id);
    }
}
