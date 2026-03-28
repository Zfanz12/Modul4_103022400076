using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400076
{
    internal class MesinKopi
    {
        public enum State
        {
            OFF,
            STANDBY,
            BREWING,
            MAINTENANCE
        }
        private State currentState = State.OFF;
        public State GetState() => currentState;

        public void TurnOn()
        {
            if (currentState == State.OFF)
            {
                Console.WriteLine("Mesin Off berubah menjadi Standby");
                currentState = State.STANDBY;
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
        public void TurnOff()
        {
            if (currentState == State.STANDBY)
            {
                Console.WriteLine("Mesin Standby Berubah menjadi Off");
                currentState = State.OFF;
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
        public void StartBrewing()
        {
            if (currentState == State.STANDBY)
            {
                Console.WriteLine("Mesin Standby berubah menjadi Brewing");
                currentState = State.BREWING;
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
        public void FinishBrewing()
        {
            if (currentState == State.BREWING)
            {
                Console.WriteLine("Mesin Brewing berubha menjadi standby");
                currentState = State.STANDBY;
            }
            else
            {
                Console.WriteLine("Perubahan state tiadk valid");
            }
        }
        public void StartMaintenance()
        {
            if (currentState == State.STANDBY)
            {
                Console.WriteLine("Mesin Standby berubah menjadi Maintenance");
                currentState = State.MAINTENANCE;
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }

        public void EndMaintenance()
        {
            if (currentState == State.MAINTENANCE)
            {
                Console.WriteLine("Mesin Maintenance berubah menjadi Standby");
                currentState = State.STANDBY;
            }
            else
            {
                Console.WriteLine("Perubahan state tidak valid");
            }
        }
    }
}
