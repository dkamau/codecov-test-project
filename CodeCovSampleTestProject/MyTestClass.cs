using System;

namespace CodeCovSampleTestProject
{
    public class MyTestClass
    {
        public bool CanVote(DateTime dateOfBirth)
        {
            int age = (int)(DateTime.Now.Subtract(dateOfBirth).TotalDays / 365.25);

            if (age > 18)
                return true;
            else
                return false;
        }
    }
}
