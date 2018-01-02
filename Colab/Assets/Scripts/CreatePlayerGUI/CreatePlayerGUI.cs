using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayerGUI : MonoBehaviour {

    public enum CreateAPlayerStates
    {
        SELECTCLASS,    // display all class types
        STATALLOCATION, // allocate stats for players
        FINALSETUP //add name and misc items
    }

    private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions();
    public static CreateAPlayerStates currentState;

	// Use this for initialization
	void Start () {
        currentState = CreateAPlayerStates.SELECTCLASS;
        
	}
	
	// Update is called once per frame
	void Update () {
        switch (currentState)
        {
            case (CreateAPlayerStates.SELECTCLASS):
                break;
            case (CreateAPlayerStates.STATALLOCATION):
                break;
            case (CreateAPlayerStates.FINALSETUP):
                break;
        }
	}

    private void OnGUI()
    {
        displayFunctions.DisplayMainItems();
        if (currentState == CreateAPlayerStates.SELECTCLASS)
        { 
            // display class selection function
            displayFunctions.DisplaySelectClass();
        }

        if (currentState == CreateAPlayerStates.STATALLOCATION)
        {
            // display class selection function
            displayFunctions.DisplayStatAllocation();
        }

        if (currentState == CreateAPlayerStates.FINALSETUP)
        {
            // display class selection function
            displayFunctions.DisplayFinalSetup();
        }
    }
}
