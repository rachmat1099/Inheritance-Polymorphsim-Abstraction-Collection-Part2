using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphsimAbsColl
{
    public abstract class Karyawan
    {
        public string Nama { get; set; }
        public string NIK { get; set; }
        public abstract double Gaji();
    }
}