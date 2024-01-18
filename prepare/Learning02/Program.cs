using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Doctor";
        job1._company = "(Hospital Creek)";
        job1._startYear = 1990;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Doctor cirgury";
        job2._company = "(Hospital Marry)";
        job2._startYear = 1980;
        job2._endYear = 1990;

        Resume Mresume = new Resume();
        Mresume._name = "Allan Matos";

        Mresume._jobs.Add(job1);
        Mresume._jobs.Add(job2);

        Mresume.Display();
    }
}