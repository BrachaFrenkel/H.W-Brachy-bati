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
}
