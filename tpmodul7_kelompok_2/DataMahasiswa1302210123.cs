using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace tpmodul7_kelompok_2
{
    internal class DataMahasiswa1302210123
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public String fakultas { get; set; }


        public DataMahasiswa1302210123(Nama nama, int nim, String fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\TPMOD7\\tpmodul7_kelompok_2\\tp7_1_1302210123.json");

            DataMahasiswa1302210123 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302210123>(jsonString);

            Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
        }
    }

    public class Nama
    {
        public String depan { get; set; }
        public String belakang { get; set; }

        public Nama(String depan, String belakang)
        {
            this.depan = depan;
            this.belakang = belakang;
        }
    }
}

