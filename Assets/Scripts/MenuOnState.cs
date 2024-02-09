using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuOnState : MonoBehaviour
{
    //public AudioClip menuMusic;
    public AudioSource menuMusic;
    public TextMeshProUGUI menuText;

    public MonoBehaviour playerMovement1;
    public MonoBehaviour playerMovement2;
    // Start is called before the first frame update
    void OnEnable()
    {
        menuText.enabled = true;
        playerMovement1.enabled = false; 
        playerMovement2.enabled = false;
        menuMusic.enabled = true;
        Debug.Log("Menu on");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
       Debug.Log("Menu turning off"); 
       menuMusic.enabled = false;
    }
}
