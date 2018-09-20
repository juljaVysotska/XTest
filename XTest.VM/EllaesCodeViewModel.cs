using System.ComponentModel;
using XTest.Services.Entities;
using XTest.Services.Services;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace XTest.VM
{
    public class EllaesCodeViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<EllaesCode> EllaesCodes { get; set; }
        public EllaesCodeViewModel()
        {
            EllaesCodeService service = new EllaesCodeService();
            EllaesCodes = new ObservableCollection<EllaesCode>
            {
                new EllaesCode { Array = service.GenerateArray(5,5) },
                new EllaesCode { Array = service.GenerateArrayWithException(5,5) }
            };
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
