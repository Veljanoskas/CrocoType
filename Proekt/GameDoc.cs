using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proekt
{
    public class GameDoc
    {
        public string Word = "CROCODILE";

        public GameDoc()
        {

        }

        public void Draw(Graphics g, Point position)
        {
            Brush b = new SolidBrush(Color.Black);
            g.DrawString(Word, new Font("Arial", 25), b, position.X, position.Y);
            b.Dispose();
        }
    }
}
