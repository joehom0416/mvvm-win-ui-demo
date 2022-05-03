using MVVMLab.Data;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MVVMLab.ViewModel
{
    /// <summary>
    /// the ViewModel of MVVM pattern, it used to keep State of the model and notify View if Model has changed. 
    /// </summary>
    public class MainViewModel: ViewModelBase
    {
        private readonly IUserDataProvider _userDataProvider;
        private UserItemViewModel? _selectedUser;
        public MainViewModel(IUserDataProvider userDataProvider)
        {
            _userDataProvider= userDataProvider;
        }

        public ObservableCollection<UserItemViewModel> Users { get; } = new();

        public UserItemViewModel? SelectedUser
        {
            get => _selectedUser;
            set
            {
                if(_selectedUser!= value)
                {
                    _selectedUser = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(IsUserSelected));
                }
            }
        }

        public bool IsUserSelected => SelectedUser is not null;
        /// <summary>
        /// Get data from data provider, fill Users 
        /// </summary>
        /// <returns></returns>
        public async Task LoadAsync()
        {
            if (Users.Any())
            {
                return;
            }

            var users = await _userDataProvider.GetAllAsync();
            if (users is not null)
            {
                foreach (var user in users)
                {
                    Users.Add(new UserItemViewModel(user));
                }
            }
        }
    }
}
