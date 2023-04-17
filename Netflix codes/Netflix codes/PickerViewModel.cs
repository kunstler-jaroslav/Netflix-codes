using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using static Netflix_codes.Data;

namespace Netflix_codes
{
    internal class PickerViewModel : BaseViewModel
    {
        public PickerViewModel()
        {
            DataSource = new ObservableCollection<Gener>();
            AddToList();
        }

        public ObservableCollection<Gener> DataSource { get; set; }
        public void AddToList()
        {
            foreach(Gener current in GenerData)
            {
                DataSource.Add(current);
            }
        }
    }
}
