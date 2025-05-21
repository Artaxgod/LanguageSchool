using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageSchool.Model.Entities;
using LanguageSchool.Model;

namespace LanguageSchool.Services
{
    public class ClientService
    {
        private readonly LanguageSchoolContext _context = new();

        public void AddClient(Client client)
        {
            if (string.IsNullOrEmpty(client.User.Email))
                throw new ArgumentException("Email обязателен");

            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void DeleteClient(int clientID)
        {
            var client = _context.Clients.Find(clientID);
            _context.Clients.Remove(client);
            _context.SaveChanges();
        }
    }
}
