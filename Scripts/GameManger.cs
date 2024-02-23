using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    
    public bool GameEnded=false;
    public GameObject GameOverUI;

    public void EndGame()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            GameOverUI.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      
    }
}
