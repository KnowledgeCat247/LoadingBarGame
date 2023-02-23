using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;

    private int limit = 104;

    [SerializeField]
    private Slider slider;

    // Update is called once per frame
    void Update()
    {
       //To make sure the score doesn't exceed the limit
       if (score == limit || score > limit)
       {
          score = limit;
       }  
    }

    //Updates any UI elements
    void UpdateUI()
    {
      slider.value = score;
    }

    //A public function to add to the score from an outside source
    public void addScore(int adder = 5)
    {
       score += adder;
       UpdateUI();
    }

    //A public function to remove from the score from an outside source
    public void removeScore(int remover = 5)
    {
      if (score != 0 || score !< 0)
      {
        score -= remover;
        UpdateUI();
      }
    }
}
