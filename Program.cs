using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphsimAbsColl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Karyawan> listKaryawan = new List<Karyawan>();
            int pilihan;
            do
            {
                Console.Title = "Tugas Lab 9 - Inheritance, Polymorphsim, Abstraction & Collection Part 2";

                Console.Clear();
                Console.WriteLine("Pilih Menu Aplikasi\n");
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Keluar\n");
                Console.Write("Pilih Menu Pilih Menu [1..4]: ");
                pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Tambah Data Karyawan\n");
                        Console.Write("Jenis Karyawan [1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : ");
                        int jenis = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (jenis == 1)
                        {
                            KaryawanTetap karyawanTetap = new KaryawanTetap();
                            Console.Write("NIK              : ");
                            karyawanTetap.NIK = Console.ReadLine();
                            Console.Write("Nama             : ");
                            karyawanTetap.Nama = Console.ReadLine();
                            Console.Write("Gaji Bulanan     : ");
                            karyawanTetap.GajiBulanan = Convert.ToInt32(Console.ReadLine());
                            listKaryawan.Add(karyawanTetap);
                        }
                        else if (jenis == 2)
                        {
                            KaryawanHarian karyawanHarian = new KaryawanHarian();
                            Console.Write("NIK              : ");
                            karyawanHarian.NIK = Console.ReadLine();
                            Console.Write("Nama             : ");
                            karyawanHarian.Nama = Console.ReadLine();
                            Console.Write("Jumlah Jam Kerja : ");
                            karyawanHarian.JumlahJamKerja = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Upah Per Jam     : ");
                            karyawanHarian.UpahPerJam = Convert.ToInt32(Console.ReadLine());
                            listKaryawan.Add(karyawanHarian);
                        }
                        else if (jenis == 3)
                        {
                            Sales sales = new Sales();
                            Console.Write("NIK              : ");
                            sales.NIK = Console.ReadLine();
                            Console.Write("Nama             : ");
                            sales.Nama = Console.ReadLine();
                            Console.Write("Jumlah Penjualan : ");
                            sales.JumlahPenjualan = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Komisi           : ");
                            sales.Komisi = Convert.ToInt32(Console.ReadLine());
                            listKaryawan.Add(sales);
                        }
                        Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
                        break;

                    case 2:
                        int hapus = -1, nomor = 1;
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            Console.WriteLine(" {0}. NIK: {1}", nomor, karyawan.NIK);
                            nomor++;
                            hapus += 1;
                        }

                        Console.Write("\nPilih NIK Yang Ingin Dihapus : ");
                        int hapusnik = int.Parse(Console.ReadLine());
                        hapusnik = hapusnik - 1;
                        listKaryawan.RemoveAt(hapus);
                        Console.WriteLine("\nData Karyawan Berhasil Dihapus");
                        Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
                        break;

                    case 3:
                        int urutan = 0;
                        string jeniskaryawan = " ";
                        Console.WriteLine("Data Karyawan\n");
                        foreach (Karyawan karyawan in listKaryawan)
                        {
                            if (karyawan is KaryawanTetap)
                            {
                                jeniskaryawan = "Karyawan Tetap";
                            }
                            else if (karyawan is KaryawanHarian)
                            {
                                jeniskaryawan = "Karyawan Harian";
                            }
                            else
                            {
                                jeniskaryawan = "Sales";
                            }
                            urutan++;
                            Console.WriteLine("{0}. NIK : {1}, Nama : {2}, Gaji : Rp {3}, {4}", urutan, karyawan.NIK, karyawan.Nama, karyawan.Gaji(), jeniskaryawan);
                        }
                        if (urutan < 1)
                        {
                            Console.WriteLine("Data Karyawan Kosong, Silahkan Masukan Data Terlebih Dahulu");
                        }
                        Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
                        break;

                    case 4:
                        break;
                }
                Console.ReadKey();
            }
            while (pilihan != 4);
        }
    }
}