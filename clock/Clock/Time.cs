using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clock
{
    class Time
    {
        //TODO: дефинирайте член-променливите, които пазят информацията за времето


        /// <summary>
        /// Задава текущото време с определени час/минути
        /// </summary>
        /// <param name="h"></param>
        /// <param name="min"></param>
        public void SetTime(int h, int min)
        { 
            
        }

        /// <summary>
        /// Връща компонента час от текущото време
        /// </summary>
        /// <returns></returns>
        public int GetHours()
        {
            return 0;
        }

        /// <summary>
        /// Връща минуите от текущото време
        /// </summary>
        /// <returns></returns>
        public int GetMinutes()
        {
            return 0;
        }

        /// <summary>
        /// Връща секундите на текущото време
        /// </summary>
        /// <returns></returns>
        public int GetSeconds()
        {
            return 0;
        }

        /// <summary>
        /// Добавя определени секунди към текущото време
        /// </summary>
        /// <param name="seconds">стойност на добавяните секунди</param>
        public void AddSeconds(int seconds)
        { 
            
        }

        /// <summary>
        /// Добавя определени минути към текущото време
        /// </summary>
        /// <param name="minutes"></param>
        public void AddMinutes(int minutes)
        { 
        
        }

        /// <summary>
        /// Добавя часове към текущото време
        /// </summary>
        /// <param name="hours"></param>
        public void AddHours(int hours)
        { 
            
        }


        public override bool Equals(object obj)
        {
            return false;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
