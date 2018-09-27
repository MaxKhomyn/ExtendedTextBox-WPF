using GalaSoft.MvvmLight;

namespace Sample.Model
{
    public class Person : ViewModelBase
    {
        #region Fields

        private string _FirstName;
        private string _LastName;
        private string _PhoneNumber;
        private double _Salary;

        #endregion Fields

        #region Properties

        public string FirstName
        {
            get => _FirstName;
            set
            {
                _FirstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get => _LastName;
            set
            {
                _LastName = value;
                RaisePropertyChanged("LastName");
            }
        }

        public string PhoneNumber
        {
            get => _PhoneNumber;
            set
            {
                _PhoneNumber = value;
                RaisePropertyChanged("PhoneNumber");
            }
        }

        public double Salary
        {
            get => _Salary;
            set
            {
                _Salary = value;
                RaisePropertyChanged("Salary");
            }
        }

        #endregion Properties
    }
}