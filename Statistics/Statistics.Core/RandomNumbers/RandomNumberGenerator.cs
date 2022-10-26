﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Core.RandomNumbers
{
    public static class RandomNumberGenerator
    {
        private static readonly Random _random = new Random();
        private static readonly object _syncLock = new object();

        #region Random Numbers

        /// <summary>
        /// Returns a random double within a specifed range. For default method returns (0,1). 
        /// </summary>
        /// <returns></returns>
        public static double GetRandomDouble(double minValue = 0, double maxValue = 1)
        {
            var result = 0d;
            do
            {
                lock (_syncLock)
                    result = _random.NextDouble() * (maxValue - minValue) + minValue;
            } while (result <= 0);

            return result;
        }

        /// <summary>
        /// Returns a random integer within a specified range
        /// </summary>
        /// <param name="minValue">Minimum value of the specified range</param>
        /// <param name="maxValue">Maximum value of the specified range</param>
        /// <returns></returns>
        public static double GetRandomInteger(int minValue, int maxValue)
        {
            lock (_syncLock)
                return _random.Next(minValue, maxValue);
        }

        /// <summary>
        /// Returns random doubles suitable for continous uniformly distribution within a specified range. Minimum and Maximum values are not included.
        /// </summary>
        /// <param name="minValue">minimum value of uniform distribution</param>
        /// <param name="maxValue">maximum value of uniform distribution</param>
        /// <returns></returns>
        public static double GetUniformlyDistributedRandomNumber(double minValue, double maxValue)
        {
            return GetRandomDouble(minValue, maxValue);
        }

        /// <summary>
        /// Returns random doubles suitable for triangular distribution from a given random variate U 
        /// drawn from the uniform distribution in the interval (0, 1)
        /// </summary>
        /// <param name="minValue">minimum value of triangular distribution</param>
        /// <param name="modeValue">the peak value (mode) of triangular distribution</param>
        /// <param name="maxValue">maximum value of triangular distribution</param>
        /// <returns></returns>
        public static double GetTriangularDistributedRandomNumber(double minValue, double modeValue, double maxValue)
        {
            double randomNumber = 0.0;
            double randomDouble = GetRandomDouble();
            double function = (modeValue - minValue) / (maxValue - minValue);

            if (0 < randomDouble && randomDouble < function) randomNumber = minValue + Math.Sqrt(randomDouble * (maxValue - minValue) * (modeValue - minValue));
            else if (function <= randomDouble && randomDouble < 1) randomNumber = maxValue - Math.Sqrt((1 - randomDouble) * (maxValue - minValue) * (maxValue - modeValue));

            return randomNumber;
        }
     
        /// <summary>
        /// Returns random doubles suitable for normal (Gaussian) distribution using BoxMullerTransformation within specified range (min, max)
        /// </summary>
        /// <param name="mean">mean value</param>
        /// <param name="standardDeviation">standard deviation</param>
        /// <param name="min">Minimum value of the specified range</param>
        /// <param name="max">Maximum value of the specified range</param>
        /// <returns></returns>
        /// https://stackoverflow.com/questions/218060/random-gaussian-variables
        public static double GetNormalDistributedRandomNumber(double mean, double standardDeviation, double min = 0, double max = 1)
        {
            double randomNumber = 0;

            do
            {
                var normalRandom = GetNormalDistributedRandomNumber(0, 1);
                randomNumber = 11 + 1 * normalRandom;
            } while (randomNumber <= 8.0 && randomNumber >= 14.0);

            return randomNumber;
        }

        /// <summary>
        /// Returns random doubles suitable for skewed normal distribution. Method depends on Ermak & Naastrom, 1995 publication. 
        /// </summary>
        /// <param name="standardDeviation">standar deviation</param>
        /// <param name="skewness">skewness</param>
        /// <param name="dbIteration">iteration number for double block random number generation. 5-10 is a suitable range</param>
        /// <returns></returns>
        /// https://inis.iaea.org/collection/NCLCollectionStore/_Public/26/055/26055147.pdf Date:26 Oct 2022
        public static double GetSkewedNormalRandomNumber(double standardDeviation, double skewness, int dbIteration)
        {
            var randomNumber = 0d;
            var variance = Math.Pow(standardDeviation, 2);
            const double a = 2.236067977; // ---> Square root of 5
            const double b = 0.222222222;
            const double c = 243 / 32;
            double finalran, sumdbran = 0;
            double dbmom3, dbmean1, dbmean2, dbprob1, dbdelta1, dbdelta2, randomNumber1, randomNumber2, dbran, terma, termb;

            dbmom3 = Math.Sqrt(dbIteration) * skewness * Math.Pow(variance, 1.5);
            terma = b / variance;
            termb = Math.Sqrt(Math.Pow(dbmom3, 2) + c * Math.Pow(variance, 3));
            dbmean1 = terma * (dbmom3 - termb);
            dbmean2 = terma * (dbmom3 + termb);
            dbprob1 = dbmean2 / (2 * a * dbmean1 * (dbmean1 - dbmean2));
            dbdelta1 = -a * dbmean1;
            dbdelta2 = a * dbmean2;

            //Loop for summation of double block random numbers in each final random number
            for (int j = 0; j < dbIteration; j++)
            {
                randomNumber1 = RandomNumberGenerator.GetRandomDouble();
                randomNumber2 = RandomNumberGenerator.GetRandomDouble();

                if (randomNumber1 < (2 * dbdelta1 * dbprob1))
                    dbran = dbmean1 + (2 * dbdelta1 * (randomNumber2 - 0.5));
                else
                    dbran = dbmean2 + (2 * dbdelta2 * (randomNumber2 - 0.5));

                sumdbran = sumdbran + dbran;
            }

            //Calculate final random number
            finalran = sumdbran / Math.Sqrt(dbIteration);

            randomNumber = finalran;

            return randomNumber;
        }

        #endregion

        #region Random Numbers As List

        /// <summary>
        /// Returns a list of random doubles within a specified range
        /// </summary>
        /// <param name="iterationNumber">defines how many times you want the random double to be generated</param>
        /// <param name="minValue">Minimum value of the specified range</param>
        /// <param name="maxValue">Maximum value of the specified range</param>
        /// <returns></returns>
        public static List<double> GetListOfRandomDoubles(int iterationNumber, double minValue = 0, double maxValue = 1)
        {
            var randomNumberList = new List<double>();

            for (int i = 0; i < iterationNumber; i++)
            {
                var randomNumber = GetRandomDouble(minValue, maxValue);
                randomNumberList.Add(randomNumber);
            }

            return randomNumberList;
        }

        /// <summary>
        /// Returns a list of random integers within a specified range
        /// </summary>
        /// <param name="iterationNumber">defines how many times you want the random double to be generated</param>
        /// <param name="minValue">Minimum value of the specified range</param>
        /// <param name="maxValue">Maximum value of the specified range</param>
        /// <returns></returns>
        public static List<double> GetListOfRandomIntegers(int iterationNumber, int minValue, int maxValue)
        {
            var randomNumberList = new List<double>();

            for (int i = 0; i < iterationNumber; i++)
            {
                var randomNumber = GetRandomInteger(minValue, maxValue);
                randomNumberList.Add(randomNumber);
            }

            return randomNumberList;
        }

        /// <summary>
        /// Returns a list of random doubles suitable for continous uniform distribution within a specified range
        /// </summary>
        /// <param name="iterationNumber">defines how many times you want the random double to be generated</param>
        /// <param name="minValue">Minimum value of the specified range</param>
        /// <param name="maxValue">Maximum value of the specified range</param>
        /// <returns></returns>
        public static List<double> GetListOfUniformlyDistributedRandomNumbers(int iterationNumber, double minValue, double maxValue)
        {
            var randomNumberList = new List<double>();

            for (int i = 0; i < iterationNumber; i++)
            {
                var randomNumber = GetUniformlyDistributedRandomNumber(minValue, maxValue);
                randomNumberList.Add(randomNumber);
            }

            return randomNumberList;
        }

        /// <summary>
        /// Returns a list of random doubles suitable for triangular distribution within a specified range
        /// </summary>
        /// <param name="iterationNumber">defines how many times you want the random double to be generated</param>
        /// <param name="minValue">Minimum value of the specified range</param>
        /// <param name="maxValue">Maximum value of the specified range</param>
        /// <returns></returns>
        public static List<double> GetListOfTriangularDistributedRandomNumbers(int iterationNumber, double minValue, double modeValue, double maxValue)
        {
            var randomNumberList = new List<double>();

            for (int i = 0; i < iterationNumber; i++)
            {
                var randomNumber = GetTriangularDistributedRandomNumber(minValue, modeValue, maxValue);
                randomNumberList.Add(randomNumber);
            }

            return randomNumberList;
        }

        /// <summary>
        /// Returns a list of random doubles suitable for normal distribution within specified range.
        /// </summary>
        /// <param name="iterationNumber">defines how many times you want the random double to be generated</param>
        /// <param name="mean">mean value</param>
        /// <param name="standardDeviation">standard deviation</param>
        /// <param name="min">Minimum value of the specified range</param>
        /// <param name="max">Maximum value of the specified range</param>
        /// <returns></returns>
        public static List<double> GetListOfNormalDistributedRandomNumbers(int iterationNumber, double mean, double standardDeviation, double min = 0, double max = 1)
        {
            var randomNumberList = new List<double>();

            for (int i = 0; i < iterationNumber; i++)
            {
                var randomNumber = GetNormalDistributedRandomNumber(mean, standardDeviation, min, max);
                randomNumberList.Add(randomNumber);
            }

            return randomNumberList;
        }

        /// <summary>
        /// Returns a list of random doubles suitable for skewed normal distribution. Method depends on Ermak & Naastrom, 1995 publication.
        /// </summary>
        /// <param name="iterationNumber"></param>
        /// <param name="standardDeviation"></param>
        /// <param name="skewness"></param>
        /// <param name="dbIteration"></param>
        /// <returns></returns>
        public static List<double> GetListOfSkewedNormalRandomNumbers(int iterationNumber, double standardDeviation, double skewness, int dbIteration)
        {
            var randomNumberList = new List<double>();

            for (int i = 0; i < iterationNumber; i++)
            {
                var randomNumber = GetSkewedNormalRandomNumber(standardDeviation, skewness, dbIteration);
                randomNumberList.Add(randomNumber);
            }

            return randomNumberList;
        }

        #endregion

    }
}