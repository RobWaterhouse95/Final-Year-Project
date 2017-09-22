using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Client
{
    public class HoverButton : Button
    {
        public int level = 0;
        ClientForm ParentForm;
        public int _x;
        public int _y;
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="size">Width of button</param>
        /// <param name="x">co-ords x</param>
        /// <param name="y">co-ords y</param>
        /// <param name="p">Parent form</param>
        /// <param name="a">Array width value of this button</param>
        /// <param name="b">Array height value of this button</param>
        public HoverButton(int size, int x, int y, ClientForm p, int a, int b)
        {
            ParentForm = p;
            this.Width = size;
            this.Height = size;
            this.Location = new Point(x, y);
            base.BackColor = returnColour();
            this._x = a;
            this._y = b;
        }

        public void fakeMouseEnter()
        {
            base.BackColor = Color.FromArgb(255, 0, 0, 0);
            level = 6;
            ParentForm.conn.sendData("1xx" + "," + _x + "," + _y);
            tick();
        }
        
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            base.BackColor = Color.FromArgb(255, 0, 0, 0);
            level = 6;
            ParentForm.conn.sendData("1xx" + "," + _x + "," + _y);
            tick();
        }

        public async void tick()
        {
            while(level >= 0)
            {
                level--;
                UpdateAlphaLevel();
                await Task.Delay(500);
                Application.DoEvents();
            }
        }

        private void UpdateAlphaLevel()
        {
            base.BackColor = returnColour();
        }

        private Color returnColour()
        {
            switch (level)
            {
                case 0:
                    return SystemColors.Control;
                case 1:
                    return Color.FromArgb(255 / 5, 0, 0, 0);
                case 2:
                    return Color.FromArgb(255 / 4, 0, 0, 0);
                case 3:
                    return Color.FromArgb(255 / 3, 0, 0, 0);
                case 4:
                    return Color.FromArgb(255 / 2, 0, 0, 0);
                case 5:
                    return Color.FromArgb(255 / 1, 0, 0, 0);
                default:
                    return SystemColors.Control;
            }
        }
    }
}
