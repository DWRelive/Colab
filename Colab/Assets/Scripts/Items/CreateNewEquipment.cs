using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewEquipment : MonoBehaviour {
  
    private BaseEquipment newEquipment;
    private string[] itemNames = new string[4] { "Common", "Magical", "Unique", "Legendary" };
    private string[] itemDescription = new string[4] { "Worn", "New", "Pristine", "Perfect" };

    // Use this for initialization
    void Start() {
        //creates and logs the stats of the new item
        CreateEquipment();
        Debug.Log(newEquipment.ItemName);
        Debug.Log(newEquipment.ItemDescription);
        Debug.Log(newEquipment.ItemID.ToString());
        Debug.Log(newEquipment.EquipmentType);
        Debug.Log(newEquipment.Stamina.ToString());
        Debug.Log(newEquipment.Strength.ToString());

    }

    //creates the item
    private void CreateEquipment()
    {
        newEquipment = new BaseEquipment();

        //assign name to the weapon
        newEquipment.ItemName = itemNames[Random.Range(0, 3)] + " Item";
        
        //weapon id that is random
        newEquipment.ItemID = Random.Range(1, 101);
        
        //choose type of weapon
        ChooseItemType();
        newEquipment.ItemDescription = itemDescription[Random.Range(0, itemDescription.Length)];
       
        //stats to be generated for item
        newEquipment.Strength = Random.Range(1, 11);
        newEquipment.Agility = Random.Range(1, 11);
        newEquipment.Stamina = Random.Range(1, 11);
        newEquipment.Dexterity = Random.Range(1, 11);
        newEquipment.Intellect = Random.Range(1, 11);
        newEquipment.Endurance = Random.Range(1, 11);
        newEquipment.Resistance = Random.Range(1, 11);

    }


    //Randomly chooses an item type for the character
    private void ChooseItemType()
    {
        int randomTemp = Random.Range(1, 10);
        if (randomTemp == 1)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
        }
        else if (randomTemp == 2)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.EARRINGS;
        }
        else if (randomTemp == 3)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
        }
        else if (randomTemp == 4)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HANDS;
        }
        else if (randomTemp == 5)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
        }
        else if (randomTemp == 6)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
        }
        else if (randomTemp == 7)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
        }
        else if (randomTemp == 8)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RING;
        }
        else if (randomTemp == 9)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERS;
        }
    }

    // Update is called once per frame
    void Update() {

    }
}