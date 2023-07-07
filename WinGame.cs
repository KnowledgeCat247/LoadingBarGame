using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    [SerializeField]
    private ScoreManager scoreManager;

    public void winGame(int sceneIndex)
    {
        if (scoreManager.score >= 100)
        {
          SceneManager.LoadScene(sceneIndex);
        }
    }
}
