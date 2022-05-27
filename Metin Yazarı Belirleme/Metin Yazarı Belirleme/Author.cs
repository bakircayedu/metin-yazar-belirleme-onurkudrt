using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Yazarı_Belirleme
{
    public class Author
    {
        public string Name;
        public string Surname;
        public List<string> frequentlyWords;
        public List<txtFile> files = new List<txtFile>();
        public Author(string Name, string Surname, List<txtFile> files)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.files = files;
        }

        
    }
}
