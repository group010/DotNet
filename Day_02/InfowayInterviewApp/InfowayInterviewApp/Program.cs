//using System;

//namespace InfowayInterviewApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//			try
//			{
//				Student student = new Student();
//				student.StudentId = 1;
//				student.StudentName= "Test";
//				student.Email = "Test";
//				student.Phone = "983623748";
//				student.TotalMarks = 63;
//				string result = student.CalculateResult(student.TotalMarks);
//				Console.WriteLine(result);

//			}
//			catch (Exception ex)
//			{
//                Console.WriteLine(ex.Message);
//            }
//			Console.ReadKey();
//        }
//    }
//}


////2.for out(type of parameter to a function):
//using System;

//namespace InfowayInterviewApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Student student = new Student();
//                student.StudentId = 1;
//                student.StudentName = "Test";
//                student.Email = "Test";
//                student.Phone = "983623748";
//                student.TotalMarks = 90;
//                string company;
//                string result = student.CalculateResult(student.TotalMarks ,out company);
//                Console.WriteLine(result);
//                Console.WriteLine($"Interview for the company : {company}");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            Console.ReadKey();
//        }
//    }
//}



//3.for ref(type of parameter to a function):
//using System;

//namespace InfowayInterviewApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Student student = new Student();
//                student.StudentId = 1;
//                student.StudentName = "Test";
//                student.Email = "Test";
//                student.Phone = "983623748";
//                student.TotalMarks = 90;
//                string company=string.Empty;
//                string result = student.CalculateResult(student.TotalMarks,ref company);
//                Console.WriteLine(result);
//                Console.WriteLine($"Interview for the company : {company}");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            Console.ReadKey();
//        }
//    }
//}


////4.Params
//using System;

//namespace InfowayInterviewApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Student student = new Student();
//                student.StudentId = 1;
//                student.StudentName = "Test";
//                student.Email = "Test";
//                student.Phone = "983623748";
//                student.TotalMarks = 90;
//                string company = string.Empty;
//                string result = student.CalculateResult(student.TotalMarks, ref company);
//                Console.WriteLine(result);
//                Console.WriteLine($"Interview for the company : {company}");
//                //Console.WriteLine($"Interview for the compnay-student.InterviewCities{company}!");
//                Console.WriteLine("Locations : ");
//                student.InterviewCities("Mumbai", "Pune", "Bangolre", "Chennai");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            Console.ReadKey();
//        }
//    }
//}



//5.Delegate -->Basket
using System;
using System.Security.Cryptography.X509Certificates;

namespace InfowayInterviewApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Student student = new Student();
                student.OnSelection += new InterviewBasket(OracleDB);
                student.OnSelection += new InterviewBasket(ExcelDB);
                student.OnRejection += new InterviewBasket(MsSQLServerDB);

                student.StudentId = 1;
                student.StudentName = "Test";
                student.Email = "Test";
                student.Phone = "983623748";
                student.TotalMarks = 78;
                if (student.TotalMarks > 80 && student.TotalMarks < 95)
                {
                    student.OnSelection -= new InterviewBasket(ExcelDB);
                }
                string company = string.Empty;
                string result = student.CalculateResult(student.TotalMarks, ref company);
                Console.WriteLine(result);
                Console.WriteLine($"Interview for the company : {company}");
                //Console.WriteLine($"Interview for the compnay-student.InterviewCities{company}!");
                Console.WriteLine("Locations : ");
                student.InterviewCities("Mumbai", "Pune", "Bangolre", "Chennai");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        private static void OracleDB()
        {
            Console.WriteLine("Data is stored in Oracle DB!");
        }
        private static void MsSQLServerDB()
        {
            Console.WriteLine("Data is stored in MicrosoftSQL Server DB ");
        }
        private static void ExcelDB()
        {
            Console.WriteLine("Data is stored in ExcelDB ");
        }

    }
}


