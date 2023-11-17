using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPPS.Classes
{
    internal class EquipmentUsed
    {
        private string eu_id;
        private string eu_cost;
        private string eu_duration;

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

        /*public string EU_Duration
        {
            get { return e_duration; }
            set { e_duration = value; }

        }*/
    }
}