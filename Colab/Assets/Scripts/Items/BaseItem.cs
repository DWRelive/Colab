﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseItem  {

    private string itemName;
    private string itemDescription;
    private int itemID;
    public enum ItemTypes {
        EQUIPMENT,
        WEAPON,
        SCROLL,
        POTION,
        CHEST

    }

    private ItemTypes itemType;

    public string ItemName { get; set; }
    public string ItemDescription { get; set; }
    public int ItemID { get; set; }
    public ItemTypes Itemtype { get; set; }


}


