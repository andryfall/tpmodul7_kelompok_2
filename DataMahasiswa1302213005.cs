using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_2
{
    public class DataMahasiswa1302213005
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public String fakultas { get; set; }


        public DataMahasiswa1302213005(Nama nama ,int nim, String fakultas) { 
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("C:\\Users\\andry\\Documents\\GitHub\\tpmodul7_kelompok_2\\tpmodul7_kelompok_2\\tp7_1_1302213005.json");

            DataMahasiswa1302213005 mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302213005>(jsonString);

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
