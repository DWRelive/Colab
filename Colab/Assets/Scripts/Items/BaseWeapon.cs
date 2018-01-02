using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseStatItem {        //BaseWeapon <- BaseStatItem <- BaseItem

    public enum WeaponTypes
    {
        SWORD,
        STAFF,
        DAGGER,
        BOW,
        SHIELD,
        POLEARM
    }

    private WeaponTypes weaponType;
    private int spellEffectID;

    public WeaponTypes WeaponType { get; set; }
    
    
    public int SpellEffectID { get; set; }

}
