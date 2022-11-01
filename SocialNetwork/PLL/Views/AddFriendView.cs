using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class AddFriendView
    {
        UserService userService;
        AddFriendService addFriendService;

        //public AddFriendView(UserService userService, AddFriendService addFriendService) 
        //{
        //    this.userService = userService;
        //    this.addFriendService = addFriendService;
        //}

        public void Show(User user) 
        {
            var friendData = new AddFriendData();

            Console.Write("Введите почтовый адрес вашего друга: ");
            friendData.RecipientEmail = Console.ReadLine();

            friendData.SenderId = user.Id;

            try
            {
                addFriendService.AddFriend(friendData);

                SuccessMessage.Show("Друг добавлен!");

            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }
            catch (Exception) 
            {
                AlertMessage.Show("Произошла ошибка при отправке сообщения!");
            }

        }
    }
}
