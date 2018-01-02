using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation {

    public static void LoadAllInformation()
    {
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInformation.Stength = PlayerPrefs.GetInt("STENGTH");
        GameInformation.Agility = PlayerPrefs.GetInt("SPEED");
        GameInformation.Stamina = PlayerPrefs.GetInt("STAMINA");
        GameInformation.Dexterity = PlayerPrefs.GetInt("DEXTERITY");
        GameInformation.Intellect = PlayerPrefs.GetInt("INTELECT");
        GameInformation.Endurance = PlayerPrefs.GetInt("ENDURANCE");
        GameInformation.Resistance = PlayerPrefs.GetInt("RESISTANCE");
        GameInformation.Gold = PlayerPrefs.GetInt("GOLD");


        if (PlayerPrefs.GetString("EQUIPMENTITEM1") != null)
        {
            GameInformation.EquipmentOne = (BaseEquipment) PPSerialization.Load("EQUIPMENTITEM1");
        }
    }
}
