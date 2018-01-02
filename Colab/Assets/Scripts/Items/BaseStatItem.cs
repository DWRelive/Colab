using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class BaseStatItem : BaseItem
{

    private int stamina;
    private int strength;
    private int agility;
    private int dexterity;
    private int intellect;
    private int endurance;
    private int resistance;

    public int Stamina { get; set; }
    public int Strength { get; set; }
    public int Intellect { get ; set; }
    public int Agility { get; set; }
    public int Dexterity { get; set; }
    public int Endurance { get; set; }
    public int Resistance { get; set; }
}


