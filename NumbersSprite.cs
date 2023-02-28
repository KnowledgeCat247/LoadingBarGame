using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumbersSprite : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer number;

    public ScoreManager scoreManager;

    [SerializeField]
    private Sprite[] numbers;
    
    public enum NumberPlace{Ones, Tens, Hundreds };
    
    public NumberPlace numberPlace;

    public int onesNumber;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       if (numberPlace == NumberPlace.Hundreds)
        {
          //All this does is check if it's at 100
          if (scoreManager.score >= 100)
          {
            number.enabled = true;
            number.sprite = numbers[1];
          }
          else 
          {
            number.enabled = false;
          }
        }
        else if (numberPlace == NumberPlace.Tens)
        {
          //Checking the Ones place score area happens because it helps the system know to hide the Tens' place
          if (scoreManager.score == 0 || scoreManager.score < 10)
          {
            number.enabled = false;
          }
          else if (scoreManager.score >= 100)
          {
            number.sprite = numbers[0];
          }          
          else if (scoreManager.score >= 10 || scoreManager.score <= 99)
          {
             number.enabled = true;
             number.sprite = numbers[(scoreManager.score - onesNumber)/10];
          }


          //This is in the Tens area of if statement, because it's important to the tens' calculation
          if (scoreManager.score == 10 || scoreManager.score <= 19)
          {
            onesNumber = scoreManager.score - 10;
          }
          else if (scoreManager.score == 20 || scoreManager.score <= 29)
          {
            onesNumber = scoreManager.score - 20;
          }
          else if (scoreManager.score == 30 || scoreManager.score <= 39)
          {
            onesNumber = scoreManager.score - 30;
          }
          else if (scoreManager.score == 40 || scoreManager.score <= 49)
          {
            onesNumber = scoreManager.score - 40;
          }
          else if (scoreManager.score == 50 || scoreManager.score <= 59)
          {
            onesNumber = scoreManager.score - 50;
          }
          else if (scoreManager.score == 60 || scoreManager.score <= 69)
          {
            onesNumber = scoreManager.score - 60;
          }
          else if (scoreManager.score == 70 || scoreManager.score <= 79)
          {
            onesNumber = scoreManager.score - 70;
          } 
          else if (scoreManager.score == 80 || scoreManager.score <= 89)
          {
            onesNumber = scoreManager.score - 80;
          }
          else if (scoreManager.score == 90 || scoreManager.score <= 99)
          {
            onesNumber = scoreManager.score - 90;
          }
          else if (scoreManager.score >= 100)
          {
            onesNumber = scoreManager.score;
          } 
        }
        else if (numberPlace == NumberPlace.Ones)
        {
          if (scoreManager.score == 0 || scoreManager.score <= 9)
          {
            onesNumber = scoreManager.score;
            number.sprite = numbers[onesNumber];
          }
          else if (scoreManager.score == 10 || scoreManager.score <= 19)
          {
            onesNumber = scoreManager.score - 10;
            number.sprite = numbers[onesNumber];
          }
          else if (scoreManager.score == 20 || scoreManager.score <= 29)
          {
            onesNumber = scoreManager.score - 20;
            number.sprite = numbers[onesNumber];
          }
          else if (scoreManager.score == 30 || scoreManager.score <= 39)
          {
            onesNumber = scoreManager.score - 30;
            number.sprite = numbers[onesNumber];
          }
          else if (scoreManager.score == 40 || scoreManager.score <= 49)
          {
            onesNumber = scoreManager.score - 40;
            number.sprite = numbers[onesNumber];
          }
          else if (scoreManager.score == 50 || scoreManager.score <= 59)
          {
            onesNumber = scoreManager.score - 50;
            number.sprite = numbers[onesNumber];
          }
          else if (scoreManager.score == 60 || scoreManager.score <= 69)
          {
            onesNumber = scoreManager.score - 60;
            number.sprite = numbers[onesNumber];
          }
          else if (scoreManager.score == 70 || scoreManager.score <= 79)
          {
            onesNumber = scoreManager.score - 70;
            number.sprite = numbers[onesNumber];
          } 
          else if (scoreManager.score == 80 || scoreManager.score <= 89)
          {
            onesNumber = scoreManager.score - 80;
            number.sprite = numbers[onesNumber];
          }
          else if (scoreManager.score == 90 || scoreManager.score <= 99)
          {
            onesNumber = scoreManager.score - 90;
            number.sprite = numbers[onesNumber];
          }
          else if (scoreManager.score >= 100)
          {
            onesNumber = 0;
            number.sprite = numbers[onesNumber];
          }   
        }        
    }
}
