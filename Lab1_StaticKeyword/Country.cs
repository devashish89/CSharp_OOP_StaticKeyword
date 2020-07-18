using System;

public class Country
{
    public string CountryName { get; set; }
    public int CountryID { get; set; }

    public void Insert()
    {
        ++CommonUtility.counter;
        if (!CommonUtility.IsEmpty(CountryName) && !CommonUtility.IsEmpty(CountryID.ToString()))
        {
            Console.WriteLine("Country inserted: "+CountryName);
        }
    }
}
