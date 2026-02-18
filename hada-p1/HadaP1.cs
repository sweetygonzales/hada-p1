using System;

namespace hada_p1
{
    /// <summary>
    /// Class containing methods to convert between seconds and minutes.
    /// </summary>
    internal class HadaP1
    {
        /// <summary>
        /// Converts seconds to minutes.
        /// </summary>
        /// <param name="s">Number of seconds</param>
        /// <returns>Equivalent number of minutes</returns>
        /// <remarks>Returns 0 if the input value is 0.</remarks>
        public static double Seconds2Minutes(double s)
        {
            if (s == 0)
                return 0;

            return s / 60;
        }

        /// <summary>
        /// Converts minutes to seconds.
        /// </summary>
        /// <param name="m">Number of minutes</param>
        /// <returns>Equivalent number of seconds</returns>
        /// <remarks>Returns 0 if the input value is 0.</remarks>
        public static double Minutes2Seconds(double m)
        {
            if (m == 0)
                return 0;

            return m * 60;
        }
    }
}
