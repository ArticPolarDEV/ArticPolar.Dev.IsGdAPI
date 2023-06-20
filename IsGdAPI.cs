using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArticPolar.Dev.IsGdAPI
{
    public class IsGdAPI
    {
        string apiUrl = "https://is.gd/create.php";

        public async Task<string> ShortenUrlAsync(string longUrl, string customUrl = null)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var parameters = "format=simple&url=" + Uri.EscapeDataString(longUrl);
                if (!string.IsNullOrEmpty(customUrl))
                {
                    parameters += "&shorturl=" + Uri.EscapeDataString(customUrl);
                }
                
                var response = await httpClient.GetAsync(apiUrl + "?" + parameters);
                if (response.IsSuccessStatusCode)
                {
                    var shortenedUrl = await response.Content.ReadAsStringAsync();
                    return shortenedUrl.Trim();
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode + ", verify if this link already exists!");
                    return null;
                }
            }
        }
    }
}
