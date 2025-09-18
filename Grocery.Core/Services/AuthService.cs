using Grocery.Core.Helpers;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IClientService _clientService;
        public AuthService(IClientService clientService)
        {
            _clientService = clientService;
        }
        public Client? Login(string email, string password)
        {
            //Vraag de klantgegevens [Client] op die je zoekt met het opgegeven emailadres
            //Als je een klant gevonden hebt controleer dan of het password matcht --> PasswordHelper.VerifyPassword(password, passwordFromClient)
            //Als alles klopt dan klantgegveens teruggeven, anders null

            Client client = _clientService.Get(email);
            // Controls if the client does not exist.
            if (client == null)
            {
                return null;
            }
            
            // Gets the password from the client
            bool pass = PasswordHelper.VerifyPassword(password, client.password);
            // If the password is not the same it directly returns null and stops the method
            if (pass == false)
            {
                return null;
            }
            
            return client;
        }
    }
}
