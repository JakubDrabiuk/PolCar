using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolCar_WinForms
{
    public partial class ZadanieDictionary : Form
    {
        Pracownik Pracownik { get; set; }
        public ZadanieDictionary(Pracownik pracownik,Dictionary<int,string> priorytety,Dictionary<int,string> statusyZadan,int zadanieID = 0)
        {

            InitializeComponent();
            this.FillComboboxes(priorytety, statusyZadan);
            this.User_Name_txtBox.Text = pracownik.PraNazwa;
            if(pracownik.PraPraRid ==1) this.User_Name_txtBox.Enabled = false;
            Pracownik = pracownik;
        }


        private void FillComboboxes(Dictionary<int, string> priorytety, Dictionary<int, string> statusyZadan)
        {
            
            Priorytet_comboBox.DataSource = new BindingSource(priorytety, null);
            Priorytet_comboBox.DisplayMember = "Value";
            Priorytet_comboBox.ValueMember = "Key";

            
            Status_comboBox.DataSource = new BindingSource(statusyZadan, null);
            Status_comboBox.DisplayMember = "Value";
            Status_comboBox.ValueMember = "Key";
        }



        private void SetupControlls()
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.naglowek_txtBox.Text))
            {
                MessageBox.Show("Należyp podać nagłówek");
                return;
            }
            Zadania zadanie = new Zadania();
            zadanie.ZadPracownik = Pracownik.PraId;
            zadanie.ZadPriorytet = int.Parse(Priorytet_comboBox.SelectedValue.ToString());
            zadanie.ZadOpis = this.Opis_richTextBox.Text;
            zadanie.ZadStatus = int.Parse(Status_comboBox.SelectedValue.ToString());
            zadanie.ZadNaglowek = this.naglowek_txtBox.Text;
            zadanie.Zad_Data = this.Data_dateTimePicker.Value;

            ApiHelper.AddZadanie(zadanie);
            this.Close();
           



        }
    }
}
