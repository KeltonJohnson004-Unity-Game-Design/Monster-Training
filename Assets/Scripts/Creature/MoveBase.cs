using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Moves", menuName = "Creature/Create New Move")]
public class MoveBase : ScriptableObject
{
    [SerializeField] new string name;

    [SerializeField] CreatureType moveType;
}
