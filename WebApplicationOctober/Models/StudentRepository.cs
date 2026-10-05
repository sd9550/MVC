namespace WebApplicationOctober.Models;

public class StudentRepository : IStudentCRUDInterface
{
private readonly List<StudentModel> _students = new List<StudentModel>
        {
            new StudentModel(1001, "Tom", 16, "tom1@school.edu"),
            new StudentModel(1002, "Jen", 8, "jen1@school.edu"),
            new StudentModel(1003, "Sabah", 16, "sabah1@school.edu"),
            new StudentModel(1003, "Terry", 16, "terry1@school.edu"),
            new StudentModel(1004, "Alex", 12, "alex1@school.edu"),
            new StudentModel(1005, "Jordan", 14, "jordan1@school.edu")
        };

        // Return the collection used by this repository.
        public List<StudentModel> GetAllStudents()
        {
            return _students;
        }

        // Search by id; null tells the controller that the requested student was not found.
        public StudentModel? GetStudentById(int id)
        {
            foreach (StudentModel student in _students)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }

        // Add the supplied student to the in-memory collection.
        public void AddStudent(StudentModel newStudent)
        {
            _students.Add(newStudent);
        }

        // Find the student first, then remove it if it exists.
        public void DeleteStudent(int studentId)
        {
            StudentModel? student = GetStudentById(studentId);
            if (student != null)
            {
                _students.Remove(student);
            }
        }

        // Find the student's position in the list and replace that entry when it exists.
        public void UpdateStudent(int studentId, StudentModel updatedStudent)
        {
            int index = _students.FindIndex(student => student.Id == studentId);
            if (index >= 0)
            {
                _students[index] = updatedStudent;
            }
        }
}