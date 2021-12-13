using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    public MonsterBase Base { get; set; }

    public int Level { get; set; }

    public int HP { get; set; }

    public monster(MonsterBase mBase, int mLevel)
    {
        Base = mBase;
        Level = mLevel;
        HP = maxHp;
    }
}
//    public int physicalattack
//    {
//        get { return mathf.floortoint((_base.physicalattack * level) / 100f) + 5; }
//    }
//    public int elementalattack
//    {
//        get { return mathf.floortoint((_base.elementalattack * level) / 100f) + 5; }
//    }
//    public int magicattack
//    {
//        get { return mathf.floortoint((_base.magicattack * level) / 100f) + 5; }
//    }
//    public int physicaldefense
//    {
//        get { return mathf.floortoint((_base.physicaldefense * level) / 100f) + 5; }
//    }
//    public int elementaldefense
//    {
//        get { return mathf.floortoint((_base.physicaldefense * level) / 100f) + 5; }
//    }
//    public int magicdefense
//    {
//        get { return mathf.floortoint((_base.magicdefense * level) / 100f) + 5; }
//    }
//    public int speed
//    {
//        get { return mathf.floortoint((_base.speed * level) / 100f) + 5; }
//    }
//    public int maxhp
//    {
//        get { return mathf.floortoint((_base.maxhp * level) / 100f) + 10; }
//    }
//}
