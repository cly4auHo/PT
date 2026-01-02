namespace PT.API;

public interface IServer
{
    Task<BinanceResponseModel> GetCurrency(string currencyName);
}