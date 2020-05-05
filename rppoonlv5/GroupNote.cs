using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoonlv5
{
    class GroupNote:Note
    {
        private List<User> user;
        public GroupNote(string message, ITheme theme, List<User> user) : base(message, theme)
        {
            this.user = user;
        }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("REMINDER: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
        public void addUser(User user)
        {
            this.user.Add(user);
        }
        public void removeUser(User user)
        {
            this.user.Remove(user);
        }
    }
}
