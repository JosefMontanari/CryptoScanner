using CryptoScanner.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CryptoScanner.UI.Pages
{
    public class IndexModel : PageModel
    {
        public List<ViewModel> Currencies { get; set; }
        public ViewModel? CryptoCurrencyRootModel { get; set; }
        public string ErrorMessage { get; set; }

        [BindProperty]
        public string? CryptoCurrencyName { get; set; }

        //public async Task<ActionResult> OnGet()
        //{
        //    Currencies = await new Apicaller().GetCurrency();
        //}

        public async Task<ActionResult> OnPost()
        {
            if (CryptoCurrencyName == null)
            {
                ErrorMessage = "Try searching for something else!";
                return Page();
            }
            try
            {
                // Sök på coinet med hjälp av namn för att få upp värdet
                //CryptoCurrencyRootModel = await new Apicaller().GetBitcoin(CryptoCurrencyName);
            }
            catch (Exception ex)
            {

            }

            return Page();
        }
    }
}
