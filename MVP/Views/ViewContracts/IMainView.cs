using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP.Model;
using WeifenLuo.WinFormsUI.Docking;
using System.Drawing;

namespace MVP.Views.ViewContracts
{
    public interface IMainView : IDataModel
    {
        event EventHandler DataChanged;
        event EventHandler ShowDataClicked;
        void Show();
        void Show(DockPanel dockPanel);
        void Show(DockPane pane, IDockContent beforeContent);
        void Show(DockPanel dockPanel, DockState dockState);
        void Show(DockPanel dockPanel, Rectangle floatWindowBounds);
        void Show(DockPane previousPane, DockAlignment alignment, double proportion);
    }
}
