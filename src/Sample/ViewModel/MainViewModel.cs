using GalaSoft.MvvmLight;
using Sample.Model;

namespace Sample.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Fields

        private PersonCollection _PersonCollection = new PersonCollection()
        {
            new Person { FirstName = "Andy", LastName = "Bond", PhoneNumber = "555-123-26-93", Salary = 2300 },
            new Person { FirstName = "Jason", LastName = "Born", PhoneNumber = "555-76-12-54", Salary = 7000 },
            new Person { FirstName = "Donald", LastName = "Trump", PhoneNumber = "555-432-21-43", Salary = 5300000 },
            new Person { FirstName = "John", LastName = "Smith", PhoneNumber = "555-65-23-23", Salary = 6400 },
        };

        #endregion Fields

        #region Properties

        public PersonCollection PersonCollection
        {
            get => _PersonCollection;
            set
            {
                _PersonCollection = value;
                RaisePropertyChanged("PersonCollection");
            }
        }

        #endregion Properties

        #region Constructor

        public MainViewModel() { }

        #endregion Constructor
    }
}