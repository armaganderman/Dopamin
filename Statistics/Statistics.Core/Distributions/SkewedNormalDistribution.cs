using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Distributions
{
    public static class SkewedNormalDistribution
    {

        /// <summary>
        /// Returns pdf value of skewed normal distribution. Methematics of PDF calculation depends on O'Hagan and Leonhard (1976). 
        /// </summary>
        /// <param name="mean">mean (location)</param>
        /// <param name="standardDeviation">standard deviation (scale)</param>
        /// <param name="skewness">skewness (shape)</param>
        /// <param name="x">input variable</param>
        /// <returns></returns>
        public static double GetPDF(double mean, double standardDeviation, double skewness, double x)
        {
            var pdf = 0d;
            var variable = skewness * x;
            var normalPDF = NormalDistribution.GetPDF(0, 1, x);
            var normalCDF = NormalDistribution.GetCDF(0, 1, variable);
            pdf = 2 * normalPDF * normalCDF;
            return pdf;
        }

        /// <summary>
        /// Returns cdf value of skewed normal distribution.
        /// </summary>
        /// <param name="mean">mean</param>
        /// <param name="standardDeviation">standard deviation</param>
        /// <param name="skewness">skewness</param>
        /// <param name="x">input variable</param>
        /// <returns></returns>
        public static double GetCDF(double mean, double standardDeviation, double skewness, double x)
        {
            var cdf = 0d;
            var variable = (x - mean) / standardDeviation;
            var normalCDF = NormalDistribution.GetCDF(0, 1, variable);
            cdf = normalCDF - (2 * OwenT(variable, skewness, x));
            return cdf;
        }

        /// <summary>
        /// Owen's T Function T(h,a) gives the probability of the event x>h  and 0<y<ax where x and y are independent standard normal variables
        /// </summary>
        /// <param name="h">input parameter #1</param>
        /// <param name="a">input parameter #2</param>
        /// <param name="x">input variable</param>
        /// <returns></returns>
        private static double OwenT(double h, double a, double x)
        {
            var result = -999.25d;

            if (a == 0) return 0;
            else if (h == 0) result = (1 / 2 * Math.PI) * Math.Atan(a);
            else if (h < 0) result = OwensTFunction(x);
            else if (a < 0) result = -1 * OwensTFunction(x);
            else if (a == 1) result = 0.5 * NormalDistribution.GetCDF(0, 1, h) * (1 - NormalDistribution.GetCDF(0, 1, h));
            else result = OwensTFunction(x);

            return result;
        }

        /// <summary>
        /// Owens T function depending on mathworld.wolfram.com/OwenT-Function.html
        /// </summary>
        /// <param name="x">input variable</param>
        /// <returns></returns>
        private static double OwensTFunction(double x)
        {
            var owensT = 0d;
            owensT = 1 / 8 * ErrorFunction(-x / Math.Sqrt(2)) * ErrorFunction(x / Math.Sqrt(2));
            return owensT;
        }

        /// <summary>
        /// Error function is used to calculate CDF of the normal distribution.
        /// </summary>
        /// <param name="x">variable defined by the user.</param>
        /// <returns>Ref: https://www.johndcook.com/blog/csharp_erf/ </returns>
        private static double ErrorFunction(double x)
        {
            // constants
            double a1 = 0.254829592;
            double a2 = -0.284496736;
            double a3 = 1.421413741;
            double a4 = -1.453152027;
            double a5 = 1.061405429;
            double p = 0.3275911;

            // Save the sign of x
            int sign = 1;
            if (x < 0)
                sign = -1;
            x = Math.Abs(x);

            // A&S formula 7.1.26
            double t = 1.0 / (1.0 + p * x);
            double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);

            return sign * y;
        }

        /// <summary>
        /// Returns a list of PDF values
        /// </summary>
        /// <param name="mean">mean value</param>
        /// <param name="standardDeviation">standar deviation</param>
        /// <param name="randomNumberList">list of normally distributed numbers</param>
        /// <returns></returns>
        public static List<double> GetListOfPDF(double mean, double standardDeviation, double skewness, List<double> randomNumberList)
        {
            var pdfList = new List<double>();

            for (int i = 0; i < randomNumberList.Count; i++)
            {
                var pdf = GetPDF(mean, standardDeviation, skewness, randomNumberList[i]);
                pdfList.Add(pdf);
            }

            return pdfList;
        }

        /// <summary>
        /// Returns a list of CDF values
        /// </summary>
        /// <param name="mean">mean value</param>
        /// <param name="standardDeviation">standar deviation</param>
        /// <param name="randomNumberList">list of normally distributed numbers</param>
        /// <returns></returns>
        public static List<double> GetListOfCDF(double mean, double standardDeviation, double skewness, List<double> randomNumberList)
        {
            var cdfList = new List<double>();

            for (int i = 0; i < randomNumberList.Count; i++)
            {
                var cdf = GetCDF(mean, standardDeviation, skewness, randomNumberList[i]);
                cdfList.Add(cdf);
            }

            return cdfList;
        }

    }
}
