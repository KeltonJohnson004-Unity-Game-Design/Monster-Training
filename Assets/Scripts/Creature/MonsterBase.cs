using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Creatures", menuName = "Creature/Create New Creature")]
public class MonsterBase : ScriptableObject
{
    [SerializeField] new string name;

    [SerializeField] CreatureType creatureType;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] int maxHp;
    [SerializeField] int speed;

    [SerializeField] int physicalDefense;
    [SerializeField] int elementalDefense;
    [SerializeField] int magicDefense;
    [SerializeField] int physicalAttack;
    [SerializeField] int elementalAttack;
    [SerializeField] int magicAttack;

    [SerializeField] List<AvailableAtTimeOfDay> availableAtTimeOfDay;
    [SerializeField] List<AvailableDuringSeason> availableDuringSeason;

    [SerializeField] List<LearnableMoves> learnableMoves;

}


[System.Serializable]
public class LearnableMoves
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

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
