using Microsoft.VisualStudio.TestTools.UnitTesting;
using Groups.Implementations;

namespace Tests
{
    [TestClass]
    public class GroupManagerEntityTests
    {
        [TestMethod]
        public void GroupManagerEntity_GetGroupById_ReturnsCorrectGroup()
        {
            var groupManager = new GroupManagerEntity();
            var group1 = new GroupEntity { Id = 1 };
            var group2 = new GroupEntity { Id = 2 };
            groupManager.AddGroup(group1);
            groupManager.AddGroup(group2);

            var retrievedGroup = groupManager.GetGroupById(1);

            Assert.AreEqual(group1, retrievedGroup);
        }
    }
}