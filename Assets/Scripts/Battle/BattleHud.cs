using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHud : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text levelText;
    [SerializeField] HPBar Health;

    public void SetData(Monster monster)
    {
            nameText.text = monster.Base.Name;
            levelText.text = "Lvl " + monster.Level;
            Health.SetHP((float)monster.HP / monster.MaxHp);
    }

}
