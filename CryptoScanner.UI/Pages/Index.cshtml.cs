using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CryptoScanner.UI.Pages
{
    public class IndexModel : PageModel
    {
        public List<CryptoCurrencyViewModel> Currencies { get; set; }
        public CryptoCurrencyViewModel? cryptoCurrencyViewModel { get; set; }
        public string ErrorMessage { get; set; }

        [BindProperty]
        public string? CryptoCurrencyName { get; set; }

        public async Task<ActionResult> OnGet()
        {
            Currencies = await new ApiCaller().GetCurrency();
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
                // Sök på coinet med hjälp av namn för att få upp värdet
                CryptoCurrenxyViewModel = await new ApiCaller().GetValue(CryptoCurrencyName);
            }
            catch (Exception ex)
            {

            }

            return Page();
        }
    }
}
