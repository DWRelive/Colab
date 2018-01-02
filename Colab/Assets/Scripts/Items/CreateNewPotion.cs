using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CreateNewPotion : MonoBehaviour
{

    private BasePotion newPotion;
    private string[] itemNames = new string[4] { "Common", "Magical", "Unique", "Legendary" };

    // Use this for initialization
    void Start(){

        CreatePotion();
        Debug.Log(newPotion.ItemName);
        Debug.Log(newPotion.ItemDescription);
        Debug.Log(newPotion.ItemID.ToString());
        Debug.Log(newPotion.PotionType);

    }

    private void CreatePotion()
    {
        newPotion = new BasePotion();
        newPotion.ItemName = itemNames[Random.Range(0, 3)] + " Potion";
        newPotion.ItemDescription = "Potion to help you recover";
        newPotion.ItemID = Random.Range(1, 101);
        ChoosePotionType();

    }
    
    private void ChoosePotionType()
    {
        int randomTemp = Random.Range(0, 7);
        if (randomTemp == 0)
        {
            newPotion.PotionType = BasePotion.PotionTypes.STRENGTH;
        }
        else if (randomTemp == 1)
        {
            newPotion.PotionType = BasePotion.PotionTypes.STAMINA;
        }
        else if (randomTemp == 2)
        {
            newPotion.PotionType = BasePotion.PotionTypes.DEXITERITY;
        }
        else if (randomTemp == 3)
        {
            newPotion.PotionType = BasePotion.PotionTypes.AGILITY;
        }
        else if (randomTemp == 4)
        {
            newPotion.PotionType = BasePotion.PotionTypes.INTELECT;
        }
        else if (randomTemp == 5)
        {
            newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
        }
        else if (randomTemp == 6)
        {
            newPotion.PotionType = BasePotion.PotionTypes.ENERGY;
        }
    }


}

