using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteka
{
    class Polaczenie
    {
        private static string pol = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\BIBLIOTEKA\\BIBLIOTEKA\\BIBLIOTEKA\\BIN\\DEBUG\\BAZA.MDF;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection conn= new SqlConnection(pol);

        public void dodajksiazke(string imie,string nazwisko,string ksiazka,string Pesel)
        {
            conn.Open();
            string query = $"INSERT INTO Wypozyczone";

            conn.Close();
        }
    }
}
