using System;

namespace ClassLibrary
{
    /// <summary>
    /// This Class represent a basic Train
    /// </summary>
    public class Train
    {
        private bool _isStartedEngine;


        /// <summary>
        /// Start train`s engines
        /// </summary>
        /// <returns>
        /// True if engines can be started, otherwise false
        /// </returns>
        public bool StartEngines()
        {
            if (_isStartedEngine)
            {
                Console.Write("The engines are already running");
                return false;
            }
            _isStartedEngine = true;
            Console.Write("Engines on");
            return true;
        }
        
        /// <summary>
        /// Stop train`s engines
        /// </summary>
        /// <returns>
        /// True if engines can be stopped, otherwise false
        /// </returns>
        public bool StopEngines()
        {
            if (_isStartedEngine)
            {
                _isStartedEngine = false;
                Console.Write("Engines off");
                return true;
            }
            Console.Write("The engines are already stopped");
            return _isStartedEngine;
        }
        
        
    }
}