using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public class MyButton : Control {

        public bool TurnedOn {get; set;}
       
        public MyButton()
        {
            BackColor = Color.Black;
            TurnedOn = false;
            this.Paint += Draw;
            this.Click += MyButton_Click;
        }

        private void MyButton_Click(object sender, EventArgs e) {
           TurnedOn = !TurnedOn;

           Invalidate();
        }

        public void Draw(object sender, PaintEventArgs e) {
            var a = this.CreateGraphics();
            
            a.FillRectangle(new SolidBrush(TurnedOn == true ? Color.LightGreen : Color.Red), new Rectangle( Size.Width / 20, Size.Width / 20, Size.Width - Size.Width / 10, Size.Height - Size.Width / 10));

            if (TurnedOn == true) {
                  a.FillEllipse(new SolidBrush(Color.Black), new Rectangle( + Size.Width / 20,  Size.Width / 20, Size.Height - Size.Width / 10, Size.Height - Size.Width / 10));
            }
            else {
                a.FillEllipse(new SolidBrush(Color.Black), new Rectangle( Size.Width - Size.Height + Size.Width / 20,Size.Width / 20, Size.Height - Size.Width / 10, Size.Height - Size.Width / 10));
            }
        }
    }
}
