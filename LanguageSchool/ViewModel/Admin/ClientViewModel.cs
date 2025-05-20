using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageSchool.Model.Entities;
using LanguageSchool.Model;
using LanguageSchool.ViewModel.Base;
using System.Windows.Input;

namespace LanguageSchool.ViewModel.Admin
{
    public class ClientViewModel : NotifyPropertyChanged
    {
        private ObservableCollection<Client> _clients;
        private Client _selectedClient;

        public ObservableCollection<Client> Clients
        {
            get => _clients;
            set => SetProperty(ref _clients, value);
        }

        public Client SelectedClient
        {
            get => _selectedClient;
            set => SetProperty(ref _selectedClient, value);
        }

        public ICommand AddClientCommand { get; }
        public ICommand DeleteClientCommand { get; }

        private readonly LanguageSchoolContext _context = new();

        public ClientViewModel()
        {
            LoadClients();
            AddClientCommand = new RelayCommand(AddClient);
            DeleteClientCommand = new RelayCommand(DeleteClient, CanDelete);
        }

        private void LoadClients()
        {
            Clients = new(_context.Clients.Include(c => c.User));
        }

        private void AddClient()
        {
            var newClient = new Client { UserID = 1, AdditionalInfo = "Новый клиент" };
            Clients.Add(newClient);
            SaveToDatabase(newClient);
        }

        private void DeleteClient()
        {
            if (SelectedClient != null)
            {
                Clients.Remove(SelectedClient);
                DeleteFromDatabase(SelectedClient);
            }
        }

        private bool CanDelete() => SelectedClient != null;
    }
}
