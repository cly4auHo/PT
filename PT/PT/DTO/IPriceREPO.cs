namespace PT.DTO;

public interface IPriceREPO
{
    Task DoRecord(CurrencyEntity model);
}