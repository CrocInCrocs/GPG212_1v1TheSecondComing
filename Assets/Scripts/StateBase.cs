using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBase : MonoBehaviour
{
   public virtual void Enter()
   {
      Debug.Log(GetType().Name + "Enabled");
   }

   protected virtual void Execute()
   {
      
   }

   public virtual void Exit()
   {
      Debug.Log(GetType().Name + "Disabled");
   }
}
