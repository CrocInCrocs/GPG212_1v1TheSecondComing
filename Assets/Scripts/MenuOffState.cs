using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuOffState : StateBase
{
    public TextMeshProUGUI menuText;
    public AudioSource gameSoundtrack;
    public MonoBehaviour playerMovement1; 
    public MonoBehaviour playerMovement2;
    // Start is called before the first frame update
    void OnEnable()
    {
        //this section turns off the pause screen and resumes the music within the game 
        menuText.enabled = false;
        gameSoundtrack.Play();
        //this turns the players controls back on 
        playerMovement1.enabled = true;
        playerMovement2.enabled = true;
        Debug.Log("Menu off");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        Debug.Log("Menu turning on");
        //this pauses the game music so the menu music can play without conflict
        gameSoundtrack.Pause();
    }
}




