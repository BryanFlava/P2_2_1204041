using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204041
{
    class HargeKue
    {
        public string namaKue;
        public string rasaKue;
        public int hargaPCS;
        public int hargaKue;

        // method yang tidak mengembalikan nilai
        public void TampilkanNamaKue()
        {
            Console.WriteLine("Nama Kue : " + this.namaKue);
        }

        public void TampilkanJenisRasa()
        {
            Console.WriteLine("Rasa Kue : " + this.rasaKue);
        }

        // method yang mengembalikan nilai
        public void DapatkanJumlahHargaKue()
        {
            Console.WriteLine("Harga Kue :" + this.hargaKue);
        }
    }
}
