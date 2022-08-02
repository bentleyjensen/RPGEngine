using System;
namespace RPGEngine
{
    public class BaseCharacter
    {
        public BaseCharacter(int defaultNum)
        {
            statistics = new BaseStatistics(defaultNum);
        }

        public BaseStatistics statistics { get; set; }

    }
}

