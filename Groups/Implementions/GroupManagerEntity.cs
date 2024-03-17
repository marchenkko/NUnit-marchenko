using Students.Implementations;

namespace Groups.Implementions;

public class GroupManagerEntity
{
    public List<GroupEntity> Groups { get; set; }

    public GroupManagerEntity()
    {
        Groups = new List<GroupEntity>();
    }

    public void AddGroup(GroupEntity group)
    {
        Groups.Add(group);
    }

    public GroupEntity GetGroupById(int id)
    {
        return Groups.Find(group => group.Id == id);
    }
}