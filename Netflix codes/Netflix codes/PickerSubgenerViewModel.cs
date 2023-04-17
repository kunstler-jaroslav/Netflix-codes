using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using MvvmHelpers;
using static Netflix_codes.Data;

namespace Netflix_codes
{
    internal class PickerSubgenerViewModel : BaseViewModel
    {
        public PickerSubgenerViewModel(int gener)
        {
            DataSource = new ObservableCollection<Subgener>();
            AddToList(gener);
        }

         public ObservableCollection<Subgener> DataSource { get; set; }

        public void AddToList(int gener)
        {
            string Gener = gener.ToString();
            if(Gener == "0")
            {
                foreach(Subgener current in SubgenerData)
                {
                    DataSource.Add(current);
                }
            }
            else
            {
                foreach (Subgener current in SubgenerData)
                {
                    if(current.GenerCode == Gener)
                        DataSource.Add(current);
                }
            }
        }
    }
}
