using System;

public class Customer
{
    public string CustomerName { get; set; }
    public int CustomerID { get; set; }
    private string _machinename;

    public string machinename { get { return _machinename; } }

    public Customer()
    {
        _machinename = CommonUtility.getMachineName();
 
    }

    public void Insert()
    {
        ++CommonUtility.counter;
        if(!CommonUtility.IsEmpty(CustomerName) && !CommonUtility.IsEmpty(CustomerID.ToString()))
        {
            Console.WriteLine("Customer inserted: "+CustomerName);
        }

    }
}
