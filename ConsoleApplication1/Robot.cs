using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Robot
    {
        public string Name()
        {
            //Utilizo la funcionalidad de generar un nombre de archivo aleatorio
            string prefix = System.IO.Path.GetRandomFileName().Replace(".", "").Substring(0, 3);

            Random value = new Random();

            int suffix = value.Next(0000, 9999);

            return prefix + suffix.ToString();
        }
    }
}
