using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Cola
    {
        private int [] vec;
        public Cola()
        {
            vec = new int [1000];
        }
        public void llenar()
        {
            for(int i = 1; i < 1000; i++)
            {
                vec[i] = 1;
            }
        }
        public void Compara()
        {
            for(int i =2; i < 1000; i++)
            {
                if (vec[i] == 1)
                {
                    for(int h = i+1; h < 1000; h++)
                    {
                        if (h % i == 0)
                        {
                            vec[h] = 0;
                        }
                    }
                }
            }
        }
        public string ver()
        {
            string resultado = "";
            for(int i = 2; i < vec.Length - 1; i++)
            {
                if(vec[i] == 1)
                {
                    resultado += i + " Primo " + Environment.NewLine;
                }
            }
            return resultado;
        }
    }
}
