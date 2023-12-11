﻿using DetRigtigeSemesterProjekt.Models;

namespace DetRigtigeSemesterProjekt.MockData
{
    public class MockHundeEjer
    {
        private static List<HundeEjer> _hundeEjer = new List<HundeEjer>()
        {
           new HundeEjer(50, "Holmevej 43", "Birgitte", 45876352, "birgitte01@gmail.com"),
           new HundeEjer(51, "Blommehaven 21", "Jens", 45782154, "JensDenSeje@gmail.com"),
           new HundeEjer(52, "Æbleale 89", "Poul", 47859632, "Poul123@gmail.com"),
           new HundeEjer(53, "Venusvej 12", "Rikke", 74859663, "RejeRikke@gmail.com"),
        };

        public static List<HundeEjer> GetMockHundeEjer()
        {
            return _hundeEjer;
        }
    }
}
