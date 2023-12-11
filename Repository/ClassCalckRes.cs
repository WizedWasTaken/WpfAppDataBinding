using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassCalckRes : ClassNotify
    {
        private string _strCalckNumber;
        private string _strCalckRes;
        private ClassTextRes _textRes;

        public ClassCalckRes()
        {
            textRes = new ClassTextRes();
            strCalckRes = "0";
            strCalckNumber = "0";
        }

        public string strCalckRes
        {
            get { return _strCalckRes;  }
            private set
            {
                if (_strCalckRes != value)
                {
                    _strCalckRes = value;
                }

                Notify("strCalckRes");
            }
        }

        public string strCalckNumber
        {
            get { return _strCalckNumber; }
            set
            {
                if (_strCalckNumber != value)
                {
                    if (value.Trim() == "")
                    {
                        value = "0";
                    }

                    if (int.TryParse(value, out int x))
                    {
                        _strCalckNumber = value;
                        CalckNumber(x);
                    }
                }

                Notify("strCalckNumber");
            }

        }

        public ClassTextRes textRes
        {
            get { return _textRes; }
            set
            {
                if (_textRes != value)
                {
                    _textRes = value;
                }

                Notify("textRes");
            }
        }

        private void CalckNumber(int inNumber)
        {
            int number = 0;
            if (inNumber != null)
            {
                number = Convert.ToInt32(inNumber) * 1387;
            }
            textRes.IsNumberEven(number);
            strCalckRes = number.ToString();
        }
    }
}
