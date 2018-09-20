using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using XTest.Services.Entities;
using XTest.Services.Services;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace XTest.VM
{
    class IterativeCodeViewModel
    {
        public ObservableCollection<IterativeCode> IterativeCode { get; set; }
        public IterativeCodeViewModel()
        {
            IterativeCodeService service = new IterativeCodeService();
            IterativeCode = new ObservableCollection<IterativeCode>
            {
                new IterativeCode { Array = service.encodeArr() },
                new IterativeCode { Array = service.makeOneMistake() }
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
