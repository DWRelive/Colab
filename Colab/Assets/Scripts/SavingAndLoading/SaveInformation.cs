using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation {

    public static void SaveAllInformation()
    {
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
        PlayerPrefs.SetInt("STENGTH", GameInformation.Stength);
        PlayerPrefs.SetInt("AGILITY", GameInformation.Agility);
        PlayerPrefs.SetInt("STAMINA", GameInformation.Stamina);
        PlayerPrefs.SetInt("DEXTERITY", GameInformation.Dexterity);
        PlayerPrefs.SetInt("INTELECT", GameInformation.Intellect);
        PlayerPrefs.SetInt("ENDURANCE", GameInformation.Endurance);
        PlayerPrefs.SetInt("RESISTANCE", GameInformation.Resistance);
        PlayerPrefs.SetInt("GOLD", GameInformation.Gold);


        if (GameInformation.EquipmentOne != null)
        {
           PPSerialization.Save("EQUIPMENTITEM1", GameInformation.EquipmentOne);
        }
        

        Debug.Log("Saved all info");

    }

}
