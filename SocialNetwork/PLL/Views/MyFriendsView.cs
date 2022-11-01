using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class MyFriendsView
    {
        public void Show(IEnumerable<AddFriend> friends) 
        {
            Console.WriteLine("Мои друзья: ");

            if (friends.Count() == 0)
            {
                Console.WriteLine("У вас пока что нет друзей.");
                return;
            }

            friends.ToList().ForEach(friend =>
            {
                Console.WriteLine(friend.RecipientEmail);
            });

            Console.WriteLine();

        }
    }
}
