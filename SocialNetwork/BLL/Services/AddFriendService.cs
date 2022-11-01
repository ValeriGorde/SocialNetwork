using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.DLL.Entities;
using SocialNetwork.DLL.Repositories;
using SocialNetwork.PLL.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Services
{
    public class AddFriendService
    {

        IFriendRepository friendRepository;
        IUserRepository userRepository;

        public AddFriendService() 
        {
            friendRepository = new FriendRepository();
            userRepository = new UserRepository();
        }
        public void AddFriend(AddFriendData addFriendData) 
        {
            var findUserEntity = this.userRepository.FindByEmail(addFriendData.RecipientEmail);
            if (findUserEntity is null) throw new UserNotFoundException();

            var friendEntity = new FriendEntity()
            {
                user_id = addFriendData.SenderId,
                friend_id = findUserEntity.id
            };

            if (this.friendRepository.Create(friendEntity) == 0)
                throw new Exception();

        }

        public IEnumerable<AddFriend> ChangeQuantity(int senderId) 
        {
            var friends = new List<AddFriend>();

            friendRepository.FindAllByUserId(senderId).ToList().ForEach(f =>
                {
                    var senderUserEntity = userRepository.FindById(f.user_id);
                    var recipientUserEntity = userRepository.FindById(f.friend_id);

                    friends.Add(new AddFriend(f.id, senderUserEntity.email, recipientUserEntity.email));
                });

            return friends;
        }

    }
}
