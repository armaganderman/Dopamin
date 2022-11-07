using Dopamin.Statistics.Core.RandomNumbers;
using System;
using System.Collections.Generic;

namespace Dopamin.Statistics.Core.Distributions
{
    public static class ContinousUniformDistribution
    {

        /// <summary>
        /// Probability Density Function (PDF)
        /// </summary>
        /// <param name="minValue">minimum value of uniform distribution</param>
        /// <param name="maxValue">maximum value of uniform distribution</param>
        /// <param name="x">input variable for PDF</param>
        /// <returns>returns the result of probability density function</returns>
        public static double GetPDF(double minValue, double maxValue, double x)
        {
            double pdf = 0;

            if (minValue <= x && x <= maxValue) pdf = 1 / (maxValue - minValue);
            else pdf = 0;

            return pdf;
        }

        /// <summary>
        /// Cumulative Distribution Function
        /// </summary>
        /// <param name="minValue">minimum value of uniform distribution</param>
        /// <param name="maxValue">maximum value of uniform distribution</param>
        /// <param name="x">input variable for CDF</param>
        /// <returns>returns the result of cumulative distribution function</returns>
        public static double GetCDF(double minValue, double maxValue, double x)
        {
            double cdf = 0;

            if (x < minValue) cdf = 0;
            else if (minValue <= x && x <= maxValue) cdf = (x - minValue) / (maxValue - minValue);
            else if (x > maxValue) cdf = 1;

            return cdf;
        }

        /// <summary>
        /// Mean value of uniform distribution. Informally arithmetic average of min and max values
        /// </summary>
        /// <param name="minValue">minimum value of uniform distribution</param>
        /// <param name="maxValue">maximum value of uniform distribution</param>
        /// <returns>returns mean value of the uniform distribution</returns>
        public static double GetMean(double minValue, double maxValue)
        {
            return (minValue + maxValue) / 2;
        }

        /// <summary>
        /// Median value of uniform distribution. 
        /// In statistics and probability theory, median is the value separating the higher half from the lower half of a data sample, 
        /// a population, or a probability distribution. In other words, it is the middle value. In uniform distribution mean and median
        /// equal to each other.
        /// </summary>
        /// <param name="minValue">minimum value of uniform distribution</param>
        /// <param name="maxValue">maximum value of uniform distribution</param>
        /// <returns>returns median value of the uniform distribution</returns>
        public static double GetMedian(double minValue, double maxValue)
        {
            return (minValue + maxValue) / 2;
        }

        /// <summary>
        /// Mode value of the uniform distribution. It can be any value between minValue and maxValue.
        /// Hence, any each time different random number within a specified range is returned.
        /// </summary>
        /// <param name="modeValue">the peak value (mode) of uniform distribution</param>
        /// <returns></returns>
        public static double GetMode(double minValue, double maxValue)
        {
            return RandomNumberGenerator.GetRandomDouble(minValue, maxValue);
        }

        /// <summary>
        /// Variance value of the uniform distribution. 
        /// In probability theory and statistics, variance is the expectation of the squared deviation of a random variable 
        /// from its population mean or sample mean. Variance is a measure of dispersion, 
        /// meaning it is a measure of how far a set of numbers is spread out from their average value. 
        /// </summary>
        /// <param name="minValue">minimum value of uniform distribution</param>
        /// <param name="maxValue">maximum value of uniform distribution</param>
        /// <returns>returns variance value of the uniform distribution</returns>
        public static double GetVariance(double minValue, double maxValue)
        {
            return Math.Pow(maxValue - minValue, 2) / 12;
        }

        /// <summary>
        /// standard Deviation value of the uniform distribution. 
        /// In statistics, the standard deviation is a measure of the amount of variation or dispersion of a set of values.
        /// A low standard deviation indicates that the values tend to be close to the mean (also called the expected value) of the set, 
        /// while a high standard deviation indicates that the values are spread out over a wider range.
        /// </summary>
        /// <param name="minValue">minimum value of uniform distribution</param>
        /// <param name="maxValue">maximum value of uniform distribution</param>
        /// <returns></returns>
        public static double GetStandardDeviation(double minValue, double maxValue)
        {
            return Math.Sqrt(GetVariance(minValue, maxValue));
        }

        /// <summary>
        /// Returns a list of pdf values.
        /// </summary>
        /// <param name="minValue">minimum value of uniform distribution</param>
        /// <param name="maxValue">maximum value of uniform distribution</param>
        /// <param name="randomNumberList">a list of uniformly distributed radnom numbers</param>
        /// <returns></returns>
        public static List<double> GetListOfPDF(double minValue, double maxValue, List<double> randomNumberList)
        {
            var pdfList = new List<double>();

            for (int i = 0; i < randomNumberList.Count; i++)
            {
                var pdf = GetPDF(minValue, maxValue, randomNumberList[i]);
                pdfList.Add(pdf);
            }

            return pdfList;
        }

        /// <summary>
        /// Returns a list of cdf values.
        /// </summary>
        /// <param name="minValue">minimum value of uniform distribution</param>
        /// <param name="maxValue">maximum value of uniform distribution</param>
        /// <param name="randomNumberList">a list of uniformly distributed radnom numbers</param>
        /// <returns></returns>
        public static List<double> GetListOfCDF(double minValue, double maxValue, List<double> randomNumberList)
        {
            var cdfList = new List<double>();

            for (int i = 0; i < randomNumberList.Count; i++)
            {
                var cdf = GetCDF(minValue, maxValue, randomNumberList[i]);
                cdfList.Add(cdf);
            }

            return cdfList;
        }

    }
}
