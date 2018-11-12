using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatonBodiesTask
{
    public partial class FormTools : Form
    {
        public FormTools()
        {
            InitializeComponent();
        }

        private void FormTools_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(w-this.Width,20);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            byte flBody = 0;
            if (radioButton1.Checked == true)
                flBody = 0;
            if (radioButton2.Checked == true)
                flBody = 1;
            if (radioButton3.Checked == true)
                flBody = 2;
            if (radioButton4.Checked == true)
                flBody = 3;
            if (radioButton5.Checked == true)
                flBody = 4;
            PlatonBody.body = new Body(flBody);
            FormMain.MyDraw();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.flRotate = false;
            FormMain.MyDraw();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.flRotate = true;
            FormMain.MyDraw();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.flEdge = 0;
            FormMain.MyDraw();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.flEdge = 1;
            FormMain.MyDraw();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.flEdge = 2;
            FormMain.MyDraw();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.visibleOXYZ = checkBox1.Checked;
            FormMain.MyDraw();
        }
    }
}
