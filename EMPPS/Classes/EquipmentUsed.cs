using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPPS.Classes
{
    internal class EquipmentUsed
    {
        private string eup_id;
        private string eu_id;
        private string eu_cost;
        private int eu_duration;

        public string EUP_ID
        {
            get { return eup_id; }
            set {  eup_id = value; }
        }

        public string EU_ID
        {
            get { return eu_id; }
            set { eu_id = value; }
        }

        public string EU_Cost
        {
            get { return eu_cost; }
            set { eu_cost = value; }
        }

        public int EU_Duration
        {
            get { return eu_duration; }
            set { eu_duration = value; }

        }

        public EquipmentUsed(string eup_id, string eu_id, string eu_cost, int eu_duration)
        {
            this.eup_id = eup_id;
            this.eu_id = eu_id;
            this.eu_cost = eu_cost;
            this.eu_duration = eu_duration;
        }
    }
}