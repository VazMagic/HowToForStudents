using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowTo
{
    public partial class frmSecondForm : Form
    {
        public frmSecondForm()
        {
            InitializeComponent();
        }

        private void frmSecondForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(ThreadHowToForm));
            t.Start();
        }

        private void ThreadHowToForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmHowTo());
        }
    }
}
