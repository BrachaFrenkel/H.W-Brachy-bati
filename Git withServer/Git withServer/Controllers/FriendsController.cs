
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Git_withServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        MyFriends myFriends = new();
        //[HttpGet]
        //public List<Friend> Get()
        //{
        //  return  myFriends.GetFriends();
        //}
        [HttpGet]
        public string getString()
        {
            return "Brachi is my best friend!";
        }
        [HttpPost]
        public void add(Friend friend)
        {
            myFriends.addFriend(friend);
        }
        [HttpPut]
        public void put(Friend friend)
        {
            myFriends.updateFriend(friend);
        }
    }
}
