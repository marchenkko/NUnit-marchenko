using Groups.Implementions;

namespace Groups.Implementions;

public class GroupEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<StudentEntity> Students { get; set; }

    public GroupEntity()
    {
        Students = new List<StudentEntity>();
    }

    public void AddStudent(StudentEntity student)
    {
        Students.Add(student);
    }
}