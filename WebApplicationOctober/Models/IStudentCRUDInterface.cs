using WebApplicationOctober.Models;

public interface IStudentCRUDInterface
    {
        // Return all students for a list view.
        List<StudentModel> GetAllStudents();

        // Find one student by id, or return null when there is no match.
        StudentModel? GetStudentById(int id);

        // Add a new student to the data source.
        void AddStudent(StudentModel newStudent);

        // Replace the existing student identified by studentId.
        void UpdateStudent(int studentId, StudentModel updatedStudent);

        // Remove the student identified by studentId.
        void DeleteStudent(int studentId);
    }
