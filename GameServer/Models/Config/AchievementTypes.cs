namespace GameServer.Models.Config
{
    public static class AchievementTypes
    {
        public const int EnteredTop10RaceXp = 1;
        public const int EnteredTop25RaceXp = 2;
        public const int EnteredTop100RaceXp = 3;
        public const int EnteredTop1000RaceXp = 4;
        public const int FellOutOfTop10RaceXp = 5;
        public const int FellOutOfTop25RaceXp = 6;
        public const int FellOutOfTop100RaceXp = 7;
        public const int FellOutOfTop1000RaceXp = 8;

        public const int RaceXp1000000 = 9;
        public const int RaceXp10000 = 10;
        public const int RaceXp100000 = 11;

        public const int CreationDownloads5 = 12;
        public const int CreationDownloads10 = 13;
        public const int CreationDownloads25 = 14;
        public const int CreationDownloads100 = 15;
        public const int CreationDownloads500 = 16;

        public const int CreationCreateXp100 = 17;
        public const int CreationCreateXp1000 = 18;
        public const int CreationCreateXp10000 = 19;

        public const int HottestWinStreak = 20;

        // trophy Modnation Superstar
        public const int LevelUp = 21;

        public const int SlotsReward1000CreateXp = 22;
        public const int SlotsReward5000CreateXp = 23;
        public const int SlotsReward10000CreateXp = 24;
        public const int SlotsReward100000CreateXp = 25;
        public const int SlotsReward250000CreateXp = 26;     // trophy Star Creator

        // these don't send an alert but adding them for posterity
        public const int SharingKartsTrophy = 27;            // trophy Sharing Karts
        public const int SharingModsTrophy = 28;             // trophy Sharing Mods
        public const int SharingSplinesTrophy = 29;          // trophy Sharing Splines

        // trophy Flaming Hot!
        public const int HotLapTop1 = 30;
        public const int HotLapTop10 = 31;
        public const int HotLapTop10Percent = 32;
    }
}