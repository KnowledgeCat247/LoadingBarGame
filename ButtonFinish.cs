using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFinish : MonoBehaviour
{
    [SerializeField]
    private Color winColor;

    [SerializeField]
    private ScoreManager scoreManager;

    [SerializeField]
    private Image buttonImage;

    void Update()
    {
       if (scoreManager.score == 101)
       {
           buttonImage.color = winColor;
       }
    }
}
