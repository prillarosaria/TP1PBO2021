using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1PBO2021
{
    class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool status { get; set; }

        public User() { }
        public User(string username, string password, bool status)
        {
            this.username = username;
            this.password = password;
            this.status = status;
        }
    }

    class Barang
    {
        public string nama_barang { get; set; }
        public string jenis_barang { get; set; }
        public string harga { get; set; }

        public Barang() { }
        public Barang(string nama_barang, string jenis_barang, string harga)
        {
            this.nama_barang = nama_barang;
            this.jenis_barang = jenis_barang;
            this.harga = harga;
        }
    }

    //Barang barang = new Barang("Outer Trendy", "Pakaian", 130000);

}
