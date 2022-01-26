using System;

namespace CodeCovSampleTestProject
{
    public class MyTestClass
    {
        public bool CanVote(DateTime? dateOfBirth)
        {
            if (dateOfBirth == null)
                throw new NullReferenceException("DOB");

            int age = (int)(DateTime.Now.Subtract((DateTime)dateOfBirth).TotalDays / 365.25);
            if (age >= 18)
                return true;
            else
                return false;
        }
    }
}
