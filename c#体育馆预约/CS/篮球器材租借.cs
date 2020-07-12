using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp1
{
    public partial class 篮球器材租借 : Form
    {
        //private Color tr_color = Color.Transparent;
        //private bool b_start = false;
        //bool[] b_visible = null;
        public 篮球器材租借()
        {
            InitializeComponent();
        }

        private void 器材租借_Load(object sender, EventArgs e)
        {
            //SetBackgroundImageTransparent();
            
        }
        //private void SetBackgroundImageTransparent()
        //{
        //    Point pt = this.PointToScreen(new Point(0, 0));
        //    Bitmap b = new Bitmap(this.Width, this.Height);
        //    using (Graphics g = Graphics.FromImage(b))
        //    {
        //        g.CopyFromScreen(pt, new Point(), new Size(this.Width, this.Height));
        //    }
        //    this.BackgroundImage = b;
        //}
        //private void BeginSet()
        // {
        //     tr_color = this.TransparencyKey;
        //     b_start = true;
        // }
        //private void Setting()
        // {
        //     if (b_start)
        //     {
        //         b_visible = new bool[Controls.Count];
        //         for (int i = 0; i<Controls.Count; i++)
        //         {
        //             b_visible[i] = Controls[i].Visible;
        //             Controls[i].Visible = false;
        //         }
        //         BackgroundImage = null;
        //         BackColor = Color.White;
        //         b_start = false;
        //         this.TransparencyKey = Color.White;
        //     }
        // }
        // private void EndSet()
        // {
        //     SetBackgroundImageTransparent();
        //     this.TransparencyKey = tr_color;
        //     for (int i = 0; i<Controls.Count; i++)
        //     {
        //             Controls[i].Visible = b_visible[i];
        //         }
        //     b_start = false;
        // }
 
        // private void Form1_Resize(object sender, EventArgs e)
        // {
        //     Setting();
        // }
        // private void Form1_ResizeBegin(object sender, EventArgs e)
        // {
        //     BeginSet();
        // }
        // private void Form1_ResizeEnd(object sender, EventArgs e)
        // {
        //     EndSet();
        // }
        // private void Form1_Move(object sender, EventArgs e)
        // {
        //     Setting();
        // }
        private void btnBasketball_Click(object sender, EventArgs e)
        {
            Form form = new 器材预约();
            //form0.showChildForm(form);

            form.FormBorderStyle = FormBorderStyle.None;
            form.ControlBox = false;
            form.Size = new Size(this.Size.Width - 15, this.Size.Height - 25);
            form.Location = new Point(SystemInformation.WorkingArea.Width - form.Width, SystemInformation.WorkingArea.Height - form.Height);
            form.Show();
        }

        private void btnTennis_Click(object sender, EventArgs e)
        {

        }

        private void btnSoccer_Click(object sender, EventArgs e)
        {

        }

        private void btnBasketball1_Click(object sender, EventArgs e)
        {

        }

        private void btnBadminton_Click(object sender, EventArgs e)
        {

        }

        private void btnPingpang_Click(object sender, EventArgs e)
        {

        }
    }
}
