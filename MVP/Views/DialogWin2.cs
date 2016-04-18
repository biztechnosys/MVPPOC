using MVP.Views.ViewContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MVP.Views
{
    public partial class DialogWin2 : DockContent, IMainView
    {
        public DialogWin2()
        {
            InitializeComponent();
        }

        private void DialogWin2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.DataChanged != null)
            {
                this.DataChanged(sender, e);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.DataChanged != null)
            {
                this.DataChanged(sender, e);
            }
        }

        public event EventHandler DataChanged;

        public event EventHandler ShowDataClicked;

        public string FirstName
        {
            get { return this.textBox1.Text; }
            set { this.textBox1.Text = value; }
        }

        public string LastName
        {
            get { return this.textBox2.Text; }
            set { this.textBox2.Text = value; }
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            if (this.ShowDataClicked != null)
            {
                this.ShowDataClicked(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
