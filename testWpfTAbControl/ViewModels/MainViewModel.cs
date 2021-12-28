using MathCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWpfTAbControl
{
    class MainViewModel : ViewModel
    {
      //  public ObservableCollection<TabItem> Tabs { get; set; }


        #region Tabs : ObservableCollection<TabItem> - tabControl tabs

        ///<summary>tabControl tabs</summary>
        private ObservableCollection<TabItem> _Tabs;

        ///<summary>tabControl tabs</summary>
        public ObservableCollection<TabItem> Tabs { get => _Tabs; set => Set(ref _Tabs, value); }

        #endregion

        #region SelectedTab : TabItem - selected tab

        ///<summary>selected tab</summary>
        private TabItem _SelectedTab;

        ///<summary>selected tab</summary>
        public TabItem SelectedTab { get => _SelectedTab; set => Set(ref _SelectedTab, value); }

        #endregion


        public MainViewModel()
        {
            Tabs = new ObservableCollection<TabItem>();
            Tabs.Add(new TabItem { Header = "Header1", Content = new View1Model(1) });
            //should any data context be placed here??????
            Tabs.Add(new TabItem { Header = "Header2", Content = new View1Model(2) });
           // OnPropertyChanged(Tabs);
        }
    }
}
