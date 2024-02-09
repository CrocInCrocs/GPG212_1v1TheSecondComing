using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MenuController : MonoBehaviour
{
    public MonoBehaviour menuOn;
    public MonoBehaviour menuOff;
    
    public bool menuEnabled;
    // Start is called before the first frame update
    void Start()
    {
        menuEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && menuEnabled)
        {
            GetComponent<StateManager>().StateChange(menuOff);
            Debug.Log("Menu off");
            menuEnabled = false;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && !menuEnabled)
        {
            GetComponent<StateManager>().StateChange(menuOn);
            Debug.Log("Menu on");
            menuEnabled = true;
        }
    }
}
