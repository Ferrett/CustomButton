using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public class MyButton : Control {
        public bool TurnedOn;
        
        Brush brush = new SolidBrush(Color.Gray);

        Brush brush2 = new SolidBrush(Color.LightGreen);

        Brush brush3 = new SolidBrush(Color.Black);

        public MyButton() : base() {
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
            
            a.FillRectangle(brush2 = new SolidBrush(TurnedOn == true ? Color.LightGreen : Color.Red), new Rectangle( Size.Width / 20, Size.Width / 20, Size.Width - Size.Width / 10, Size.Height - Size.Width / 10));

            if (TurnedOn == true) {
                a.FillEllipse(brush3, new Rectangle( + Size.Width / 20,  Size.Width / 20, Size.Height - Size.Width / 10, Size.Height - Size.Width / 10));
            }
            else {
                a.FillEllipse(brush3, new Rectangle( Size.Width - Size.Height + Size.Width / 20,Size.Width / 20, Size.Height - Size.Width / 10, Size.Height - Size.Width / 10));
            }
        }
    }
}
