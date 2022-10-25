using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Distributions
{
    public static class RandomNumberGenerator
    {
        private static readonly Random _random = new Random();
        private static readonly object _syncLock = new object();

        /// <summary>
        /// Returns a random double that is greater than 0 and less than 1 (0, 1). Differs from .NET Random() method which return [0,1). 
        /// </summary>
        /// <returns></returns>
        public static double GetRandomDouble()
        {
            var result = 0d;
            do
            {
                lock (_syncLock)
                    result = _random.NextDouble();
            } while (result <= 0);

            return result;
        }

        /// <summary>
        /// Returns a random double that is within a specified range
        /// </summary>
        /// <param name="minValue">Minimum value of the specified range</param>
        /// <param name="maxValue">Maximum value of the specified range</param>
        /// <returns></returns>
        public static double GetRandomDouble(double minValue, double maxValue)
        {
            lock (_syncLock)
                return _random.NextDouble() * (maxValue - minValue) + minValue;
        }

        /// <summary>
        /// Returns a random integer that is within a specified range
        /// </summary>
        /// <param name="minValue">Minimum value of the specified range</param>
        /// <param name="maxValue">Maximum value of the specified range</param>
        /// <returns></returns>
        public static double GetRandomInteger(int minValue, int maxValue)
        {
            lock (_syncLock)
                return _random.Next(minValue, maxValue);
        }

    }
}
