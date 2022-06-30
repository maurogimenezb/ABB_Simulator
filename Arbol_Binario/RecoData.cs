using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Binario
{
    class RecoData
    {
        static string Inorden;
        static string Preorden;
        static string Posorden;

        public static string inorden
        {
            get
            {
                return Inorden;
            }

            set
            {
                Inorden = value;
            }
        }

        public static string preorden
        {
            get
            {
                return Preorden;
            }

            set
            {
                Preorden = value;
            }
        }

        public static string posorden
        {
            get
            {
                return Posorden;
            }

            set
            {
                Posorden = value;
            }
        }
    }
}
