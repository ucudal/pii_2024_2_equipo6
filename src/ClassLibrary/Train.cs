namespace ClassLibrary
{
    using System;

    /// <summary>
    /// This Class represent a basic Train
    /// </summary>
    public class Train
    {
        public bool IsStartedEngine { get; private set; }

        /// <summary>
        /// Start train`s engines.
        /// </summary>
        /// <returns>
        /// True if engines can be started, otherwise false.
        /// </returns>
        public bool StartEngines()
        {
            if (this.IsStartedEngine)
            {
                Console.Write("The engines are already running");
                return false;
            }

            this.IsStartedEngine = true;
            Console.Write("Engines on");
            return true;
        }

        /// <summary>
        /// Stop train`s engines.
        /// </summary>
        /// <returns>
        /// True if engines can be stopped, otherwise false.
        /// </returns>
        public bool StopEngines()
        {
            if (this.IsStartedEngine)
            {
                this.IsStartedEngine = false;
                Console.Write("Engines off");
                return true;
            }

            Console.Write("The engines are already stopped");
            return this.IsStartedEngine;
        }
    }
}