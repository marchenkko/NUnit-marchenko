using Microsoft.VisualStudio.TestTools.UnitTesting;
using Groups.Implementations;

namespace Tests
{
    [TestClass]
    public class GroupEntityTests
    {
        [TestMethod]
        public void GroupEntity_AddStudent_StudentAddedToGroup()
        {
            var group = new GroupEntity();
            var student = new StudentEntity();

            group.AddStudent(student);

            Assert.IsTrue(group.Students.Contains(student));
        }
    }
}