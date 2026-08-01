

var sale = new Sale(100, DateTime.Now);
Console.WriteLine(sale.GetInfo());


class Sale
{
    public int total;
    public DateTime date;

    public Sale(int total, DateTime date)
    {
        this.total = total;
        this.date = date;
    }

    public string GetInfo()
    {
        return $"Total: {total}, Date: {date.ToLongDateString()}";
    }

    


}