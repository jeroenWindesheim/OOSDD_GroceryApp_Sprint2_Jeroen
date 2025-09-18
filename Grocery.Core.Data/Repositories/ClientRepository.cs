
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private List<Client> clientList;
        // private readonly List<Client> clientList;

        private int clientId;

        public ClientRepository()
        {
            clientList = [
                new Client(1, "M.J. Curie", "user1@mail.com", "IunRhDKa+fWo8+4/Qfj7Pg==.kDxZnUQHCZun6gLIE6d9oeULLRIuRmxmH2QKJv2IM08="),
                new Client(2, "H.H. Hermans", "user2@mail.com", "dOk+X+wt+MA9uIniRGKDFg==.QLvy72hdG8nWj1FyL75KoKeu4DUgu5B/HAHqTD2UFLU="),
                new Client(3, "A.J. Kwak", "user3@mail.com", "sxnIcZdYt8wC8MYWcQVQjQ==.FKd5Z/jwxPv3a63lX+uvQ0+P7EuNYZybvkmdhbnkIHA=")
            ];
        }

        public Client? Get(string email)
        {
            // Checks the email of the client to the information
            // Run through the clients
            for (int pos = 0; pos < clientList.Count; pos++)
            {
                

                if (clientList[pos].emailAddress == email)
                {
                    clientId = pos;
                    break;
                }
            }
            return clientList[clientId];
        }

        public Client? Get(int id)
        {
            // Checks the id for the client to get the information
            // Loop through the clients
            for (int pos = 0; pos < clientList.Count; pos++)
            {
                if (clientList[pos].Id == id)
                {
                    clientId = pos;
                    break;
                }
            }
            return clientList[clientId];
        }

        public List<Client> GetAll()
        {
            return clientList;
        }
    }
}
