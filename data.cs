using System;

namespace pol;

 class data
{
    public double document { get; set; }
    public string firstName { get; set; }
    public string lostName { get; set; }
    public double salary { get; set; }
    public int workdDays { get; set; }
    public double transportation { get; set; }
    public double totalTransport { get; set; }
    public double totalSalary { get; set; }
    public double accrued { get; set; }
    public double health { get; set; }
    public double pension { get; set; }
    public double total { get; set; }


    public data()
    {

    }

   public data(double document, string firstName, string lostName, double salary, int workdDays, double transportation)
    {
        this.document = document;
        this.firstName = firstName;
        this.lostName = lostName;
        this.salary = salary;
        this.workdDays = workdDays;
        this.transportation = transportation;
    }



}





