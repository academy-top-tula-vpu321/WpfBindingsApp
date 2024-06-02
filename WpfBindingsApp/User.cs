using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfBindingsApp
{
    public class User : INotifyPropertyChanged
    {
        private string name = null!;
        private int age;
        private string? email;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public int Age
        {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged();
            }
        }
        public string? Email
        {
            get => email;
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<string> Langs { get; set; } = new() { "C#", "C++", "Java" };

        public override string ToString()
        {
            return $"{Name} {Age} {Email}";
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string property = "")
        {
            if(PropertyChanged is not null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
