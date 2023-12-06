namespace Git_withServer;

public class MyFriends
{
    public List<Friend> friends;
    public MyFriends()
    {
        friends = new List<Friend>();
    }
    public List<Friend> GetFriends()
    {
        return friends;
    }
   public void addFriend(Friend friend)
    {
        friends.Add(friend);
    }

    public void updateFriend(Friend friend)
    {
        friends.Add(friend);
        friends.FirstOrDefault(p => p.LastName == friend.LastName).Phone = friend.Phone;
    }
}
