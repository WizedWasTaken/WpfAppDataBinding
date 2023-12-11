using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace BIZ
{
    public class ClassBIZ : ClassNotify
    {

        public ClassBIZ()
        {
            calckRes = new ClassCalckRes();
        }

        private ClassCalckRes _calckRes;

        public ClassCalckRes calckRes
        {
            get { return _calckRes;  }
            set
            {
                if (_calckRes != value)
                {
                    _calckRes = value;
                }

                Notify("calckRes");
            }
        }
    }
}
