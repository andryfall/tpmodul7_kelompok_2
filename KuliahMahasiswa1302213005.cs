using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_2
{
    internal class KuliahMahasiswa1302213005
    {
        public List<courses> courses { get; set; }

        public KuliahMahasiswa1302213005(List<courses> courses) { 
            this.courses = courses;
        }

        public static void ReadJSON()
        {
            String jsonString = File.ReadAllText("C:\\Users\\andry\\Documents\\GitHub\\tpmodul7_kelompok_2\\tpmodul7_kelompok_2\\tp7_2_1302213005.json");

            KuliahMahasiswa1302213005 matkul = JsonSerializer.Deserialize<KuliahMahasiswa1302213005>(jsonString);

            for(int i = 0; i < matkul.courses.Count; i++)
            {
                Console.WriteLine("MK "+(i+1)+" "+matkul.courses[i].code+" - "+matkul.courses[i].name);
            }
            
        }


    }
    public class courses
    {
        public String code { get; set; }
        public String name { get; set; }

        public courses(String code, String name)
        {
            this.code = code;
            this.name = name;
        }
    }
}
