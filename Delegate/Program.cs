//using System;

//namespace Dars_TryCatch_Delegate
//{
//    class Program
//    {
//        public delegate void Feedback(string massage);

//        public static void Main(string[] args)
//        {
//            Feedback feedback = new Feedback(FeedbackToConsole);
//            feedback.Invoke("Hello Mon");
//        }
//        public static void FeedbackToConsole(string message)
//        {
//            Console.WriteLine(message);
//        }
//    }
//}

//using System;

//namespace Metod
//{
//    class Program
//    {
//        public delegate string Convcerlar(List<char> massag);

//        public static void Main(string[] args)
//        {
//            Convcerlar convcerlar = new Convcerlar(ConvertCharArrayToString);
//            Console.WriteLine(convcerlar.Invoke(new List<char> { 's', 'a', 'l', 'o', 'm' }));
//        }

//        public static string ConvertCharArrayToString(List<char> massag)
//        {
//            string str = "";
//            foreach (var item in massag)
//            {
//                str += item;
//            }
//            return str;

//        }
//    }
//}



using Delegate;

namespace DelegatMasala2
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightnees; // => new PhotoProcessor.PhotoFilterHandler(filters.ApplyContrast);
            filterHandler += filters.ApplyContrast;  //=> (PhotoProcessor.PhotoFilterHandler)Delegate.Combine(filterHandler, new PhotoProcessor.PhotoFilterHandler(filters.ApplyContrast));
            filterHandler += filters.Resize;
            processor.Process("photo.jpg", filterHandler);
        }
    }
}

