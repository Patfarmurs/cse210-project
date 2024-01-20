using System;

public class Job
{
    // Properties
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Methods
    public void Display()
    {
        Console.WriteLine($"Job Title: {_jobTitle}, Company: {_company}, StartYear: {_startYear}, EndYear: {_endYear}");
    }
}
