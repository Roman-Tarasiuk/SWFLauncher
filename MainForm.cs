using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWFLauncher
{
    public partial class MainForm : Form
    {
        const string MainFormTitle = "SWF Launcher";

        private TransparentPanel panel1;
        private Size m_PanelSize = new Size(332, 235);

        public MainForm()
        {
            InitializeComponent();

            InitializePanel();
        }

        private void InitializePanel()
        {
            this.panel1 = new TransparentPanel();

            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = m_PanelSize;

            panel1.Moving += Panel1_Moving;

            this.panel1.ContextMenuStrip = contextMenuStrip1;

            this.Controls.Add(this.panel1);

            this.panel1.BringToFront();
        }

        private void Panel1_Moving(object sender, MovingPanelEventArgs e)
        {
            //Location = PointToScreen(new Point(e.X - 8, e.Y - 30));
            Location = PointToScreen(new Point(e.X, e.Y));
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                webBrowser1.Url = new Uri(openFileDialog1.FileName);
                this.Text = Path.GetFileName(openFileDialog1.FileName) + " - " + MainFormTitle;
            }
        }

        private void topmostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            topmostToolStripMenuItem.Checked = this.TopMost;
        }

        private void readyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.SendToBack();
        }
    }
}
