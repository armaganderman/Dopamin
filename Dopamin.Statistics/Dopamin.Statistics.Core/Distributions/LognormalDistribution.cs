using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dopamin.Statistics.Core.Distributions
{
    public class LognormalDistribution
    {
        public static double GetPDF(double mean, double standardDeviation, double x)
        {
            double pdf = 0;

            double equation1 = Math.Log(x) - mean;
            double equation2 = -(Math.Pow(equation1, 2) / (2 * Math.Pow(standardDeviation, 2)));
            double equation3 = 1 / (x * standardDeviation * Math.Sqrt(2 * Math.PI));
            pdf = equation3 * Math.Exp(equation2);

            return pdf;
        }

        public static double GetCDF(double mean, double standardDeviation, double x)
        {
            double cdf = 0;

            double equation1 = (Math.Log(x) - mean) / (standardDeviation * Math.Sqrt(2));
            cdf = 0.5 * (1 + ErrorFunction(equation1));

            return cdf;
        }

        public static double GetQuantile(double mean, double standardDeviation, double p)
        {
            double quantile = 0;

            double equation1 = (2 * p) - 1;
            double equation2 = Math.Sqrt(2 * Math.Pow(standardDeviation, 2)) / ErrorFunction(equation1);
            quantile = Math.Exp(mean + equation2);

            return quantile;
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
        public static List<double> GetListOfPDF(double mean, double standardDeviation, List<double> randomNumberList)
        {
            var pdfList = new List<double>();

            for (int i = 0; i < randomNumberList.Count; i++)
            {
                var pdf = GetPDF(mean, standardDeviation, randomNumberList[i]);
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
        public static List<double> GetListOfCDF(double mean, double standardDeviation, List<double> randomNumberList)
        {
            var cdfList = new List<double>();

            for (int i = 0; i < randomNumberList.Count; i++)
            {
                var cdf = GetCDF(mean, standardDeviation, randomNumberList[i]);
                cdfList.Add(cdf);
            }

            return cdfList;
        }

        public static List<double> GetListOfQuantile(double mean, double standardDeviation, List<double> randomNumbers, double iterationNumber)
        {
            var quantileList = new List<double>();

            for (int i = 0; i < iterationNumber; i++)
            {
                var quantile = GetQuantile(mean, standardDeviation, randomNumbers[i]);
                quantileList.Add(quantile);
            }

            return quantileList;
        }

    }
}
