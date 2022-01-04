using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Creatures", menuName = "Creature/Create New Creature")]
public class MonsterBase : ScriptableObject
{
    [SerializeField]
    new string name;

    [SerializeField]
    CreatureType creatureType;
    public CreatureType MonsterType
    {
        get { return creatureType; }
    }

    [TextArea]
    [SerializeField]
    string description;

    [SerializeField]
    int maxHp;
    [SerializeField]
    int speed;

    [SerializeField]
    int physicalDefense;
    [SerializeField]
    int elementalDefense;
    [SerializeField]
    int magicDefense;
    [SerializeField]
    int physicalAttack;
    [SerializeField]
    int elementalAttack;
    [SerializeField]
    int magicAttack;

    [SerializeField]
    List<AvailableAtTimeOfDay> availableAtTimeOfDay;
    [SerializeField]
    List<AvailableDuringSeason> availableDuringSeason;

    [SerializeField]
    List<LearnableMoves> learnableMoves;

    public string Name
    {
        get { return name; }
    }
    public string Description
    {
        get { return description; }
    }
    public int Maxhp
    {
        get { return maxHp; }
    }
    public int Speed
    {
        get { return speed; }
    }
    public int PhysicalDefense
    {
        get { return physicalDefense; }
    }
    public int ElementalDefense
    {
        get { return elementalDefense; }
    }
    public int MagicDefense
    {
        get { return magicDefense; }
    }
    public int PhysicalAttack
    {
        get { return physicalAttack; }
    }
    public int ElementalAttack
    {
        get { return elementalAttack; }
    }
    public int MagicAttack
    {
        get { return magicAttack; }
    }
}


[System.Serializable]
    public class LearnableMoves
    {
        [SerializeField]
        MoveBase moveBase;
        [SerializeField]
        int level;

        public MoveBase Base
        {
            get { return moveBase; }
        }

        public int Level
        {
            get { return level; }
        }


    }



    public enum CreatureType
    {
        none,
        Physical,
        Elemental,
        Magic
    }

    public enum AvailableAtTimeOfDay
    {
        Morning,
        Day,
        Evening,
        Night
    }

    public enum AvailableDuringSeason
    {
        Spring,
        Summer,
        Fall,
        Winter
    }


