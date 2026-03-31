using UnityEngine;

namespace Study.OOP.Builder
{
    public class BlackSmith
    {
        public Sword GenerateSword(Grade grade)
        {
            SwordBuilder builder = new SwordBuilder();

            //3가지 기본 속성을 부여
            builder.SetGrade(grade)
                .SetName()
                .SetRandomAttackValue();

            switch (grade)
            {
                //매직 단계는 랜덤한 옵션 1개
                case Grade.Magic:
                    builder.SetRandomOption();
                    break;
                case Grade.Rare:
                    builder.SetRandomType()
                        .SetRandomOption()
                        .SetRandomOption();
                    break;
                case Grade.Unique:
                    builder.SetRandomType()
                        .SetRandomOption()
                        .SetRandomOption()
                        .SetRandomOption();
                    break;
                default:
                    break;
            }
            return builder.CreateSword();
        }
    }
}
