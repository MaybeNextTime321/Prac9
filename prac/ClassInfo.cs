using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac
{
    class ClassInfo
    {
        // n - количество складов
        int n = 5;
        public static int[,] info = new int[50, 50];
        public static bool pr1 = false; public static bool pr2 = false; 
      
        public static void Add(int id, int ovosh1, int ovosh2, int[,] array)
        {
            if (ovosh1 != 0) array[id, 0] += ovosh1;
            if (ovosh2 != 0) array[id, 1] += ovosh2;
        }
        
    }
}
