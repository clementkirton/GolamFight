using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public int CurrentHealth = 1000;
    public Text BossHP;
    public GameOver gameoverObject;

    

    void Start()
    {
        BossHP = GameObject.Find("BossHPText").GetComponent<Text>();
        gameoverObject = GameObject.Find("UIManager").GetComponent<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CurrentHealth < 1)
        {
            gameoverObject.gameOverPlayer = true;
            print("PlayerWins");
        }

        BossHP.text = "Boss : " + CurrentHealth;
    }


    public void TakeDamage(int Dmg)
    {
        CurrentHealth = CurrentHealth - Dmg;
    }


}
