using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(StateBase),true)]
public class StateBase_Editor : Editor
{
   public override void OnInspectorGUI()
   {
      base.OnInspectorGUI();
      
      StateBase stateBase = target as StateBase;

      if (GUILayout.Button(GetType().Name + ": Enabled"))
      {
         stateBase.GetComponent<StateManager>().StateChange(stateBase);
      }
   }
}
