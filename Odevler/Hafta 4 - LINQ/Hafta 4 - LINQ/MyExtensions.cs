using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_4___LINQ
{
    public static class MyExtensions
    {
        public static string TerstenYaz(this string Kelime)
        {
            var k = string.Empty;
            for (int i = Kelime.Length - 1; i >= 0; i--)
            {
                k += Kelime[i];
            }
            return k;
        }
    }
}
