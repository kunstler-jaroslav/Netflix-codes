using System;
using System.Collections.Generic;
using System.Text;
using static Netflix_codes.Data;
using System.Collections.ObjectModel;
using MvvmHelpers;

namespace Netflix_codes
{
    internal class PickerFavoriteViewModel : BaseViewModel
    {

        public PickerFavoriteViewModel(List<Code> codes)
        {
            DataSource = new ObservableCollection<Subgener>();
            AddToList(codes);
        }

        public ObservableCollection<Subgener> DataSource { get; set; }

        public void AddToList(List<Code> codes)
        {
            foreach (Subgener current in SubgenerData)
            {
                foreach(Code code in codes)
                {
                    if (current.Code == code.Number.ToString())
                        DataSource.Add(current);
                }
            }
        }
    }
}
