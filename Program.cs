using System;
using System.Collections.Generic; // ket class list
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programproduk
{
    class Program // bentuk class program
    {
        static void Main(string[] args) //
        {
            int pil; //inisialisasi int pilihan
            List<barang> list = new List<barang>(); //merupakan object based collection yang terdapat dalam namespace system collection genric
            Console.Title = "Penjualan Produk";
            do //menggunakan perulangan do while, do yaitu melakukan perulangan ,while akan berhenti apabila kondisinya terpenuhi
            {
                Console.WriteLine("Pilihan menu yang tersedia :");
                Console.WriteLine("1. Tambah produk");
                Console.WriteLine("2. Hapus produk");
                Console.WriteLine("3. Tampilkan produk");
                Console.WriteLine("4. Keluar");
                Console.Write("\nNomor menu : ");
                pil = Convert.ToInt32(Console.ReadLine());

                switch (pil)
                {
                    case 1:
                        Tambah(list);
                        break;
                    case 2:
                        Hapus(list);
                        break;
                    case 3:
                        Tampil(list);
                        break;
                    default:
                        Console.WriteLine("Maaf, kode produk tidak ditemukan!\n");
                        break;
                }
            } while (pil != 4);
        }

        static void Tambah(List<barang> list)
        {
            Console.WriteLine("Masukkan data !");
            Console.Write("KODE           : ");
            string kode = Console.ReadLine().ToString();
            Console.Write("NAMA           : ");
            string nama = Console.ReadLine().ToString();
            Console.Write("BELI           : ");
            string beli = Console.ReadLine().ToString();
            Console.Write("JUAL           : ");
            string jual = Console.ReadLine().ToString();

            list.Add(new barang { Kode = kode, Nama = nama, Beli = beli, Jual= jual });
            Console.WriteLine();
        }


        static void Hapus(List<barang> list)
        {
            Console.WriteLine("Hapus data produk ");
            Console.Write("Masukkan kode : ");
            String kode = Console.ReadLine().ToString();

            list.Remove(list.SingleOrDefault(f => f.Kode == kode));
            Console.WriteLine("Kode Produk Tidak ditemukan \n\n");
           
        }

        static void Cari(List<barang> list)
        {
            Console.WriteLine("KODE Produk    : ");
            string kode = Console.ReadLine().ToString();
            Console.WriteLine("NAMA Produk   : ");
            string nama = Console.ReadLine().ToString();
            Console.WriteLine("HARGA Beli   : ");
            string beli = Console.ReadLine().ToString();
            Console.WriteLine("HARGA Jual   : ");
            string jual = Console.ReadLine().ToString();

            list.Add(new barang { Kode = kode, Nama = nama, Beli = beli, Jual = jual });
            Console.WriteLine();
        }

        static void Tampil(List<barang> list)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Data Produk");
            Console.WriteLine("----------------------------");
            foreach (barang br in list)
            {
                Console.Write("{0}, {1}, {2}, {3}", br.Kode, br.Nama, br.Beli, br.Jual);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
