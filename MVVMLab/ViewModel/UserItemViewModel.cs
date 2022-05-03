using MVVMLab.Model;
using System;

namespace MVVMLab.ViewModel
{
    public class UserItemViewModel:ViewModelBase
    {
        private readonly UserModel _model;

        public UserItemViewModel(UserModel model)
        {
            _model = model;
        }

        public Guid Id => _model.Id;

        public string? FirstName
        {
            get=> _model.FirstName;
            set
            {
                if(_model.FirstName != value)
                {
                    _model.FirstName = value;
                    RaisePropertyChanged();
                }
            }
        }
        public string? LastName
        {
            get => _model.LastName;
            set
            {
                if (_model.LastName != value)
                {
                    _model.LastName = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool IsAdmin
        {
            get => _model.IsAdmin;
            set
            {
                if (_model.IsAdmin != value)
                {
                    _model.IsAdmin = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
}
