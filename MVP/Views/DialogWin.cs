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
    public partial class DialogWin : DockContent
    {
        public DialogWin()
        {
            InitializeComponent();
        }

        private void DialogWin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MsgBox.Show("Are you sure you want to exit?", "Exit", MsgBox.Buttons.YesNo, MsgBox.Icon.Info, MsgBox.AnimateStyle.FadeIn);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Exiting now");
            }
        }
    }
}
