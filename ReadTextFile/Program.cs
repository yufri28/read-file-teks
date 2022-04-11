using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //tambahkan library using System.IO untuk bisa menggunakan Class File
using System.Collections;

namespace ReadTextFile
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //untuk dokumentasi selengkapnya dapat dilihat di sini https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
            //bisa menggunakan ReadAllText (Baca semua text) atau ReadAllLines (baca semua baris)
            string filePath = @"C:\Users\USER\Desktop\ReadFiles.txt"; //Path File atau jalur penyimpanan file.txt (pada cth, ReadFiles.txt/file .txtnya disimpan pada C:\Users\USER\Desktop\
            string lines = File.ReadAllText(filePath); //panggil method ReadAllText() atau method untuk membaca isi file dalam ReadFiles.txt dengan menyertakan parameter filePath dan disimpan dalam variabel lines. ReadAllText untuk membaca semua text yang ada di dalam file ReadFiles.txt
            string[] get = lines.Split(';'); //dari semua teks yang ada dalam file ReadFiles.txt, teks2 tersebut dipisahkan dengan tanda ; dan disimpan menjadi array 1 dimensi.

            //menampilkan teks 
            for (int i = 0; i < get.Length; i++)
            {
                Console.WriteLine(get[i]);
            }
        }
    }
   
    
}
