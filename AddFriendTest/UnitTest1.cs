using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Views;

namespace AddFriendTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyFriendsViewTest()
        {
            IEnumerable<AddFriend> friends = new List<AddFriend>()
            {
                new AddFriend(1, "lera@gmail.com", "bragin@gmail.com")
            };

            var myFriendsView = new MyFriendsView();
            myFriendsView.Show(friends);

        }

        [TestMethod]
        public void AddFriendsTest() 
        {
            var addFriendData = new AddFriendData()
            {
                SenderId = 1,
                RecipientEmail = "bragin@gmail.com"
            };

            var addFriendService = new AddFriendService();
            addFriendService.AddFriend(addFriendData);
        }
    }
}