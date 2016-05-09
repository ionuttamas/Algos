using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos {
    class Program {
        static void Main(string[] args) {
        }

        public float[] Sort(float[] list) {
            for (int i = 0; i < list.Length-1; i++)
            {
                for (int j = i+1; j < list.Length; j++) {
                    if (list[i] > list[i + 1])
                    {
                        float temp = list[i];
                        list[i] = list[i + 1];
                        list[i+1] = temp;
                    }
                }
            } 

            return list;
        }
    }
}
