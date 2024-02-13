using CryptoScanner.Data.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CryptoScanner.Data.Models.KryptoRoot;

namespace CryptoScanner.App.Api
{
    public class Apicaller
    {
        
        public async Task <ViewModel> GetBitcoin(string kryptoName)
        {
            HttpClient client = new();

            client.BaseAddress = new Uri("https://api.coingecko.com/api/v3/");

            HttpResponseMessage response = await client.GetAsync(kryptoName.ToLower());



            if(response.IsSuccessStatusCode)
            {
                string kryptoJson = await response.Content.ReadAsStringAsync();

                Root? kryptoRoot = JsonConvert.DeserializeObject<Root>(kryptoJson);   



                if(kryptoRoot != null) 
                
                {
                    //ViewModel bitcoinViewModel = new KryptoManager().ProjectApiModelToViewModel(kryptoRoot);

                    //return bitcoinViewModel;
                }
                throw new JsonException();
            }

            throw new HttpRequestException();
        }
    }
}
