using CryptoScanner.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoScanner.App.Managers
{
    public class CoinManager
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
