
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
            return "Either friendship or death";
        }
        [HttpPost]
        public void add(Friend friend)
        {
            myFriends.addFriend(friend);
        }
        
    }
}
