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
        public ClientRepository clientRepository;

        public ClientManager()
        {
            clientRepository = new ClientRepository();
        }
        public void AddClient(Client client)
        {
            clientRepository.Add(client);
        }
        //ksdfjhsdjkfsdhfkj 
    }
}
