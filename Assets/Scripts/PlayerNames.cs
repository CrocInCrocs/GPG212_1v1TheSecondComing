using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PlayerNames : MonoBehaviour
{
   public TextMeshProUGUI playerName;

   public delegate void NoParameters();

   public NoParameters PlayerNameChange;

   public void Update()
   {
       if (playerName = new TextMeshProUGUI())
       {
           PlayerNameChange?.Invoke();
       }
   }
}
