namespace StormTest.StormTest.BusinessService
{
    public class StudentDetailService : IStudentDet
    {
        public string getName(int studentId)
        {
            string compare = studentId == 1 ? "Jaison" : studentId ==2 ? "Ali" : "No student";
            //var studName1 = (studentId == 1) ? "Jaison" : "Ali";
            string studName;
            if (studentId == 1)
            {
                studName = "Jaison";
            }
            else if (studentId == 2)
            {
                studName = "Ali";
            }
            else
            {
                studName = "No Result";
            }
            return studName;
            //throw new NotImplementedException();
        }
    }
}
