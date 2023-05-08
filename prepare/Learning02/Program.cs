using System;

using System.Collections.Generic;

namespace Learning02
{
    public class Program
    {
        static void Main(string[] args)
        {  
            Job job1 = new Job();
            job1._jobTitle = "Utility";
            job1._company = "Showpro";
            job1._startYear = 2018;
            job1._endYear = 2022;

            Job job2 = new Job();
            job2._jobTitle = "Lifeguard";
            job2._company = "Blueray";
            job2._startYear = 2016;
            job2._endYear = 2018;

            Resume myResume = new Resume();
            myResume._name = "Ryan Simpson";

            myResume._jobs.Add(job1);
            myResume._jobs.Add(job2);
        }
    }
}