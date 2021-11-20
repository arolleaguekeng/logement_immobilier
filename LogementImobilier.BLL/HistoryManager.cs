using LogementImobilier.BO;
using LogementImobilier.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.BLL
{
    public class HistoryManager
    {
        public HistoricRepository historic;
        public HistoryManager()
        {
            historic = new HistoricRepository();
        }

        public void AddHistory(Historic history)
        {
            historic.Add(history);
        }
        public List<Historic> ShowHistory(Historic history)
        {
            return historic.GetAll();
        }

    }
}
