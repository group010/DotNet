//using System;
//namespace InfowayInterviewApp
//{
//    internal class Student
//    {
//        public int StudentId { get; set; }
//        public string StudentName { get; set; }
//        public string Email { get; set; }
//        public string Phone { get; set; }
//        public int TotalMarks { get; set; }
//        public string CalculateResult(int totalMarks)
//        {
//            if(TotalMarks>80)
//            {
//             return string.Format($"Student{StudentName} has been selected for next round of interview!!");
//            }
//            else
//            {
//             return string.Format($"Student{StudentName} has not been selected, Better luck next time!!!");
//            }
//        }
//    }



////2.for out(type of parameter to a function):
//using System;
//namespace InfowayInterviewApp
//{
//    internal class Student
//    {
//        public string companyName;

//        public int StudentId { get; set; }
//        public string StudentName { get; set; }
//        public string Email { get; set; }
//        public string Phone { get; set; }
//        public int TotalMarks { get; set; }
//        public string CalculateResult(int totalMarks,out string companyName)
//        {
//            companyName = "Infosys Ltd";

//            if (TotalMarks > 80)
//            {
//                return string.Format($"Student{StudentName} has been selected for next round of interview!!");
//            }
//            else
//            {
//                return string.Format($"Student{StudentName} has not been selected, Better luck next time!!!");
//            }
//        }
//    }
//}



//// 3.for ref(type of parameter to a function):
//using System;
//namespace InfowayInterviewApp
//{
//    internal class Student
//    {
//        public string companyName;

//        public int StudentId { get; set; }
//        public string StudentName { get; set; }
//        public string Email { get; set; }
//        public string Phone { get; set; }
//        public int TotalMarks { get; set; }
//        public string CalculateResult(int totalMarks, ref string companyName)
//        {
//            companyName = "Infosys Ltd";

//            if (TotalMarks > 80)
//            {
//                return string.Format($"Student{StudentName} has been selected for next round of interview!!");
//            }
//            else
//            {
//                return string.Format($"Student{StudentName} has not been selected, Better luck next time!!!");
//            }
//        }
//    }
//}


//4.Params
using System;
namespace InfowayInterviewApp

{
    public delegate void InterviewBasket();

    internal class Student
    {
        public event InterviewBasket OnSelection;
        public event InterviewBasket OnRejection;
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int TotalMarks { get; set; }
        public string CalculateResult(int totalMarks, ref string companyName)
        {
            companyName = "Infosys Ltd";

            if (TotalMarks > 80)
            {
                if(OnSelection != null)
                {
                    OnSelection();
                }
                return string.Format($"Student{StudentName} has been selected for next round of interview!!");
            }
            else
            {
                if (OnRejection != null)
                {
                    OnRejection();   
                }
                return string.Format($"Student{StudentName} has not been selected, Better luck next time!!!");
            }
        }
        public void InterviewCities(params string[] cities)
        {
            foreach (string city in cities)
            {
                System.Console.WriteLine(city);
            }
        }
    }
}

