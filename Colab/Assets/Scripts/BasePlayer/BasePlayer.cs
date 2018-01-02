using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer
{

    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;

    private int stamina;        // health modifier
    private int endurance;      // energy modifier
    private int strength;       // physical damage modifier
    private int agility;        // order of action modifier (who attacks first)
    private int dexterity;      // dodge, block, modifier
    private int intellect;      // magic damage modifier
    private int resistance;     // magic resistance modifier

    private int gold;           // in game currency

    private int currentExp;
    private int requireExp;


    public string PlayerName { get; set; }
    public int PlayerLevel { get; set; }
    public BaseCharacterClass PlayerClass { get; set; }
    public int Stamina { get; set; }
    public int Endurance { get; set; }
    public int Strength { get; set; }
    public int Agility { get; set; }
    public int Dexterity { get; set; }
    public int Intellect { get; set; }
    public int Resistance { get; set; }
    public int CurrentExp { get; set; }
    public int Gold { get; set; }

}