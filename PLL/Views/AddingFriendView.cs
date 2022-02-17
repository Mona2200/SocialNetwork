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
   public class AddingFriendView
   {
      FriendService friendService;

      public AddingFriendView(FriendService friendService)
      {
         this.friendService = friendService;
      }

      public void Show(User user)
      {
         var addingFriendData = new AddingFriendData();

         Console.Write("Введите почтовый адрес пользователя для добавления его в друзья: ");
         addingFriendData.FriendEmail = Console.ReadLine();

         addingFriendData.UserId = user.Id;

         try
         {
            friendService.AddFriend(addingFriendData);
            SuccessMessage.Show("Друг успешно добавлен!");
            
         }

         catch (UserNotFoundException)
         {
            AlertMessage.Show("Пользователь не найден!");
         }

         catch (Exception)
         {
            AlertMessage.Show("Произошла ошибка во время процесса добавления в друзья!");
         }

      }

   }
}
