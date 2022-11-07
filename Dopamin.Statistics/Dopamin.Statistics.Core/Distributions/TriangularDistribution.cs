using System;
using System.Collections.Generic;

namespace Dopamin.Statistics.Core.Distributions
{
    public static class TriangularDistribution
    {
        /// <summary>
        /// Probability Density Function (PDF)
        /// </summary>
        /// <param name="minValue">minimum value of triangular distribution</param>
        /// <param name="modeValue">the peak value (mode) of triangular distribution</param>
        /// <param name="maxValue">maximum value of triangular distribution</param>
        /// <param name="x">input variable for PDF</param>
        /// <returns>returns the result of probability density function</returns>
        public static double GetPDF(double minValue, double modeValue, double maxValue, double x)
        {
            double pdf = 0;

            if (x < minValue) pdf = 0;
            else if (minValue <= x && x < modeValue) pdf = (2 * (x - minValue)) / ((maxValue - minValue) * (modeValue - minValue));
            else if (x == modeValue) pdf = 2 / (maxValue - minValue);
            else if (modeValue < x && x <= maxValue) pdf = (2 * (maxValue - x)) / ((maxValue - minValue) * (maxValue - modeValue));
            else if (maxValue < x) pdf = 0;

            return pdf;
        }

        /// <summary>
        /// Cumulative Distribution Function
        /// </summary>
        /// <param name="minValue">minimum value of triangular distribution</param>
        /// <param name="modeValue">the peak value (mode) of triangular distribution</param>
        /// <param name="maxValue">maximum value of triangular distribution</param>
        /// <param name="x">input variable for CDF</param>
        /// <returns>returns the result of cumulative distribution function</returns>
        public static double GetCDF(double minValue, double modeValue, double maxValue, double x)
        {
            double cdf = 0;

            if (x <= minValue) cdf = 0;
            else if (minValue < x && x <= modeValue) cdf = Math.Pow(x - minValue, 2) / ((maxValue - minValue) * (modeValue - minValue));
            else if (modeValue < x && x < maxValue) cdf = 1 - (Math.Pow(maxValue - x, 2) / ((maxValue - minValue) * (maxValue - modeValue)));
            else if (maxValue <= x) cdf = 1;

            return cdf;
        }

        /// <summary>
        /// Mean value of triangular distribution. Informally arithmetic average of min, mode and max values
        /// </summary>
        /// <param name="minValue">minimum value of triangular distribution</param>
        /// <param name="modeValue">the peak value (mode) of triangular distribution</param>
        /// <param name="maxValue">maximum value of triangular distribution</param>
        /// <returns>returns mean value of the triangular distribution</returns>
        public static double GetMean(double minValue, double modeValue, double maxValue)
        {
            return (minValue + modeValue + maxValue) / 3;
        }

        /// <summary>
        /// Median value of triangular distribution. 
        /// In statistics and probability theory, median is the value separating the higher half from the lower half of a data sample, 
        /// a population, or a probability distribution.
        /// In other words, it is the middle value.
        /// </summary>
        /// <param name="minValue">minimum value of triangular distribution</param>
        /// <param name="modeValue">the peak value (mode) of triangular distribution</param>
        /// <param name="maxValue">maximum value of triangular distribution</param>
        /// <returns>returns median value of the triangular distribution</returns>
        public static double GetMedian(double minValue, double modeValue, double maxValue)
        {
            double median = 0;

            if (modeValue >= ((minValue + maxValue) / 2)) median = minValue + Math.Sqrt((maxValue - minValue) * (modeValue - minValue) / 2);
            else if (modeValue < ((minValue + maxValue) / 2)) median = maxValue - Math.Sqrt((maxValue - minValue) * (maxValue - modeValue) / 2);

            return median;
        }

        /// <summary>
        /// Mode value of the triangular distribution. 
        /// The mode is the value that appears most often in a set of data values
        /// </summary>
        /// <param name="modeValue">the peak value (mode) of triangular distribution</param>
        /// <returns></returns>
        public static double GetMode(double modeValue)
        {
            return modeValue;
        }

        /// <summary>
        /// Variance value of the triangular distribution. 
        /// In probability theory and statistics, variance is the expectation of the squared deviation of a random variable 
        /// from its population mean or sample mean. Variance is a measure of dispersion, 
        /// meaning it is a measure of how far a set of numbers is spread out from their average value. 
        /// </summary>
        /// <param name="minValue">minimum value of triangular distribution</param>
        /// <param name="modeValue">the peak value (mode) of triangular distribution</param>
        /// <param name="maxValue">maximum value of triangular distribution</param>
        /// <returns>returns variance value of the triangular distribution</returns>
        public static double GetVariance(double minValue, double modeValue, double maxValue)
        {
            return (Math.Pow(minValue, 2) + Math.Pow(maxValue, 2) + Math.Pow(modeValue, 2) - (minValue * maxValue) - (minValue * modeValue) - (maxValue * modeValue)) / 18;
        }

        /// <summary>
        /// standard Deviation value of the triangular distribution. 
        /// In statistics, the standard deviation is a measure of the amount of variation or dispersion of a set of values.
        /// A low standard deviation indicates that the values tend to be close to the mean (also called the expected value) of the set, 
        /// while a high standard deviation indicates that the values are spread out over a wider range.
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="modeValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static double GetStandardDeviation(double minValue, double modeValue, double maxValue)
        {
            return Math.Sqrt(GetVariance(minValue, modeValue, maxValue));
        }

        /// <summary>
        /// Return a list of PDF values
        /// </summary>
        /// <param name="minValue">minimum value of triangular distribution</param>
        /// <param name="modeValue">the peak value (mode) of triangular distribution</param>
        /// <param name="maxValue">maximum value of triangular distribution</param>
        /// <param name="randomNumberList">list of triangularly distributed random numbers</param>
        /// <returns></returns>
        public static List<double> GetListOfPDF(double minValue, double modeValue, double maxValue, List<double> randomNumberList)
        {
            var pdfList = new List<double>();

            for (int i = 0; i < randomNumberList.Count; i++)
            {
                var pdf = GetPDF(minValue, modeValue, maxValue, randomNumberList[i]);
                pdfList.Add(pdf);
            }

            return pdfList;
        }

        /// <summary>
        /// Returns a list of CDF values
        /// </summary>
        /// <param name="minValue">minimum value of triangular distribution</param>
        /// <param name="modeValue">the peak value (mode) of triangular distribution</param>
        /// <param name="maxValue">maximum value of triangular distribution</param>
        /// <param name="randomNumberList">list of triangularly distributed random numbers</param>
        /// <returns></returns>
        public static List<double> GetListOfCDF(double minValue, double modeValue, double maxValue, List<double> randomNumberList)
        {
            var cdfList = new List<double>();

            for (int i = 0; i < randomNumberList.Count; i++)
            {
                var cdf = GetCDF(minValue, modeValue, maxValue, randomNumberList[i]);
                cdfList.Add(cdf);
            }

            return cdfList;
        }

    }
}
