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
        public string Alignment {
            get {
                return Alignment;
            }
            set {
                string[] Alignments =
                {
                    "LawfulGood",
                    "NeutralGood",
                    "ChaoticGood",
                    "LawfulNeutral",
                    "TrueNeutral",
                    "ChaoticNeutral",
                    "LawfulEvil",
                    "NeutralEvil",
                    "ChaoticEvil"
                };
                if (Alignments.Contains(value))
                {
                    Alignment = value;
                }
            }
        }

    }
}

