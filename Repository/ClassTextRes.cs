using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassTextRes : ClassNotify
    {

        public ClassTextRes()
        {
            strTextRes = "Indtast et heltal - Og du får et resultat !";
        }

        private string _strTextRes;

        public string strTextRes
        {
            get { return _strTextRes;  }
            private set
            {
                if (_strTextRes != value)
                {
                    _strTextRes = value;
                }

                Notify("strTextRes");
            }
        }

        public void IsNumberEven(int intNumber)
        {
            if (intNumber % 2 == 0)
            {
                strTextRes = String.Format($"Tallet {intNumber} er et LIGE tal.");
            }
            else
            {
                strTextRes = String.Format($"Tallet {intNumber} er et ULIGE tal.");
            }
        }
    }
}
