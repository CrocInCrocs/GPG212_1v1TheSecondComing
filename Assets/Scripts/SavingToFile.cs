using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingToFile : MonoBehaviour
{
    public string playerName;
    public lis
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetString("PlayerName", playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
