using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Wendy's";
        job1._jobTitle = "Cook";
        job1._startYear = 2025;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Rex Burger";
        job2._jobTitle = "Cook";
        job2._startYear = 2025;
        job2._endYear = 2026;

        Resume resume1 = new Resume();
        resume1._name = "Bob Brown";
        // resume1._jobs = new() {job1, job2};
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}