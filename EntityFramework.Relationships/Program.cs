using System.Diagnostics.Metrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Relationships.Data;

namespace Bob
{

    class Program
    {
        static void Main(string[] args)
        {
            AirplanesDbContext adb = new();

            adb.SaveChanges();

        }
    }
}