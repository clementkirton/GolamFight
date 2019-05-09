using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public static int Player1Lives;
    public static int Player2Lives;
    public GameOver gameoverObject;
    // public static int Player3Lives;
    // public static int Player4Lives;

    void Start()
    {
        Player1Lives = 3;
        Player2Lives = 3;
        gameoverObject = GameObject.Find("UIManager").GetComponent<GameOver>();

    }

   public static void TakeLive(int playernr)
    {
        switch(playernr)
        {
            case 1:
                {
                    Player1Lives = Player1Lives - 1;
                }
            break;
            case 2:
                {
                    Player2Lives = Player2Lives - 1;
                }
            break;
        }
    }

    private void Update()
    {
        if(Player1Lives < 1 && Player2Lives < 1)
        {

            gameoverObject.gameOverPlayer = true;
            //GameOver Boss Wins
            print("BossWon");
        }
    }

}
