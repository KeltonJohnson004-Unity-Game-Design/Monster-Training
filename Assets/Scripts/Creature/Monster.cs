using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Monster : MonoBehaviour
{
    [SerializeField] MonsterBase _base;
    public MonsterBase Base { get { return _base; } }

    public int Level { get; set; }

    public int HP { get; set; }

    public Monster(int mLevel, int maxHp)
    {
        Level = mLevel;
        HP = maxHp;
    }

    public int physicalattack
    {
        get { return Mathf.FloorToInt((_base.PhysicalAttack * Level) / 100f) + 5; }
    }
    public int elementalattack
    {
        get { return Mathf.FloorToInt((_base.ElementalAttack * Level) / 100f) + 5; }
    }
    public int magicattack
    {
        get { return Mathf.FloorToInt((_base.MagicAttack * Level) / 100f) + 5; }
    }
    public int physicaldefense
    {
        get { return Mathf.FloorToInt((_base.PhysicalDefense * Level) / 100f) + 5; }
    }
    public int elementaldefense
    {
        get { return Mathf.FloorToInt((_base.PhysicalDefense * Level) / 100f) + 5; }
    }
    public int magicdefense
    {
        get { return Mathf.FloorToInt((_base.MagicDefense * Level) / 100f) + 5; }
    }
    public int speed
    {
        get { return Mathf.FloorToInt((_base.Speed * Level) / 100f) + 5; }
    }
    public int MaxHp
    {
        get { return Mathf.FloorToInt((_base.Maxhp * Level) / 100f) + 10; }
    }

}

