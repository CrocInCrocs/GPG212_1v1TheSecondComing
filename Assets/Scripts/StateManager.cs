using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public StateBase startingState;
    public StateBase currentState;
    
    // Start is called before the first frame update
    private void OnEnable()
    {
        StateChange(startingState);
    }

    public void StateChange(StateBase newState)
    {
        if (newState == currentState)
        {
            return;
        }

        if (currentState != null)
        {
            currentState.Exit();
            //currentState.enabled = false; 
        }

        newState.enabled = true;

        currentState = newState;
    }

    
}
