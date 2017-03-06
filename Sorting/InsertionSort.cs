using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class InsertionSort 
    {
        public void ISort(int[] items)
        {
            for (int j = 1; j < items.Length; j++)
            {
                int key = items[j];
                int i = j - 1;
                while (i >= 0 && items[i] > key)
                {
                    items[i + 1] = items[i];
                    i = i - 1;
                }
                items[i + 1] = key;
            }
        }



    }
}
