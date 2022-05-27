using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public class convert
    {
        public int convertObject(object data)
        {
            if(data.GetType().Name == "Int32")
                return (int)data;
          string temp = data.ToString();
            return convertString(temp);
        }

        public int convertString(string data)
        {
            int result = 0;
            data = data.ToLower();
            for (int i = 0; i < data.Length; i++)
                result += Convert.ToInt32(data[i]);
            return result;
        }
        public string stringLowerCase(string data)
        { 
            return data.ToLower();
        }
        public object objectLowerCase(object data)
        {
            return data.ToString().ToLower(); ;
        }
    }
}
