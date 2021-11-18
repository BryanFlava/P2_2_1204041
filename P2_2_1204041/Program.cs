using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204041
{
    class Program
    {
        static void Main(string[] args)

            {
                HargeKue kue = new HargeKue();

            kue.namaKue = "Bolu Lumer";
            kue.rasaKue = "Rasa Red Valvet";
            kue.hargaKue = 100000;

            kue.TampilkanNamaKue();
            Console.WriteLine("Rasa Kue : " + kue.rasaKue);
            kue.DapatkanJumlahHargaKue();
            }
        }
    }