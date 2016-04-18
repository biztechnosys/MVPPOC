using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP.Model;
using MVP.Views;
using MVP.Views.ViewContracts;
using System.Windows.Forms;

namespace MVP.Presenter
{
    public class MainPresenter 
    {
        IMainViewModel _model;
        IMainView _view;
        public MainPresenter(IMainViewModel model, IMainView view)
        {
            this._view = view;
            this._model = model;

            this._model.FirstName = "This is from";
            this._model.LastName = "Model to View - Via Presenter";

            this.SetViewPropertiesFromModel();

            this.WireUpViewEvents();
        }

        private void WireUpViewEvents()
        {
            this._view.DataChanged += _view_DataChanged;
            this._view.ShowDataClicked += _view_ShowDataClicked;
        }

        void _view_ShowDataClicked(object sender, EventArgs e)
        {
            MessageBox.Show(this._model.FirstName + " " + this._model.LastName);
        }

        void _view_DataChanged(object sender, EventArgs e)
        {
            this.SetModelPropertiesFromView();
        }

        private void SetModelPropertiesFromView()
        {
            this._model.FirstName = this._view.FirstName;
            this._model.LastName = this._view.LastName;
        }

        private void SetViewPropertiesFromModel()
        {
            this._view.FirstName = this._model.FirstName;
            this._view.LastName = this._model.LastName;
        }

    }
}
