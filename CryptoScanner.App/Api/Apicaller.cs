using CryptoScanner.App.Managers;
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

        private readonly HttpClient _client;

        public Apicaller()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("https://api.coingecko.com/api/v3/")
            };
        }



        public async Task<List<ViewModel>> GetCurrency()
        {
            HttpResponseMessage response = await _client.GetAsync("coins/list");

            if (response.IsSuccessStatusCode)
            {
                string kryptoJson = await response.Content.ReadAsStringAsync();

                List<KryptoListRoot>? kryptoRootList = JsonConvert.DeserializeObject<List<KryptoListRoot>>(kryptoJson);

                if (kryptoRootList != null && kryptoRootList.Any())
                {
                    List<ViewModel> viewModelList = new List<ViewModel>();

                    foreach (var kryptoRoot in kryptoRootList.Take(10))
                    {
                        ViewModel viewModel = new CryptoManager().ProjectApiModelToViewModel(kryptoRoot);
                        viewModelList.Add(viewModel);
                    }

                    return viewModelList;
                }
                throw new JsonException("No data received from API or deserialization failed.");
            }

            throw new HttpRequestException("Failed to retrieve data from API.");
        }


        public async Task<ViewModel> GetBitcoin(string kryptoName)
        {

            HttpResponseMessage response = await _client.GetAsync(kryptoName);
      

            if (response.IsSuccessStatusCode)
            {
                string kryptoJson = await response.Content.ReadAsStringAsync();

                KryptoRoot? kryptoRoot = JsonConvert.DeserializeObject<KryptoRoot>(kryptoJson);



                if (kryptoRoot != null)

                {
                    ViewModel bitcoinViewModel = new CoinManager().ProjectApiModelToViewModel(kryptoRoot);

                    return bitcoinViewModel;
                }
                throw new JsonException();
            }

            throw new HttpRequestException();
        }


        //public async Task<ViewModel> GetBitcoin(string kryptoName)
        //{
        //    HttpClient client = new();

        //    client.BaseAddress = new Uri("https://api.coingecko.com/api/v3/");

        //    HttpResponseMessage response = await client.GetAsync(kryptoName.ToLower());



        //    if (response.IsSuccessStatusCode)
        //    {
        //        string kryptoJson = await response.Content.ReadAsStringAsync();

        //        KryptoRoot? kryptoRoot = JsonConvert.DeserializeObject<KryptoRoot>(kryptoJson);



        //        if (kryptoRoot != null)

        //        {
        //            ViewModel bitcoinViewModel = new CoinManager().ProjectApiModelToViewModel(kryptoRoot);

        //            return bitcoinViewModel;
        //        }
        //        throw new JsonException();
        //    }

        //    throw new HttpRequestException();
        //}

    }
    }


    

