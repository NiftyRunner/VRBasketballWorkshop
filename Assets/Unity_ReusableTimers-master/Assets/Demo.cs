﻿using UnityEngine ;

public class Demo : MonoBehaviour {

   [SerializeField] Timer timer1 ;

   private void Start () {

      timer1
      .SetDuration (59)
      .OnEnd (() => Debug.Log ("Timer 4 ended"))
      .Begin () ;
   }

}
