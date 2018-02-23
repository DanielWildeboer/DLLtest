using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.ComponentModel;

namespace AD_DLL
{
    public class HighPerformanceTimer
    {
        // de benodigde DLL's importeren
        [DllImport("Kernel32.DLL")]
        private static extern bool QueryPerformanceCounter(out long PerformanceCounter);

        [DllImport("Kernel32.DLL")]
        private static extern bool QueryPerformanceFrequency(out long TimeFrequency);


        //fields initialiseren
        private static long startTime = 0;
        private static long stopTime = 0;
        private static long frequency = 0;


        public HighPerformanceTimer()
        {
            if (QueryPerformanceFrequency(out frequency) == false)
            {
                // Frequency not supported
                throw new Win32Exception();
            }
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            Process.GetCurrentProcess().ProcessorAffinity = (IntPtr)0x0004;
        }
        

        public static void startTimer()
        {

            //garbage collection
            GC.Collect();

            //wachten todat garbage is opgehaald zodat er niks tussendoor kan runnen
            GC.WaitForPendingFinalizers();

            Thread.Sleep(0);

            //start de queryperformance counter
            QueryPerformanceCounter(out startTime);

        }
        public static void stopTimer()
        {
            //stop de queryperformance counter
            QueryPerformanceCounter(out stopTime);

        }
        public static String duration()
        {
            //frequency ophalen
            QueryPerformanceFrequency(out frequency);

            //berekening voor de tijdsduur
            Decimal timeMeasured = (stopTime - startTime) / (Decimal)frequency;

            //de string die we returnen om te gebruiken in de UI
            return timeMeasured + " seconds";

        }
        
    }
}
