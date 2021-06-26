namespace IBS.Classes
{
    public static class Properties
    {
        public static int PlyrLevel;
        public static int PlyrAttack;
        public static int PlyrDefese;
        public static int PlyrMagicAttack;
        public static int PlyrMagicDefense;
        public static int PlyrSpeed;
        public static int PlyrHpBase;
        public static double PlyrHpFac;
        public static int PlyrExpBase;
        public static double PlyrExpFac;
        public static int PlyrPoints;
        public static int PlyrMaxPoints;
        public static int PlyrBaseDmg;
        public static int PlyrScalingStat;
        public static double PlyrScalingFac;
        public static double PlyrCriticalFac;
        public static bool Balanced;
        public static bool Strong;
        public static bool Tanker;

        public static double EnyAttack;
        public static double EnyDefese;
        public static double EnyMagicAttack;
        public static double EnyMagicDefense;
        public static double EnySpeed;
        public static double EnyHpFac;
        public static int EnyBaseDmg;
        public static int EnyScalingStat;
        public static double EnyScalingFac;
        public static double EnyCriticalFac;

        public static string MinTrueFormula = "((BaseDamage + (ScalingStat * ScaleFactor))) * 0.975";
        public static string MaxTrueFormula = "((BaseDamage + (ScalingStat * ScaleFactor))) * 1.025";
        public static string MinRealFormula = "(((BaseDamage + (ScalingStat * ScaleFactor))) * 0.975) * (100 / (100 + V_Defense))";
        public static string MaxRealFormula = "(((BaseDamage + (ScalingStat * ScaleFactor))) * 1.025) * (100 / (100 + V_Defense))";
    }
}
