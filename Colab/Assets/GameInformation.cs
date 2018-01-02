using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public static BaseEquipment EquipmentOne { get; set; }

    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }

    public static int Stength { get; set; }
    public static int Agility { get; set; }
    public static int Stamina { get; set; }
    public static int Dexterity { get; set; }
    public static int Intellect { get; set; }
    public static int Endurance { get; set; }
    public static int Resistance { get; set; }

    public static int Gold { get; set; }
    public static int CurrentExp { get; set; }
    public static int RequiredExp { get; set; }


}