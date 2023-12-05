
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Git_withServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        MyFriends myFriends=new();
      
        [HttpPost]
        public void add(Friend friend)
        {
            myFriends.addFriend(friend);
        }
    }
}
