using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWFLauncher
{
    public partial class ResizingForm : Form
    {
        private int m_Width;
        private int m_Height;

        public new int Width
        {
            get { return m_Width; }
            set { m_Width = value; txtWidht.Text = value.ToString(); }
        }
        public new int Height
        {
            get { return m_Height; }
            set { m_Height = value; txtHeight.Text = value.ToString(); }
        }

        public ResizingForm()
        {
            InitializeComponent();

            this.Width = 0;
            this.Height = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int tmp;

            if (int.TryParse(txtWidht.Text, out tmp))
            {
                Width = tmp;
            }

            if (int.TryParse(txtHeight.Text, out tmp))
            {
                Height = tmp;
            }
        }
    }
}
