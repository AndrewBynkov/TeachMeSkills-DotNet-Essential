using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task14
{
    public class Player : IRecodable, IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Play film");
        }

        public void Record()
        {
            Console.WriteLine("Record film");
        }

        public void Pause()
        {
            Console.WriteLine("Pause player");
        }

        public void Stop()
        {
            Console.WriteLine("Stop play");
        }

        public void Stop(string input)
        {
            Console.WriteLine("Stop record");
        }

        public void Pause(string input)
        {
            Console.WriteLine("Pause record");
        }
    }
}