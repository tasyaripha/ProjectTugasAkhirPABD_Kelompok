using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class HomePage : Form
    {
        private Rectangle originalFormSize;
        private Rectangle buttonOriginalRectangle;

        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            buttonOriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
        }

        private void ResizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void HomePage_Resize(object sender, EventArgs e)
        {
            ResizeControl(buttonOriginalRectangle, button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriesPage cp = new CategoriesPage();
            cp.Show();
            Hide();
        }
    }
}
