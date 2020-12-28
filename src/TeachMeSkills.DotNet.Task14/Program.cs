using System;

namespace TeachMeSkills.DotNet.Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            var userInp = Console.ReadLine();

            if(userInp.Contains("StopRec"))
            {
                player.Stop(userInp);
            }
            else if (userInp.Contains("Stop"))
            {
                player.Stop();
            }
            else if (userInp.Contains("Play"))
            {
                player.Play();
            }
            else if (userInp.Contains("PauseRec"))
            {
                player.Pause(userInp);
            }
            else if (userInp.Contains("Pause"))
            {
                player.Pause();
            }

        }
    }
}
