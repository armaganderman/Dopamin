using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.Distributions
{
    public static class NormalDistribution
    {

        /// <summary>
        /// Probability Density Function (PDF)
        /// </summary>
        /// <param name="mean">mean value</param>
        /// <param name="standardDeviation">standard deviation</param>
        /// <param name="x">input variable for PDF</param>
        /// <returns>returns the result of probability density function</returns>
        public static double GetPDF(double mean, double standardDeviation, double x)
        {
            double pdf = 0;

            var power = -(Math.Pow(x - mean, 2) / (2 * Math.Pow(standardDeviation, 2)));
            pdf = (1 / Math.Sqrt(2 * Math.PI)) * Math.Exp(power);

            return pdf;
        }

        /// <summary>
        /// Cumulative Distribution Function
        /// </summary>
        /// <param name="mean">mean value</param>
        /// <param name="standardDeviation">standard deviation</param>
        /// <param name="x">input variable for CDF</param>
        /// <returns>returns the result of cumulative distribution function</returns>
        public static double GetCDF(double mean, double standardDeviation, double x)
        {
            double cdf = 0;

            var function = (x - mean) / (standardDeviation * Math.Sqrt(2));
            cdf = 0.5 * (1 + ErrorFunction(function));

            return cdf;
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
        /// Returns mean value of normal distribution.
        /// </summary>
        /// <param name="mean">mean value</param>
        /// <returns></returns>
        public static double GetMean(double mean)
        {
            return mean;
        }

        /// <summary>
        /// Returns median value of normal distribution. In facti for a normal distribution, mean = median = mode.
        /// </summary>
        /// <param name="mean">mean value</param>
        /// <returns></returns>
        public static double GetMedian(double mean)
        {
            return mean;
        }

        /// <summary>
        /// Returns mode value of normal distribution. In facti for a normal distribution, mean = median = mode.
        /// </summary>
        /// <param name="mean">mean value</param>
        /// <returns></returns>
        public static double GetMode(double mean)
        {
            return mean;
        }

        /// <summary>
        /// Returns variance value of normal distribution
        /// </summary>
        /// <param name="standardDeviation">standard deviation</param>
        /// <returns></returns>
        public static double GetVariance(double standardDeviation)
        {
            return Math.Pow(standardDeviation, 2);
        }

        /// <summary>
        /// Returns standard Deviation value of normal distribution.
        /// </summary>
        /// <param name="standardDeviation">standard deviation</param>
        /// <returns></returns>
        public static double GetStandardDeviation(double standardDeviation)
        {
            return standardDeviation;
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

    }
}
