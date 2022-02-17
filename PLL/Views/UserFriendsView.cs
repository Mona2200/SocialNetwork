using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
   public class UserFriendsView
   {
      public void Show(IEnumerable<User> friends)
      {
         Console.WriteLine("Друзья:");


         if (friends.Count() == 0)
         {
            Console.WriteLine("Друзеи нет");
            return;
         }

         friends.ToList().ForEach(friend =>
         {
            Console.WriteLine(@"{0} {1}, адрес почты: {2}", friend.FirstName, friend.LastName, friend.Email);
         });
      }
   }
}
