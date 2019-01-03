using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MDE_Version_2._0
{
   public class SqliteCollectionModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _anzahl;
        

      
        public int Artikel_ID { get; set; }
        public string Fabrikat { get; set; }
        public string Artikelbezeichnung { get; set; }

        public int Anzahl
        {
            get => _anzahl;
            set
            {
                if (value == this._anzahl) return;
                this._anzahl = value;
                OnPropertyChanged("Anzahl");
            }
        }
       

        public string EAN { get; set; }
        public string Warenbereich { get; set; }
        public int WarenbereichId { get; set; }
        public string Name { get; set; }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
