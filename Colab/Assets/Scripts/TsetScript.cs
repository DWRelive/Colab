﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LoadInformation.LoadAllInformation();

        Debug.Log("Player Name: " + GameInformation.PlayerName);
       // Debug.Log("Player Class: " + GameInformation.PlayerClass.CharacterClassName);
        Debug.Log("Player Level: " + GameInformation.PlayerLevel);
        Debug.Log("Player Stregnth: " + GameInformation.Stength);
        Debug.Log("Player Speed: " + GameInformation.Agility);
        Debug.Log("Player Stamina: " + GameInformation.Stamina);
        Debug.Log("Player Dexterity: " + GameInformation.Dexterity);
        Debug.Log("Player Intellect: " + GameInformation.Intellect);

                
  
    }

    // Update is called once per frame
    void Update () {
		
	}
}
