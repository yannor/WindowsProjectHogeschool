using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Backend
    {
        public const String API_URL = "http://localhost:23938/api/";

        public static async Task<Campus> GetCampus(int id)
        {
            Campus campus = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage data = await client.GetAsync(string.Concat(API_URL, "Campussen/", id));
                    String json = await data.Content.ReadAsStringAsync();
                    if (json != null)
                        campus = JsonConvert.DeserializeObject<Campus>(json);

                    return campus;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<List<Campus>> GetCampussen()
        {
            List<Campus> campussen = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage data = await client.GetAsync(string.Concat(API_URL, "Campussen"));
                    String json = await data.Content.ReadAsStringAsync();
                    if (json != null)
                        campussen = JsonConvert.DeserializeObject<List<Campus>>(json);

                    return campussen;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<bool> PostCampus(Campus c)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var sampleClassObjectJson = JsonConvert.SerializeObject(c);
                    var content = new StringContent(sampleClassObjectJson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(string.Concat(API_URL + "Campussen"), content);
                    if (response.StatusCode == HttpStatusCode.OK)
                        return true;
                    else
                        throw new WebException("An error has occurred while calling PostCampus method: " + response.Content);
                }
            }

            catch (WebException exception)
            {
                throw new WebException("An error has occurred while calling PostCampus method: " + exception.Message);
            }
        }

        public static async Task<bool> PutCampus(Campus c)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(c);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(string.Concat(API_URL + "Campussen/" + c.CampusID), content);
                    if (response.IsSuccessStatusCode)
                        return true;
                    else 
                        throw new WebException("An error has occurred while calling PutCampus method: " + response.Content);
                }
            }
            catch (WebException exception)
            {
                throw new WebException("An error has occurred while calling PutCampus method: " + exception.Message);
            }
        }

        public static async Task<Richting> GetRichting(int id)
        {
            Richting campus = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage data = await client.GetAsync(string.Concat(API_URL, "Richtingen/", id));
                    String json = await data.Content.ReadAsStringAsync();
                    if (json != null)
                        campus = JsonConvert.DeserializeObject<Richting>(json);

                    return campus;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<List<Richting>> GetRichtingen()
        {
            List<Richting> campussen = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage data = await client.GetAsync(string.Concat(API_URL, "Richtingen"));
                    String json = await data.Content.ReadAsStringAsync();
                    if (json != null)
                        campussen = JsonConvert.DeserializeObject<List<Richting>>(json);

                    return campussen;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<bool> PostRichting(Richting c)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var sampleClassObjectJson = JsonConvert.SerializeObject(c);
                    var content = new StringContent(sampleClassObjectJson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(string.Concat(API_URL + "Richtingen"), content);
                    if (response.StatusCode == HttpStatusCode.OK)
                        return true;
                    else
                        throw new WebException("An error has occurred while calling PostCampus method: " + response.Content);
                }
            }

            catch (WebException exception)
            {
                throw new WebException("An error has occurred while calling PostCampus method: " + exception.Message);
            }
        }

        public static async Task<bool> PutRichting(Richting c)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(c);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(string.Concat(API_URL + "Richtingen/" + c.RichtingID), content);
                    if (response.IsSuccessStatusCode)
                        return true;
                    else
                        throw new WebException("An error has occurred while calling PutCampus method: " + response.Content);
                }
            }
            catch (WebException exception)
            {
                throw new WebException("An error has occurred while calling PutCampus method: " + exception.Message);
            }
        }

        public static async Task<Gebruiker> GetGebruiker(int id)
        {
            Gebruiker campus = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage data = await client.GetAsync(string.Concat(API_URL, "Gebruikers/", id));
                    String json = await data.Content.ReadAsStringAsync();
                    if (json != null)
                        campus = JsonConvert.DeserializeObject<Gebruiker>(json);

                    return campus;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<List<Gebruiker>> GetGebruikers()
        {
            List<Gebruiker> campussen = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage data = await client.GetAsync(string.Concat(API_URL, "Gebruikers"));
                    String json = await data.Content.ReadAsStringAsync();
                    if (json != null)
                        campussen = JsonConvert.DeserializeObject<List<Gebruiker>>(json);

                    return campussen;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<bool> PostGebruiker(Gebruiker c)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var sampleClassObjectJson = JsonConvert.SerializeObject(c);
                    var content = new StringContent(sampleClassObjectJson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(string.Concat(API_URL + "Gebruikers"), content);
                    if (response.StatusCode == HttpStatusCode.OK)
                        return true;
                    else
                        throw new WebException("An error has occurred while calling PostCampus method: " + response.Content);
                }
            }

            catch (WebException exception)
            {
                throw new WebException("An error has occurred while calling PostCampus method: " + exception.Message);
            }
        }

        public static async Task<bool> PutGebruiker(Gebruiker c)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(c);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(string.Concat(API_URL + "Gebruikers/" + c.GebruikerID), content);
                    if (response.IsSuccessStatusCode)
                        return true;
                    else
                        throw new WebException("An error has occurred while calling PutCampus method: " + response.Content);
                }
            }
            catch (WebException exception)
            {
                throw new WebException("An error has occurred while calling PutCampus method: " + exception.Message);
            }
        }

        public static async Task<Evenement> GetEvenement(int id)
        {
            Evenement campus = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage data = await client.GetAsync(string.Concat(API_URL, "Evenementen/", id));
                    String json = await data.Content.ReadAsStringAsync();
                    if (json != null)
                        campus = JsonConvert.DeserializeObject<Evenement>(json);

                    return campus;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<List<Evenement>> GetEvenementen()
        {
            List<Evenement> campussen = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage data = await client.GetAsync(string.Concat(API_URL, "Evenementen"));
                    String json = await data.Content.ReadAsStringAsync();
                    if (json != null)
                        campussen = JsonConvert.DeserializeObject<List<Evenement>>(json);

                    return campussen;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static async Task<bool> PostEvenement(Evenement c)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var sampleClassObjectJson = JsonConvert.SerializeObject(c);
                    var content = new StringContent(sampleClassObjectJson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(string.Concat(API_URL + "Evenementen"), content);
                    if (response.StatusCode == HttpStatusCode.OK)
                        return true;
                    else
                        throw new WebException("An error has occurred while calling PostCampus method: " + response.Content);
                }
            }

            catch (WebException exception)
            {
                throw new WebException("An error has occurred while calling PostCampus method: " + exception.Message);
            }
        }

        public static async Task<bool> PutEvenement(Evenement c)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(c);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync(string.Concat(API_URL + "Evenementen/" + c.EvenementID), content);
                    if (response.IsSuccessStatusCode)
                        return true;
                    else
                        throw new WebException("An error has occurred while calling PutCampus method: " + response.Content);
                }
            }
            catch (WebException exception)
            {
                throw new WebException("An error has occurred while calling PutCampus method: " + exception.Message);
            }
        }
    }
}
