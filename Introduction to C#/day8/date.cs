using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    //internal class date
    //{
    //    int day, month, year; //               0   1   2   3   4   5   6   7   8   9   10 
    //    private static readonly int[] notL = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31,30,31 };
    //    private static readonly int[] isL = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
         
    //    public date(int day, int month, int year)
    //    {
    //        bool isLeapYear = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    //        if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
    //        {
    //            int[] days= isLeapYear ?isL: notL;
    //            if (day >= 1 && day <= days[month])
    //            {

    //                this.day = day;
    //                this.month = month;
    //                this.year = year;
    //            }
    //            else {
    //                this.day = 01;
    //                this.month = 01;
    //                this.year = 0001;
    //            }
    //        }
           

    //    }
    //    public string getDate()
    //    {
    //        return $"{day.ToString().PadLeft(2,'0')}/ {month.ToString().PadLeft(2, '0')} /{year.ToString().PadLeft(4, '0')}";
    //    }


//    }


    public class person
    {
        public string name;
    }





















}
