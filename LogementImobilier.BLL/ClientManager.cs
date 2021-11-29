using LogementImobilier.BO;
using LogementImobilier.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BLL
{
    public class ClientManager
    {
        ClientRepository repository;
        public ClientManager()
        {
            repository = new ClientRepository();
        }
        public void AddClient(Client client)
        {
            repository.Add(client);
        }
    }
}
