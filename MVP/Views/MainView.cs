using MVP.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP.Views;
using WeifenLuo.WinFormsUI.Docking;
using MVP.Views.ViewContracts;
using MVP.Model;
namespace MVP
{
    public partial class MainView : DockContent
    {
        IMainViewModel model;
        IMainView view;
        public MainView()
        {
            InitializeComponent();
          
        }

        private void addNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogWin dw = new DialogWin();
            dw.Show(dockPanel1, DockState.DockTop);
        }

        private void dockPanel1_ActiveContentChanged(object sender, EventArgs e)
        {

        }

        private void MainView_Load(object sender, EventArgs e)
        {
            DialogWin dw = new DialogWin();
            dw.Show(dockPanel1, DockState.DockTop);
            DialogWin dw1 = new DialogWin();
            dw1.Show(dockPanel1, DockState.DockRight);

            //DialogWin2 d2 = new DialogWin2();
            //d2.Show(dockPanel1, DockState.DockRightAutoHide);
            OpenMVPWindow();

            DialogWin3 d3 = new DialogWin3();
            d3.Show(dockPanel1, DockState.DockBottom);
        }

        private void shownameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DialogWin2 d2 = new DialogWin2();
            //d2.Show(dockPanel1, DockState.DockRight);
            OpenMVPWindow();
        }

        private void thirdWinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogWin3 d3 = new DialogWin3();
            d3.Show(dockPanel1, DockState.DockBottom);
        }

        private void OpenMVPWindow()
        {
            model = new MainViewModel();
            view = new DialogWin2();
            new MainPresenter(model, view);
            view.Show(dockPanel1, DockState.DockLeft);
        }
    }
}
