

var sale = new Sale(100, DateTime.Now);
sale.Total = -50;
//sale.Date = DateTime.Now;
Console.WriteLine(sale.Total);


class Sale
{
     private int total;
     private DateTime date;

    public int Total 
    {
        get
        {
            return total;
        }

        set
        {
            if(value < 0)
                value = 0;
            total = value;
        }
    }
    public string Date 
    {
        get
        {
            return date.ToLongDateString();    
        }
    }


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