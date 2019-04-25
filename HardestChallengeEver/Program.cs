using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HardestChallengeEver
{
    class Program
    {
        static void Main(string[] args)
        {
            var notMain = new MyNotMainStartingThing();
            notMain.NotMainMethod();
        }
    }
}
