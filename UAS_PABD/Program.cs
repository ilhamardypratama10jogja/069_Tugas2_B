using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UAS_PABD
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();

        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ILHAMARDY2001;database=Exercise2PABD;Integrated Security " +
                    "= TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Supplier (Kode_supplier,Nama_supplier,Alamat_supplier )values('01','ilham','jogja')"
                    + "insert into Supplier (Kode_supplier,Nama_supplier,Alamat_supplier) values('02','ardy','sleman')"
                    + "insert into Supplier (Kode_supplier,Nama_supplier,Alamat_supplier) values('03','tama','minggir')"
                    + "insert into Supplier (Kode_supplier,Nama_supplier,Alamat_supplier) values('04','bela','jakarta')"
                    + "insert into Supplier (Kode_supplier,Nama_supplier,Alamat_supplier) values('05','putri','bandung')"

                    + "insert into Apotek (Kode_apotek ,Nama_apotek,Alamat ,telp) values('10','kimia','a','021')"
                    + "insert into Apotek (Kode_apotek ,Nama_apotek,Alamat ,telp) values('11','farma','b','022')"
                    + "insert into Apotek (Kode_apotek ,Nama_apotek,Alamat ,telp) values('12','inta','c','023')"
                    + "insert into Apotek (Kode_apotek ,Nama_apotek,Alamat ,telp) values('13','bagus','d','024')"
                    + "insert into Apotek (Kode_apotek ,Nama_apotek,Alamat ,telp) values('14','jarum','e','025')"

                    + "insert into Obat (Kode_obat ,Nama_obat ,Harga) values('100','antagin','2000')"
                    + "insert into Obat (Kode_obat ,Nama_obat ,Harga) values('101','oskadon','3000')"
                    + "insert into Obat (Kode_obat ,Nama_obat ,Harga) values('102','koyok','4000')"
                    + "insert into Obat (Kode_obat ,Nama_obat ,Harga) values('103','vitc','5000')"
                    + "insert into Obat (Kode_obat ,Nama_obat ,Harga) values('104','paracetamol','6000')"

                    + "insert into Transaksi_masuk (Nota_masuk ,Tgl_masuk ,Kode_supplier) values('40','25-12-2022','01')"
                    + "insert into Transaksi_masuk (Nota_masuk ,Tgl_masuk ,Kode_supplier) values('41','6-12-2022','02')"
                    + "insert into Transaksi_masuk (Nota_masuk ,Tgl_masuk ,Kode_supplier) values('42','7-12-2022','03')"
                    + "insert into Transaksi_masuk (Nota_masuk ,Tgl_masuk ,Kode_supplier) values('43','19-12-2022','04')"
                    + "insert into Transaksi_masuk (Nota_masuk ,Tgl_masuk ,Kode_supplier) values('44','5-12-2022','05')"

                    + "insert into Detail_masuk (Tgl_masuk ,Jml_obat ,Kode_batch ,Nota_masuk ,Kode_obat) values('25-12-2022','1000','333','40','100')"
                    + "insert into Detail_masuk (Tgl_masuk ,Jml_obat ,Kode_batch ,Nota_masuk ,Kode_obat) values('6-12-2022','1050','332','41','101')"
                    + "insert into Detail_masuk (Tgl_masuk ,Jml_obat ,Kode_batch ,Nota_masuk ,Kode_obat) values('7-12-2022','1500','331','42','102')"
                    + "insert into Detail_masuk (Tgl_masuk ,Jml_obat ,Kode_batch ,Nota_masuk ,Kode_obat) values(,'1005','329','43','103')"
                    + "insert into Detail_masuk (Tgl_masuk ,Jml_obat ,Kode_batch ,Nota_masuk ,Kode_obat) values('02-07-2022','10505','328','44','104')"


                    + "insert into Transaksi_keluar (Nota_keluar ,Tgl_keluar,Kode_apotek ) values('50','5-08-2022','10')"
                    + "insert into Transaksi_keluar (Nota_keluar ,Tgl_keluar,Kode_apotek ) values('51','5-07-2022','11')"
                    + "insert into Transaksi_keluar (Nota_keluar ,Tgl_keluar,Kode_apotek ) values('52','5-06-2022','12')"
                    + "insert into Transaksi_keluar (Nota_keluar ,Tgl_keluar,Kode_apotek ) values('53','5-02-2022','13')"
                    + "insert into Transaksi_keluar (Nota_keluar ,Tgl_keluar,Kode_apotek ) values('54','5-01-2022','14')"

                    + "insert into Detail_keluar (Jml_keluar ,Nota_keluar ,Kode_obat ) values('60','50','100')"
                    + "insert into Detail_keluar (Jml_keluar ,Nota_keluar ,Kode_obat ) values('61','51','101')"
                    + "insert into Detail_keluar (Jml_keluar ,Nota_keluar ,Kode_obat ) values('62','52','102')"
                    + "insert into Detail_keluar (Jml_keluar ,Nota_keluar ,Kode_obat ) values('63','53','103')"
                    + "insert into Detail_keluar (Jml_keluar ,Nota_keluar ,Kode_obat ) values('64','54','104')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }

        }

    }
}

