using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public StateBase menuOn;

    public StateBase menuOff;

    public bool menuEnabled;
    // Start is called before the first frame update
    void OnEnable()
    {
        menuEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && menuEnabled)
        {
            GetComponent<StateManager>().StateChange(menuOff);
            Debug.Log("Menu off");
            menuEnabled = false;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && !menuEnabled)
        {
            GetComponent<StateManager>().StateChange(menuOn);
            Debug.Log("Menu off");
            menuEnabled = true;
        }
    }
}
