namespace Incapsulation.EnterpriseTask;

public class Enterprise
{
	public Enterprise(Guid guid)
	{
		this.Guid = guid;
	}

	public string Inn 
	{
		get => field;
		set
		{
            if (Inn.Length != 10 || !Inn.All(z => char.IsDigit(z)))
				throw new ArgumentException();
			field = value;
		}
    }

	public string Name { get; set; } //
    public Guid Guid { get; } //
    public DateTime EstablishDate { get; set; } //


    public TimeSpan ActiveTimeSpan => DateTime.Now - EstablishDate;

    public double getTotalTransactionsAmount()
	{
		DataBase.OpenConnection();
		var amount = 0.0;
		foreach (Transaction t in DataBase.Transactions().Where(z => z.EnterpriseGuid == Guid))
			amount += t.Amount;
		return amount;
	}
}