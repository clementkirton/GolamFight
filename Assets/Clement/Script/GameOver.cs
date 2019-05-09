using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public  bool gameOverPlayer = false;
    public  bool gameOverboss = false;
    public GameObject MenuUI;
    public Text GameText;

    private void Start()
    {
       MenuUI.SetActive(false);
        Time.timeScale = 1f;
        //Time.timeScale = 0f;
        //GameText = GameObject.Find("GameOverText").GetComponent<Text>();
    }
    void Update()
    {
        if(gameOverPlayer)
        {
            GameText.text = "Boss Win";
            MenuUI.SetActive(true);
            Time.timeScale = 0f;
        }

        if (gameOverboss)
        {
            GameText.text = "Players Win";
            MenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        Application.LoadLevel("MainArena");
       // print("restart");
    }
    public void Close()
    {
        Application.Quit();
        // print("close");
    }
}
