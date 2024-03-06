using System;

class SalaryEarned
{
    static void Main(string[] args)
    {

        // initializing and declaring variables
        int[] counters = new int[9];

        int[] grossSales = { 350, 5000, 9000, 7000, 4000, 6000, 8000, 2000, 250 };

        // updating the counters and calculating salespersons salary
        foreach (int sale in grossSales)
        {
            int salary = 200 + (int)(0.08 * sale);
            CounterUpdate(counters, salary);
        }


        // showing the result in a tabular form
        Console.WriteLine("salaryRange\t Number of salesPerson");

        Console.WriteLine("--------------------------------------");

        Console.WriteLine($"$200-$299\t\t {counters[0]}");
        Console.WriteLine($"$300-$399\t\t {counters[1]}");
        Console.WriteLine($"$400-$499\t\t {counters[2]}");
        Console.WriteLine($"$500-$599\t\t {counters[3]}");
        Console.WriteLine($"$600-$699\t\t {counters[4]}");
        Console.WriteLine($"$700-$799\t\t {counters[5]}");
        Console.WriteLine($"$800-$899\t\t {counters[6]}");
        Console.WriteLine($"$900-$999\t\t {counters[7]}");
        Console.WriteLine($"1000 and more\t\t {counters[8]}");


    }


    // The logic below updates the counter by using the salary range
    static void CounterUpdate(int[] counters, int salary)
    {
        if (salary >= 200 && salary <= 299)
        {
            counters[0]++;
        }

        else if (salary >= 300 && salary <= 399)
        {
            counters[1]++;
        }

        else if (salary >= 400 && salary <= 499)
        {
            counters[2]++;
        }

        else if (salary >= 500 && salary <= 599)
        {
            counters[3]++;
        }

        else if (salary >= 600 && salary <= 699)
        {
            counters[4]++;
        }

        else if (salary >= 700 && salary <= 799)
        {
            counters[5]++;
        }

        else if  (salary >= 800 && salary <= 899)
        {
            counters[6]++;
        }

        else if (salary >= 900 && salary <= 999)
        {
            counters[7]++;
        }

        else
        {
            counters[8]++;
        }
    }
}




/*
Use a one-dimensional array to solve the following problem:
Vale pays its salespeople on a commission basis. The salespeople receive $200 per week plus 9% of
their gross sales for that week. For example, a salesperson who grosses $5,000 in sales
in a week receives $200 plus 9% of $5,000, or a total of $650. Write an application (using an array of counters)
that determines how many of the salespeople earned salaries in each of the following ranges (assume
that each salesperson’s salary is truncated to an integer amount):
a) $200–299
b) $300–399
c) $400–499
d) $500–599
e) $600–699
f) $700–799
g) $800–899
h) $900–999
i) $1,000 and over
Summarize the results in tabular format
*/