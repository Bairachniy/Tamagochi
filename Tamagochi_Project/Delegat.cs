using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi_Project
{
    public delegate void TamagochDelegat();



    class SMSEventArgs : EventArgs
    {
        public string SMS { get; set; }
    }
}
