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
      if (scoreManager.score != 100)
      { 
       if (!Input.GetMouseButtonDown(0))
       {
          if (time > 0)
          {
             time -= increment;
          }
          else
          {
             destroyScore(1);
          }
       } 
      }
    }

    private void destroyScore(int amountRemover)
    {
       scoreManager.removeScore(amountRemover);
       time = oTime;
    }
}
