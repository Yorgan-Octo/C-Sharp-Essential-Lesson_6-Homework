using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class FindAndReplaceManager
    {

        public static bool FindNext(string str, List<string> book)
        {

            foreach (var item in book)
            {
                if (item == str)
                {
                   return true;

                }
            }
            return false;
        }

    }
}
