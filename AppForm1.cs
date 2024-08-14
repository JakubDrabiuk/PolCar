using Newtonsoft.Json;
using PolCar_WinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PolCar_WinForms
{
    public partial class AppForm1 : Form
    {
        Dictionary<int, string> priorytetyDic;
        Dictionary<int, string> StatusyZadanDic;
        Dictionary<int, string> Dic;
        List<Pracownik> pracownicy;
        Pracownik WybranyPracownik;
        List<PracownikRola> pracownikRola_List;
        public AppForm1()
         {
            InitializeComponent();
            System.Net.ServicePointManager.SecurityProtocol =
            SecurityProtocolType.Tls12 |
            SecurityProtocolType.Tls11 |
            SecurityProtocolType.Tls;
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            InitData();
            FillCombobox();
           
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void InitData()
        {            
            string PracownicyJson =   ApiHelper.GetPracownicy();
            pracownicy =  JsonConvert.DeserializeObject<List<Pracownik>>(PracownicyJson);

            pracownikRola_List = JsonConvert.DeserializeObject<List<PracownikRola>>(ApiHelper.GetPracownikRola());


            priorytetyDic = new Dictionary<int, string>();
            

            foreach (Priorytet item in JsonConvert.DeserializeObject<List<Priorytet>>(ApiHelper.GetPriorytety()))
            {
                priorytetyDic.Add(item.PriId, item.PriNazwa);
            }



            StatusyZadanDic = new Dictionary<int, string>
            {
                { 0, "" }
            };

            foreach (ZadaniaStatus item in JsonConvert.DeserializeObject<List<ZadaniaStatus>>(ApiHelper.GetZadaniaStatus()))
            {
                StatusyZadanDic.Add(item.ZadStId, item.ZadStNazwa);
            }


        }
        private void FillCombobox()
        {
            if (pracownicy == null) return;
            Dictionary<int, string> Dictionary = new Dictionary<int, string>();
            Dictionary.Add(0, "");
            foreach (var pracownik in pracownicy)
            {
                Dictionary.Add(pracownik.PraId, pracownik.PraNazwa);
            }
            Pracownik_comboBox.DataSource = new BindingSource(Dictionary, null);
            Pracownik_comboBox.DisplayMember = "Value";
            Pracownik_comboBox.ValueMember = "Key";

        }

        private void Pracownik_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int,string> keyValuePair = (KeyValuePair<int, string>)this.Pracownik_comboBox.SelectedItem;

            if(keyValuePair.Key != 0)
            {
                SetUpUser(keyValuePair.Key);
                this.panel2.Enabled = true;
                this.dataGridView1.Enabled = true;
                
            }
             else
            {
                this.RolaOpisValue_label.Visible = false;
                this.RolaValue_label.Visible = false;
                this.panel2.Enabled = false;
                this.dataGridView1.Enabled = false;
            }
        }

        private void SetUpUser(int userID)
        {
            WybranyPracownik = pracownicy.Where(p => p.PraId == userID).Single();
            PracownikRola rola = new PracownikRola();
            rola = pracownikRola_List.Where(r => r.PraRid == WybranyPracownik.PraPraRid).Single();

            this.RolaValue_label.Text = rola.PraRNazwa;
            this.RolaOpisValue_label.Text = rola.PraROpis;
            this.RolaOpisValue_label.Visible = true;
            this.RolaValue_label.Visible = true;

        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            //Pracownik pracownik = pracownicy.Where(p => p.PraId == 4).Single();
            //this.Pracownik_comboBox.SelectedValue = pracownik.PraId;

            if(WybranyPracownik == null) { return; }

            ZadanieDictionary zadanieDictionaryForm = new ZadanieDictionary(WybranyPracownik,priorytetyDic,StatusyZadanDic);
            zadanieDictionaryForm.ShowDialog();



        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.Pracownik_comboBox.SelectedValue.ToString();
        }
    }
}
