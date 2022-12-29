using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace VeriTipleriVeMetodlarr
{
    public class ErisimBelirtecleriOgrenme
    {
        private string MyProperty { get { return _myproperty; } set { _myproperty = value; } }
        public int MyProperty2 { get; private set; }


        private string _myproperty = "gizli";
        
        public string GetProperty()
        {
            return _myproperty + " ama şimdi gizli";
        }
        
        public void SetProperty()
        {
            _myproperty = MyProperty;
        }
    }
   
    
}
