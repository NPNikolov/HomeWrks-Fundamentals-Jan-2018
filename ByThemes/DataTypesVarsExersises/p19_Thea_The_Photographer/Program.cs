using System;

namespace p19_Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long nNumPic = long.Parse(Console.ReadLine());
            long ftPicsTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long inspectTime = ftPicsTime * nNumPic;
            long nmbrPicsToUpload = (long)Math.Ceiling(nNumPic * filterFactor / 100.0);
            uploadTime *= nmbrPicsToUpload;
            uploadTime += inspectTime;

            long nmbrDays = uploadTime / 86400;
            long tmp = nmbrDays * 86400;
            tmp = uploadTime - tmp;
            long nmbrHours = tmp / 3600;
            tmp = tmp - (nmbrHours * 3600);
            long nmbrMins = tmp / 60;
            long nmbrSecs = tmp - (nmbrMins * 60);

            Console.WriteLine($"{nmbrDays}:{nmbrHours,0:d2}:{nmbrMins,0:d2}:{nmbrSecs,0:d2}");
        }
    }
}