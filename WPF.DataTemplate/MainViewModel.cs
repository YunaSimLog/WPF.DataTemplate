using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfBase;

namespace WPF.DataTemplate
{
    public class MainViewModel : ViewModelBase
    {
        private List<Student> students = default;

        public MainViewModel()
        {
            students = Student.Students;
            CurrentViewModel=new TestViewModel();
        }

        public  List<Student> Students
        {
            get => students;
            set
            {
                students = value;
                OnPropertyChanged();
            }
        }

        public ViewModelBase CurrentViewModel { get; set; }
    }

}
