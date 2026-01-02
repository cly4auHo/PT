using System.Globalization;
using PT.API;
using PT.DTO;

namespace PT.Services;

public class CollectionService(IServer server, IPriceREPO priceRepo, AppSettings appSettings) : ICollectionService
{
    public async Task DoRecord()
    {
        var currencies = appSettings.Currencies;

        foreach (var currencyName in currencies)
        {
            var currency = await server.GetCurrency(currencyName);

            if (currency == null)
                continue;

            var price = decimal.Parse(currency.Price, CultureInfo.InvariantCulture);
            var model = new CurrencyEntity { Name = currency.Symbol, Price = price, Timestamp = DateTime.UtcNow };
            
            await priceRepo.DoRecord(model);
        }
    }
}