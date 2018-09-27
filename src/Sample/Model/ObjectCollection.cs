using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System;

namespace Sample.Model
{
    public class ObjectCollection<TObject> : ObservableCollection<TObject>, INotifyPropertyChanged
    {
        #region Fields

        private TObject _Selected;

        #endregion Fields

        #region Properties

        public TObject Selected
        {
            get => _Selected;
            set
            {
                _Selected = value;
                OnPropertyChanged("IsSet");
                OnPropertyChanged("Selected");
            }
        }
        
        public bool IsSet => (Selected == null) ? false : true;

        #endregion Properties

        #region Constructors

        public ObjectCollection() : base() { }
        public ObjectCollection(List<TObject> list) : base(list) { }
        public ObjectCollection(IEnumerable<TObject> collection) : base(collection) { }

        #endregion Constructors

        #region Methods

        #endregion Methods

        #region RelayCommands

        private RelayCommand _Command_Add;
        public virtual RelayCommand Command_Add => _Command_Add ??
        (
            _Command_Add = new RelayCommand
            (
                () =>
                {
                    Selected = (TObject)Activator.CreateInstance(typeof(TObject));
                    Add(Selected);
                }
            )
        );

        private RelayCommand _Command_Remove;
        public virtual RelayCommand Command_Remove => _Command_Remove ??
        (
            _Command_Remove = new RelayCommand
            (
                () =>
                {
                    if (!IsSet) return;

                    Remove(Selected);
                    Selected = this.FirstOrDefault();
                }
            )
        );

        #endregion RelayCommands

        #region Events

#pragma warning disable CS0114
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0114
        public void OnPropertyChanged([CallerMemberName]string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        #endregion Events
    }
}