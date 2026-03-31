using UnityEngine;

namespace Study.OOP.Builder
{
    public class StudyBuilder : MonoBehaviour
    {
        //Builder Pattern
        //객체를 생성하는 과정과 객체의 실제 형태를 완전히 분리하여, 동일한 생성 절차에서
        //서로 다른 결과물을 만들 수 있게 하는 생성 패턴의 한 종류
        //객체를 생성할 때 선택적인 매개변수가 많아지면 생성자나 init() 메서드의 종류가 증가함.
        //Builder패턴은 이런 복잡성을 보완하기 위해 활요을 합니다
        //재귀적 반환형태로 만들어서 코드를 마치 영어 문장처럼 술술 읽히게 만드는게 핵심
        // - 절차적 맵 생성기
        // - 플레이 몬스터 생성기
        // - 플레이 캐릭터 생성기
        // - 여하튼 절차적인 객체 생성등에 활용이 가능하다

        private void Awake()
        {
            #region 소드
            //Sword newSwordA 
            //    = new SwordBuilder()
            //    .SetRandomAttackValue()
            //    .CreateSword();
            //Sword newSwordB 
            //    = new SwordBuilder()
            //    .SetRandomGrade()
            //    .SetRandomAttackValue()
            //    .CreateSword();
            //Sword newSwordC = 
            //    new SwordBuilder()
            //    .SetRandomGrade()
            //    .SetRandomAttackValue()
            //    .SetRandomType()
            //    .SetRandomOption()
            //    .SetName()
            //    .CreateSword();

            //Debug.Log(newSwordA.ToString());
            //Debug.Log(newSwordB.ToString());
            //Debug.Log(newSwordC.ToString());
            #endregion 

            BlackSmith blackSmith = new BlackSmith();
            for (int i = 0; i < 1000; i++)
            {
                Grade randGrade = (Grade)Random.Range(0, 4);
                var sword = blackSmith.GenerateSword(randGrade);
            }
        }
    }
}