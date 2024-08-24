using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicMangScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameoverScreen; 
    [ContextMenu("Increase the player score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    { 
    gameoverScreen.SetActive(true);
    }
}
