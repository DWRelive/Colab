using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IncreaseExperience {

    private static int expToGive;
    private static LevelUp levelUpScript = new LevelUp();

    public static void AddExperience() // adds experience from battle
    {
        expToGive = GameInformation.PlayerLevel * 100;
        GameInformation.CurrentExp += expToGive;
        CheckIfPlayerLeveled();
        Debug.Log(expToGive);
        
    }

    public static void AddExplorationExperience() //exploration experience of a character

    {
        expToGive = GameInformation.PlayerLevel * 10;
        GameInformation.CurrentExp += expToGive;
        Debug.Log(expToGive);
    }

    private static void CheckIfPlayerLeveled()  //check players current level and if it increased
    {
        if (GameInformation.CurrentExp >= GameInformation.RequiredExp) //Character level up
        {
            //Level Up Script
            levelUpScript.LevelUpCharacter();
        }
    }

}