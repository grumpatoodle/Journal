using System;
using System.Collections.Generic;
using System.Text;

namespace HardestChallengeEver
{
    public class UserInfo
    {
        public string Name { get; set; }
    }

    public class Goals
    {
        public string Goal { get; set; }
    }

    public class Entry
    {
        public string NewEntry { get; set; }
        public string EditEntry { get; set; }
        public string PreviousEntry { get; set; }
        public string SaveEntry { get; set; }
    }

    public class Finish
    {
        public void EndToday;
    }
}
