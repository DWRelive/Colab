using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass  {


    private string characterClassName;
    private string characterClassDescription;

    //Stats for characters

    private int stamina;
    private int strength;
    private int agility;
    private int intellect;
    private int dexterity;
    private int endurance;
    private int resistance;


    public string CharacterClassName { get; set; }
    public string CharacterClassDescription { get; set; }
    public int Stamina { get; set; }
    public int Strength { get; set; }
    public int Intellect { get; set; }
    public int Agility { get; set; }
    public int Dexterity { get; set; }
    public int Endurance { get; set; }
    public int Resistance { get; set; }


}

