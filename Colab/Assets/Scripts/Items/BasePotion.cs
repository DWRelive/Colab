using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePotion : BaseStatItem {

    public enum PotionTypes
    {
        STRENGTH,
        AGILITY,
        STAMINA,
        DEXITERITY,
        INTELECT,
        HEALTH,
        ENERGY
        
    }

    private PotionTypes potionType;
    public int spellEffectID;

    public PotionTypes PotionType { get; set; }


    public int SpellEffectID { get; set; }

}
