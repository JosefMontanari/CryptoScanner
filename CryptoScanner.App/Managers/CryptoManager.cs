using CryptoScanner.Data.Models;

namespace CryptoScanner.App.Managers
{
    public class CryptoManager
    {
        public ViewModel ProjectApiModelToViewModel(KryptoRoot rootModel)
        {
            ViewModel viewModel = new()
            {
                Name = rootModel.Name,
                CurrentPrice = rootModel.CurrentPrice,
                MarketCap = rootModel.MarketCap,
                AthDate = rootModel.AthDate,
                AtlDate = rootModel.AtlDate,
                LastUpdated = rootModel.LastUpdated
            };

            return viewModel;
        }
    }
}
