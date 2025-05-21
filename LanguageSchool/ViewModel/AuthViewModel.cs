using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageSchool.Model;
using LanguageSchool.ViewModel.Base;
using System.Windows.Input;
using System.Windows.Navigation;

namespace LanguageSchool.ViewModel
{
    public class AuthViewModel : NotifyPropertyChanged
    {
        private string _phone;
        private string _password;
        private string _errorMessage;

        public string Phone
        {
            get => _phone;
            set => SetProperty(ref _phone, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set => SetProperty(ref _errorMessage, value);
        }

        public ICommand LoginCommand { get; }

        private readonly LanguageSchoolContext _context = new();

        public AuthViewModel()
        {
            LoginCommand = new RelayCommand(OnLogin);
        }

        private void OnLogin()
        {
            var user = _context.Users
                .Include(u => u.Role)
                .FirstOrDefault(u => u.Phone == Phone && u.Password == Password);

            if (user == null)
            {
                ErrorMessage = "Неверный телефон или пароль";
                return;
            }

            switch (user.Role.RoleName)
            {
                case "Администратор":
                    NavigationService.Navigate(new AdminPage());
                    break;
                case "Менеджер":
                    NavigationService.Navigate(new ManagerPage());
                    break;
                case "Преподаватель":
                    NavigationService.Navigate(new TeacherPage());
                    break;
                case "Клиент":
                    NavigationService.Navigate(new ClientCabinetPage(user.UserID));
                    break;
            }
        }
    }
}
