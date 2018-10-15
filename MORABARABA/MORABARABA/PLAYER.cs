using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Morabaraba
{
    class PLAYER
    {
        public string Name { get; set; }

        public ImageSource Image { get; internal set; }

        public int Cows = 12;

        PlayerMark Mark { get; set; }

        ClickType Click { get; set; }

        public PLAYER(string Name, ImageSource image)
        {
            this.Name = Name;
            Image = image;
        }

        public PLAYER (string Name, ImageSource Image, PlayerMark Mark, ClickType Click)
        {
            this.Name = Name;
            this.Image = Image;
            this.Mark = Mark;
            this.Click = Click;
        }
        
    }
}
