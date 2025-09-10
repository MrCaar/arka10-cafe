using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalArka10.Formlar
{
    public partial class Rezerve : Form
    {
        public Rezerve()
        {
            InitializeComponent();
        }
        private void RezerveTable(DateTimePicker dateTimePicker)
        {
            string masaId = PublicKodlar.selectedTable;
            DateTime selectedDate = dateTimePicker.Value;

            DateTime rezerveStart = selectedDate.AddMinutes(-30);
            DateTime rezerveEnd = selectedDate.AddMinutes(15);

            long unixStartTime = ((DateTimeOffset)rezerveStart).ToUnixTimeSeconds();
            long unixEndTime = ((DateTimeOffset)rezerveEnd).ToUnixTimeSeconds();

            MySQL.DatabaseHelper.MySQL_Write(
                "UPDATE masalar SET rezerve_time = @parametre1, rezerve_end_time = @parametre2 WHERE masaid = @parametre3",
                unixStartTime,
                unixEndTime,
                masaId
            );

            MessageBox.Show($"Masa {masaId} için rezervasyon kaydedildi: {selectedDate:dd | HH:mm}\nBaşlangıç: {rezerveStart:dd | HH:mm}\nBitiş: {rezerveEnd:dd | HH:mm}", "Rezervasyon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void rezerveBtn_Click(object sender, EventArgs e)
        {
            RezerveTable(dateTimePicker1);
        }
    }
}
