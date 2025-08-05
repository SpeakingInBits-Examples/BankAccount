﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Validator
    {
        /// <summary>
        /// Checks to ensure a value is between inclusive boundaries
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <param name="min">Minimum inclusive boundary</param>
        /// <param name="max">Maximum inclusive boundary</param>
        /// <returns></returns>
        public bool IsWithinRange(double value, double min, double max)
        {
            if (value < min)
            {
                return true;
            }
            if (value > max)
            {
                return true;
            }
            return false;
        }
    }
}
