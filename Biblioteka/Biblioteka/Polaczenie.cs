using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace Biblioteka
{
    class Polaczenie
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\bazadanych.mdf" + ";Integrated Security=True;");

        public string log(string nazwa, string haslo)
        {
            conn.Open();
            string pyt = $"SELECT Rola FROM Uzytkownicy WHERE Nazwa='{nazwa}' AND Haslo='{haslo}'";

            var cmd = new SqlCommand(pyt, conn);

            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            string rola = "";
            if (reader.Read())
            {
                rola = reader["Rola"].ToString();

            }
            conn.Close();
            return rola;

        }

        public bool rejestracja(string imie, string nazwisko, string nazwa, string haslo, string pesel, string rola)
        {
            conn.Open();
            string pyt = $"INSERT INTO Uzytkownicy (Imie,Nazwisko,Nazwa,Haslo,Pesel,Rola) VALUES ('{imie}','{nazwisko}','{nazwa}','{haslo}','{pesel}','{rola}')";

            var cmd = new SqlCommand(pyt, conn);

            int i = cmd.ExecuteNonQuery();

            conn.Close();
            if (i < 0)
            {
                return false;
            }
            return true;


        }

        public List<Ksiazki> wczytajKsiazkiU(string pesel)
        {
            List<Ksiazki> ksiazki = new List<Ksiazki>();

            conn.Open();
            string pyt = $"SELECT Ksiazka,OdKiedy,DoKiedy FROM Wypozyczenia WHERE Pesel='{pesel}'";

            var cmd = new SqlCommand(pyt, conn);

            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ksiazki.Add(new Ksiazki(reader["Ksiazka"].ToString(), reader["OdKiedy"].ToString(), reader["DoKiedy"].ToString()));

            }
            conn.Close();

            return ksiazki;
        }
        public string GetPesel(string nazwa,string haslo)
        {

            conn.Open();
            string pyt = $"SELECT Pesel FROM Uzytkownicy WHERE Nazwa='{nazwa}' AND Haslo='{haslo}'";

            var cmd = new SqlCommand(pyt, conn);

            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            string pesel = "";
            if (reader.Read())
            {
                pesel = reader["Pesel"].ToString();

            }
            conn.Close();

            return pesel;
        }


        public List<DoOddania> wczytajKsiazkiB() {
            List<DoOddania> ksiazki = new List<DoOddania>();

            conn.Open();
            string pyt = $"SELECT Imie,Nazwisko,Ksiazka,OdKiedy,DoKiedy,Pesel FROM Wypozyczenia";

            var cmd = new SqlCommand(pyt, conn);

            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ksiazki.Add(new DoOddania(reader["Imie"].ToString(),reader["Nazwisko"].ToString(),reader["Ksiazka"].ToString(), reader["OdKiedy"].ToString(), reader["DoKiedy"].ToString(),reader["Pesel"].ToString()));

            }
            conn.Close();

            return ksiazki;
        }

        public bool DodajWypozyczenie(string imie,string nazwisko,string ksiazka,string pesel)
        {

            DateTime odkiedy = DateTime.Today.Date;
            DateTime dokiedy = odkiedy.AddMonths(1);
            conn.Open();
            string pyt = $"INSERT INTO Wypozyczenia (Imie,Nazwisko,Ksiazka,OdKiedy,DoKiedy,Pesel) VALUES ('{imie}','{nazwisko}','{ksiazka}','{odkiedy.ToString("yyyy-mm-dd")}','{dokiedy.ToString("yyyy-mm-dd")}','{pesel}')";

            var cmd = new SqlCommand(pyt, conn);

            int i = cmd.ExecuteNonQuery();

            conn.Close();
            if (i < 0)
            {
                return false;
            }
            return true;
        }

        public List<DoOddania> SzukajKsiazkiB(string imie,string nazwisko,string pesel)
        {
            List<DoOddania> ksiazki = new List<DoOddania>();

            conn.Open();
            string pyt = $"SELECT Imie,Nazwisko,Ksiazka,OdKiedy,DoKiedy,Pesel FROM Wypozyczenia WHERE Imie='{imie}' AND Nazwisko='{nazwisko}' AND Pesel='{pesel}'";

            var cmd = new SqlCommand(pyt, conn);

            SqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ksiazki.Add(new DoOddania(reader["Imie"].ToString(), reader["Nazwisko"].ToString(), reader["Ksiazka"].ToString(), reader["OdKiedy"].ToString(), reader["DoKiedy"].ToString(), reader["Pesel"].ToString()));

            }
            conn.Close();

            return ksiazki;
        }



    }
}
