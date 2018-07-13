using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SidewalkPermitWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SidewalkPermitWPF.ViewModel
{
    public class PermitHistoryViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;
        ObservableCollection<PermitHistory> _permitHistory;
        public ObservableCollection<PermitHistory> PermitHistoryList
        {

            get { return _permitHistory; }

            set
            {
                _permitHistory = value;
                RaisePropertyChanged("PermitHistoryList");
            }
        }
        public ICommand PermitHistoryCommand { get; private set; }
        public PermitHistoryViewModel(IDataService dataService, long permitId)
        {
            _dataService = dataService;
            PermitHistoryList = new ObservableCollection<PermitHistory>();
            PermitHistoryView(permitId);
        }
        async void PermitHistoryView(long permitId)
        {
            var permitHistory = await _dataService.GetPermitHistoryByPermit(permitId);
            foreach(var item in permitHistory)
            {
                PermitHistoryList.Add(item);
            }
        }
    }
}
