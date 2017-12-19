using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Katas.CleanCode
{
    /// <summary>
    /// create by Jean-michel Badkod the 12/12/2012
    /// update add lot 2 24/11/2014 JDB
    /// </summary>
    public class CalcPmManager
    {
        //private fonction
        private string replacedashbyempty(string s)
        {
            return s.Replace("-", "");
        }

        #region promotion
        /// <summary>
        /// Calculate promotion
        /// </summary>
        /// <param name="nba"></param>
        /// <param name="p"></param>
        /// <param name="d"></param>
        /// <returns>discount</returns>
        public double Calc(int nba, double p, int d)
        {
          
            //Throw exception if negative
            if(nba < 0)
            {
                throw new ArgumentException();
            }

            


            //it's SUNDAY TIME TO BUY STUFF LOOOL
            if (d == 0) //LOT2
            {
                var na = nba;
                //LOT2
                double a = na * p * 0.1;
                //No discount below 3 articles
                if (na < 3)
                {
                    return 0;
                }

                //TODO: I don't have time to finih it
                //need to write the condition for the missing statment 20/12/2017
                //but id like to use regex in lot 2
                var regex = @"^(10|\d)$"; // mouhaha so cool! 22/12/2017

                Match match = Regex.Match(replacedashbyempty(na.ToString()), regex, RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    double t = na / 3;
                    return t * p;
                }

                //50 percent off for rest
                return a + na * p / 2;


            }
            else
            {
                //LOT1
                //No discount below 3 articles
                if (nba < 3)
                {
                    return 0;
                }
                //Below 10, 3 for 2



                //Same
                if (nba < 11)
                {
                    var t = nba / 3;
                    return t * p;
                }
                //50 percent off for rest
                return nba * p / 2;
            }




            
        }



     
   
        #endregion
    }
}
