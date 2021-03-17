using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    interface IOrderRepair
    {
        void ProcessOrder(string modelName);
        
    }
    interface IOrderRepair1
    {
        void ProcessPhoneRepair(string modelName);
        void ProcessAccessoryRepair(string accessoryType);
    }
    
}
