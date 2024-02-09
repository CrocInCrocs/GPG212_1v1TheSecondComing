using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public MonoBehaviour startingState;
    public MonoBehaviour currentState;
    
    // Start is called before the first frame update
    private void Start()
    {
        StateChange(startingState);
    }

    public void StateChange(MonoBehaviour newState)
    {
        if (newState == currentState)
        {
            return;
        }

        if (currentState != null)
        {
            currentState.enabled = false; 
        }

        newState.enabled = true;

        currentState = newState;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
