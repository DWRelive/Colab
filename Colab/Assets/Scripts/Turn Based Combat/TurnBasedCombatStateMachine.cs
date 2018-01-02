using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMachine : MonoBehaviour
{
    private bool hasAddedExp = false;

    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }

    private BattleStates currentState;


    // starts the combat turn
    void Start()
    {
        hasAddedExp = false;
        currentState = BattleStates.START;
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentState);
        switch (currentState)
        {
            case (BattleStates.START):
                //Setup Battle Functions
                break;

            case (BattleStates.PLAYERCHOICE):
                //Player decides an action
                break;

            case (BattleStates.ENEMYCHOICE):
                //Random enemy action
                break;

            case (BattleStates.WIN):
                //player wins the match
                if (!hasAddedExp)
                {
                    IncreaseExperience.AddExperience();
                    hasAddedExp = true;
                }

                break;

            case (BattleStates.LOSE):
                //player loses the match
                break;

        }

    }

    void OnGUI()
    {
        if (GUILayout.Button("Next State"))
        {
            if (currentState == BattleStates.START)
            {
                currentState = BattleStates.PLAYERCHOICE;
            }
            else if (currentState == BattleStates.PLAYERCHOICE)
            {
                currentState = BattleStates.ENEMYCHOICE;
            }
            else if (currentState == BattleStates.ENEMYCHOICE)
            {
                currentState = BattleStates.LOSE;
            }
            else if (currentState == BattleStates.LOSE)
            {
                currentState = BattleStates.WIN;
            }
            else if (currentState == BattleStates.WIN)
            {
                currentState = BattleStates.START;
            }
        }
    }
}
    
    

