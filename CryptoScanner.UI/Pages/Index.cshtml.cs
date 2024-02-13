using CryptoScanner.App.Api;
using CryptoScanner.Data.Models;
using CryptoScanner.Data.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CryptoScanner.UI.Pages
{
    public class IndexModel : PageModel
    {
        public List<ViewModel>? Currencies { get; set; }
        public ViewModel? CryptoCurrencyRootModel { get; set; }
        public string ErrorMessage { get; set; }

        [BindProperty]
        public string? CryptoCurrencyName { get; set; }


        public async Task<ActionResult> OnGet()
        {
            try
            {

                Currencies = await new Apicaller().GetCurrency();
                return Page();

            }
            catch (Exception ex)
            {

            }
            return Page();

        }

        public async Task<ActionResult> OnPost()
        {
            if (CryptoCurrencyName == null)
            {
                ErrorMessage = "Try searching for something else!";
                return Page();
            }
            try
            {
                //Sök på coinet med hjälp av namn för att få upp värdet
                CryptoCurrencyRootModel = await new Apicaller().GetBitcoin($"coins/markets?vs_currency=sek&ids={CryptoCurrencyName}&order=market_cap_desc&per_page=100&page=1&sparkline=false&locale=en");

            }
            catch (Exception ex)
            {

            }

            return Page();
        }

        public void AddToDb()
        {
            KryptoDbModel kryptoDbModel = new KryptoDbModel()
            {
                Name = CryptoCurrencyRootModel.Name,
                CurrentPrice = CryptoCurrencyRootModel.CurrentPrice,
            };


        }
    }
}
