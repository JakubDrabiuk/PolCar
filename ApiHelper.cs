using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolCar_WinForms
{
    internal class ApiHelper
    {
       static string baseUrl = "https://localhost:44336";
        public ApiHelper() { }
       static RestClient client;
        public string GetZadania(int id = 0)
        {
            try
            {
                client = new RestClient(baseUrl);
                var request = new RestRequest($"api/Zadania/{id}",Method.Get);
                var response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    return response.Content;
                }
                else return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void AddZadania(Zadania zadanie)
        {
            try
            {
                client = new RestClient(baseUrl);
                var request = new RestRequest($"api/Zadania", Method.Post);
                request.AddBody(zadanie);

                var response = client.Execute(request);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public static string GetPracownicy()
        {
            try
            {
                client = new RestClient(baseUrl + "/api/Pracownik");
                var request = new RestRequest();

                var response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    return response.Content;
                }
                else return null;


                /* var options = new RestClientOptions()
                 {
                     //BaseHost = "localhost",

                     MaxTimeout = -1,
                 };
                 var client = new RestClient(options);

                 var request = new RestRequest("https://localhost:44336/api/Pracownik", Method.Get);
                 RestResponse response =  client.Execute(request);
                 if(response.IsSuccessful) { return response.Content; }*/


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static string GetPriorytety()
        {
            try
            {
                client = new RestClient(baseUrl+ "/api/Priorytet");
                var request = new RestRequest();

                var response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    return response.Content;
                }
                else return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public static string GetZadaniaStatus()
        {
            try
            {
                client = new RestClient(baseUrl+ "/api/ZadaniaStatus");
                var request = new RestRequest();

                var response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    return response.Content;
                }
                else return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static void AddZadanie(Zadania zadanIE)
        {
            try
            {
                client = new RestClient(baseUrl + "/api/Zadania");
                var request = new RestRequest();
                request.Method = Method.Post;
                request.AddBody(zadanIE);
                var response = client.Execute(request);
                if (!response.IsSuccessful)
                {
                    throw new Exception($"Błąd dodawania zadania. Dodatkowe info z serwera : {response.Content}");
                }
                            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        public static string GetPracownikRola()
        {
            try
            {
                client = new RestClient(baseUrl+ "/api/PracownikRola");
                var request = new RestRequest();

                var response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    return response.Content;
                }
                else return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return null;
        }

    }
}
