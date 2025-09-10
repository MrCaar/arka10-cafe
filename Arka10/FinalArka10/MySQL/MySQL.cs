using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FinalArka10.MySQL
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Server=" + PublicKodlar.mySQLServer + ";Database=" + PublicKodlar.mySQLDatabase + ";User=" + PublicKodlar.mySQLUsername + ";Password=" + PublicKodlar.mySQLPassword + ";";

        public static DataTable MySQL_Read(string query, params object[] parameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            command.Parameters.AddWithValue($"@parametre{i + 1}", parameters[i]);
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

            return dataTable;
        }

        public static DataTable GetPersons()
        {
            DataTable data = MySQL.DatabaseHelper.MySQL_Read("SELECT * FROM personeller");
            return data;
        }

        public static string GetMasaDurum(string masaid)
        {
            // SQL sorgusuyla masanın durumunu alıyoruz
            DataTable data = MySQL.DatabaseHelper.MySQL_Read("SELECT masadurum FROM masalar WHERE masaid = @parametre1", masaid);

            // Eğer sonuç varsa durum bilgisini döndürüyoruz
            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["masadurum"].ToString();
            }

            // Eğer sonuç yoksa bir mesaj döndürüyoruz
            return "Masa bulunamadı.";
        }



        public static DataRow GetProduct(string urunId)
        {
            DataTable data = MySQL.DatabaseHelper.MySQL_Read("SELECT * FROM urunler WHERE urunId = @parametre1", urunId);
            
            return data.Rows[0];
        }


        public static DataTable GetProducts(string kategori)
        {
            DataTable data;

            if (kategori == "")
            {
                data = MySQL.DatabaseHelper.MySQL_Read("SELECT * FROM urunler", "");
            } else
            {
                data = MySQL.DatabaseHelper.MySQL_Read("SELECT * FROM urunler WHERE kategori = @parametre1", kategori);
            }

            return data;
        }


        public static bool MySQL_Write(string query, params object[] parameters)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            command.Parameters.AddWithValue($"@parametre{i + 1}", parameters[i]);
                        }

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("hata" + ex.StackTrace);
                Console.WriteLine("Hata: " + ex.Message);
            }
            return false;
        }

        public static string InsertTable(string masaKategori, string masaOzet)
        {
            string yeniMasaId = null; // Yeni oluşturulacak masa ID'si
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Masalar arasında en yüksek ID'yi bul
                    string selectQuery = "SELECT MAX(CAST(SUBSTRING(masaid, 2) AS UNSIGNED)) FROM masalar WHERE masakategori = @parametre1";
                    using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@parametre1", masaKategori);

                        object result = selectCommand.ExecuteScalar(); // MAX(SUBSTRING(masaid, 2)) ile en yüksek ID'yi al
                        int yeniId = result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1; // Eğer sonuç boşsa, ilk ID '1' olacak

                        yeniMasaId = masaKategori.Substring(0, 1) + yeniId.ToString(); // Örnek: "S1", "S2", "S3" gibi
                    }

                    // Yeni masayı ekle
                    string insertQuery = "INSERT INTO masalar (masaid, masakategori, masaozet) VALUES (@parametre1, @parametre2, @parametre3)";
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@parametre1", yeniMasaId);
                        insertCommand.Parameters.AddWithValue("@parametre2", masaKategori);
                        insertCommand.Parameters.AddWithValue("@parametre3", masaOzet);

                        insertCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

            return yeniMasaId;
        }




        public static DataTable GetTables(string category)
        {
            string query = "SELECT * FROM masalar WHERE masakategori = @parametre1";
            return MySQL_Read(query, category);
        }

        public static bool IsDatabaseConnected()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        return true; // Bağlantı başarılı
                    }
                }
            }
            catch (Exception)
            {
                // Hata durumunda false döner
            }
            return false; // Bağlantı başarısız
        }

        public static bool DeleteTable(string masaId)
        {
            string query = "DELETE FROM masalar WHERE masaid = @parametre1";
            return MySQL_Write(query, masaId);
        }

    }
}
