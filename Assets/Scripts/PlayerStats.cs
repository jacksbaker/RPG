using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int currentLevel;

    public int currentExp;

    public int[] toLevelUp;

    public int[] hpLevels;
    public int[] attackLevels;
    public int[] defenceLevels;

    public int currentHP;
    public int currentAttack;
    public int currentDefence;



    // Start is called before the first frame update
    void Start()
    {
        currentHP = hpLevels[1];
        currentAttack = attackLevels[1];
        currentDefence = defenceLevels[1];
    }

    // Update is called once per frame
    void Update()
    {
        if(currentExp >= toLevelUp[currentLevel])
        {
            //currentLevel++;
            LevelUp();
        }
    }

    public void AddExperince(int experienceToAdd)
    {
        currentExp += experienceToAdd;
    }
    
    public void LevelUp()
    {
        currentLevel++;
        currentHP = hpLevels[currentLevel];
        currentAttack = attackLevels[currentLevel];
        currentDefence = defenceLevels[currentLevel];
    }
}
