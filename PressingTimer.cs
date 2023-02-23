using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressingTimer : MonoBehaviour
{
   [SerializeField]
   private float oTime;

   [SerializeField]
   private float increment;

   [SerializeField]
   private ScoreManager scoreManager;

   private float time = 0f;

    
    
    // Update is called once per frame
    void Update()
    {
      if (scoreManager.score != 102)
      { 
       if (!Input.GetMouseButtonDown(0))
       {
          if (time > 0)
          {
             time -= increment;
          }
          else
          {
             scoreManager.removeScore(1);
             time = oTime;
          }
       } 
      }
    }
}
