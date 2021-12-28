using WPFDatagridInTabControlMVVM.Services.Interfaces;
using WPFDatagridInTabControlMVVM.ViewModels.Base;

namespace WPFDatagridInTabControlMVVM.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private readonly IUserDialog _UserDialog;
        private readonly IDataService _DataService;

        #region Title : string - Заголовок окна

        /// <summary>Заголовок окна</summary>
        private string _Title = "Главное окно";

        /// <summary>Заголовок окна</summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        #endregion

        #region Status : string - Статус

        /// <summary>Статус</summary>
        private string _Status = "Готов!";

        /// <summary>Статус</summary>
        public string Status { get => _Status; set => Set(ref _Status, value); }

        #endregion


        #region CurrentViewModel : ViewModel - текущая модель представления

        ///<summary>текущая модель представления</summary>
        private ViewModel _CurrentViewModel;

        ///<summary>текущая модель представления</summary>
        public ViewModel CurrentViewModel { get => _CurrentViewModel; set => Set(ref _CurrentViewModel, value); }

        #endregion


        public MainWindowViewModel(IUserDialog UserDialog, IDataService DataService)
        {
            _UserDialog = UserDialog;
            _DataService = DataService;
        }
    }
}
