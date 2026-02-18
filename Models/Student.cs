using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace IdentityPractice.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Enrollment>? Enrollments { get; set; }
    }
}