namespace Git_withServer;

public class MyFriends
{
    public List<Friend> friends;
    public MyFriends()
    {
        friends = new List<Friend>();
    }
   public void addFriend(Friend friend)
    {
        friends.Add(friend);
    }
}
