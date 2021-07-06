using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public class MyButton : Control {

        private bool TurnedOn;

        readonly Color OnColor;
        readonly Color OffColor;
        readonly Color CircleColor;

        readonly int WidthMultiplier;
        readonly int HeightMultiplier;

        public MyButton()
        {
            BackColor = Color.Black;
            TurnedOn = true;
            this.Paint += Draw;
            this.Click += Button_Click;

            OnColor = Color.Green;
            OffColor = Color.Red;
            CircleColor = Color.Black;

            WidthMultiplier = 20;
            HeightMultiplier = 10;
        }

        private void Button_Click(object sender, EventArgs e) {
           TurnedOn = !TurnedOn;
           
           Invalidate();
        }

        public void Draw(object sender, PaintEventArgs e) {
            var a = this.CreateGraphics();
            
            a.FillRectangle(new SolidBrush(TurnedOn == true ? OnColor : OffColor), new Rectangle( Size.Width / WidthMultiplier, Size.Width / WidthMultiplier, Size.Width - Size.Width / HeightMultiplier, Size.Height - Size.Width / HeightMultiplier));

            if (TurnedOn == true) {
                  a.FillEllipse(new SolidBrush(CircleColor), new Rectangle( + Size.Width / WidthMultiplier,  Size.Width / WidthMultiplier, Size.Height - Size.Width / HeightMultiplier, Size.Height - Size.Width / HeightMultiplier));
            }
            else {
                a.FillEllipse(new SolidBrush(CircleColor), new Rectangle( Size.Width - Size.Height + Size.Width / WidthMultiplier, Size.Width / WidthMultiplier, Size.Height - Size.Width / HeightMultiplier, Size.Height - Size.Width / HeightMultiplier));
            }
        }
    }
}
