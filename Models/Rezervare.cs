using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SQLite;

namespace Mobile.Models
{
    public class Rezervare: INotifyPropertyChanged
    {
        [PrimaryKey, AutoIncrement]
        public int ID {  get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private DateTime _data_start;
        public DateTime Data_start
        {
            get { return _data_start; }
            set
            {
                if (_data_start != value)
                {
                    _data_start = value;
                    OnPropertyChanged(nameof(Data_start));
                }
            }
        }

        private DateTime _data_end;
        public DateTime Data_end
        {
            get { return _data_end; }
            set
            {
                if (_data_end != value)
                {
                    _data_end = value;
                    OnPropertyChanged(nameof(Data_end));
                }
            }
        }

     

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
    
}
