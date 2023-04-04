using tpmodul7_kelompok_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;

public class Program


    public static void Main()
{
DataMahasiswa1302210065.ReadJSON();

KuliahMahasiswa1302210065.ReadJSON();
}
}

  PublicKey class nama
{
    string "nama"
    string "fakultas"
    "nama": {
        "depan": "Satrio Agul",
        "belakang": "Arumbino"
    },
    "nim": 1302210065,
    "fakultas": "informatika"
}


namespace TP_MOD7_1302210065
{
    internal class DataMahasiswa1302210065
    {
        public Nama nama { get; set; }
        public int nim { get; set; }
        public String fakultas { get; set; }


        public DataMahasiswa1302210065(Nama nama, int nim, String fakultas)
        {
            this.nama = nama;
            this.nim = nim;
            this.fakultas = fakultas;
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








    // See https://aka.ms/new-console-template for more information
    Console.WriteLine("Hello, World!");
