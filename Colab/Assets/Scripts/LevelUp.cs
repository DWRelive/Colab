using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp
{
    public int MaxPlayerLevel = 100;

    public void LevelUpCharacter()
    {
        //check if current exp > than required
        if(GameInformation.CurrentExp > GameInformation.RequiredExp)
        {
            GameInformation.CurrentExp -= GameInformation.RequiredExp;
        }else
        {
            GameInformation.CurrentExp = 0;
        }
        if(GameInformation.PlayerLevel < MaxPlayerLevel)
        {
            GameInformation.PlayerLevel += 1;
        }
        else
        {
            GameInformation.PlayerLevel = MaxPlayerLevel;
        }

        //give player stat points
        //granted items
        //new move/ability
      
        //determine next required ammount of exp
        DetermineRequiredExp();

    }

    private void DetermineRequiredExp()
    {
        int temp = (GameInformation.PlayerLevel * 1000) + 250;
        GameInformation.RequiredExp = temp;
    }

    //increase money (Video 20 at 14:55 for complex script of money + exp
  //  private void DetermineMoneyToGive()
    //{
      //  if(GameInformation.PlayerClass<= 10)
      //  {
      //      //give a certain ammount of gold
      //  }
    //}
}