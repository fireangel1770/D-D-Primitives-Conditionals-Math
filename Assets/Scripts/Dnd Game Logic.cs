using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DndGameLogic : MonoBehaviour
{

    [SerializeField] public string nameOfCharacter = "";
    [SerializeField] public int proficiencyBonus;
    [SerializeField] public bool finesseWeapon = false;
    [SerializeField]
    [Range(1, 20)] public int str = 10;
    [SerializeField]
    [Range(1, 20)] public int dex = 10;
    [SerializeField]
    [Range(-5,5)] public int strMod;
    [SerializeField]
    [Range(-5, 5)] public int dexMod;


    void Start()
    {
        int enemyAC = Random.Range(10, 20);
        int enemyHP = Random.Range(10, 20);
        int roll = Random.Range(1, 20);
        int hitMod;
        Debug.Log(nameOfCharacter + "You find an enemy!");
        Debug.Log("Enemy HP: " + enemyHP);
        Debug.Log("Enemy AC: " + enemyAC);
        Debug.Log("Roll Attack: " + "Nat " + roll);
        if (dex > str && !finesseWeapon)
        {
            Debug.Log("+Dex and Proficiency Bonus");
            hitMod = dex + proficiencyBonus + roll;
            Debug.Log("That Makes " + hitMod);
        }
        else
        {
            Debug.Log("+Str and Proficiency Bonus");
            hitMod = str + proficiencyBonus + roll;
            Debug.Log("That Makes " + hitMod);
        }
        if (hitMod > enemyAC)
        {
            Debug.Log("It's a Hit!... and hes dead? but he had " + enemyHP + " HP Oh well...");
        }
        else
        {
            Debug.Log("It's a Miss! He swings and you die... Wait but it was only the first turn? Oh well...");
        }

    }
}

