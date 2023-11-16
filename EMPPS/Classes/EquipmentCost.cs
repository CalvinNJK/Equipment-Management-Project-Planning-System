using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPPS.Classes
{
    internal class EquipmentCost
    {
        private string e_cost;
        private string e_duration;

        public string E_Duration
        {
            get { return e_duration; }
            set { e_duration = value; }

        }

        public void EquipmentCost(string e_cost, string e_duration)
        {
            return (e_cost * e_duration);
        }
    }
}
