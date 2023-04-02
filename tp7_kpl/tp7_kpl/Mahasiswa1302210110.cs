using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tp7_kpl
{
    public class Mahasiswa1302210110
    {
     
            public Nama nama { get; set; }
            public int nim { get; set; }
            public String fakultas { get; set; }
             
        public Mahasiswa1302210110(Nama nama, int nim, String fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
        }
        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("\"C:\\Users\\Reyhan\\source\\repos\\tpmodul7_kelompok_2\\tp7_1_1302210110.json\"");

            Mahasiswa1302210110 mahasiswa = JsonSerializer.Deserialize<Mahasiswa1302210110>(jsonString);

            Console.WriteLine("Nama " + mahasiswa.nama.depan + " " + mahasiswa.nama.belakang + " dengan nim " + mahasiswa.nim + " dari fakultas " + mahasiswa.fakultas);
        }
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


