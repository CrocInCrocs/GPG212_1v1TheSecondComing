using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuOffState : MonoBehaviour
{
    public TextMeshProUGUI menuText;
    public AudioSource gameSoundtrack;
    public MonoBehaviour playerMovement1; 
    public MonoBehaviour playerMovement2;
    // Start is called before the first frame update
    void OnEnable()
    {
        menuText.enabled = false;
        playerMovement1.enabled = true; 
        playerMovement2.enabled = true;
        gameSoundtrack.Play();
        Debug.Log("Menu off");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        Debug.Log("Menu turning on");
        gameSoundtrack.Pause();
    }
}
