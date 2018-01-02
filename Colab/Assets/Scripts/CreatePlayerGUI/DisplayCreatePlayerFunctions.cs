using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayCreatePlayerFunctions
{
    private int classSelection;
    private string[] classSelectionNames = new string[] { "Mage", "Warrior", "Assassin", "Rogue", "Paladin", "Warlock" };
    public void DisplaySelectClass()
    {
        // list of toggle buttons for the classes
        classSelection = GUI.SelectionGrid(new Rect(50,50,250,300), classSelection, classSelectionNames, 2);
        GUI.Label(new Rect(450, 50, 300, 300), FindClassDescription(classSelection));
        GUI.Label(new Rect(450, 100, 300, 300), FindClassStatValues(classSelection));
    }

    private string FindClassDescription(int classSelection)
    {
        if(classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseMageClass();
            return tempClass.CharacterClassDescription;
        }
        else if (classSelection == 1)
        {
            BaseCharacterClass tempClass = new BaseWarriorClass();
            return tempClass.CharacterClassDescription;
        }
        return "Coming Soon";

    }

    public string FindClassStatValues (int classSelection)
    {
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseMageClass();
            string tempStats = "Stamina " + tempClass.Stamina + "\n" + "Endurance " + tempClass.Endurance;
            return tempStats;
        }
        else if (classSelection == 1)
        {
            BaseCharacterClass tempClass = new BaseWarriorClass();
            string tempStats = "Stamina " + tempClass.Stamina + "\n" + "Endurance " + tempClass.Endurance;
            return tempStats;
        }
        return "No Stats to display";

    }
    
    public void DisplayStatAllocation()
    {
        // list of stats with a + and - buttons to manipulate stats
        // logic to make sure the player cannot add more stats than inteded
    }

    public void DisplayFinalSetup()
    {
        //name
        //gender
        //description (short bio)
        
    }

    public void DisplayMainItems()
    {
        GUI.Label(new Rect(Screen.width / 2, 20, 150, 100), "Choose Your Class");
    }
}