using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;

namespace Sample.ViewModel
{
    public class ViewModelLocator
    {
        #region Constructor

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);            
            SimpleIoc.Default.Register<MainViewModel>();
        }

        #endregion Constructor

        #region ViewModels

        public MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        #endregion ViewModels

        #region Methods

        public static void Cleanup() { }

        #endregion Methods
    }
}