using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{


    public int CurrentHealth = 100;
    public int PlayerNr;
    public Text player1HP;
    public Text player2HP;
   

    private void Start()
    {
        player1HP = GameObject.Find("Player1HPText").GetComponent<Text>();
        player2HP = GameObject.Find("Player2HPText").GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            PlayerManager.TakeLive(PlayerNr);
            switch (PlayerNr)
            {
                case 1:
                        {
                         if (PlayerManager.Player1Lives > 0)
                            {
                                Spawning.Player1Spawn = true;
                                print("Died :" + PlayerNr+" Lives Left :"+PlayerManager.Player1Lives);
                            }
                        Destroy(this.gameObject);
                        }
                    break;
                case 2:
                    {
                        if (PlayerManager.Player2Lives > 0)
                        {
                            Spawning.Player2Spawn = true;
                            print("Died" + PlayerNr + " Lives Left :" + PlayerManager.Player2Lives);
                        }
                        Destroy(this.gameObject);
                    }
                    break;

            }

        }

        //player 1 health
        switch (PlayerNr)
        {
            case 1:
                {
                    player1HP.text = "Player 1 : " + CurrentHealth;
                }
                break;
            case 2: 
                {
                    player2HP.text = "Player 2 : " + CurrentHealth;
                }
                break;

        }



    }

     public void TakeDamage(int Dmg)
    {
        CurrentHealth = CurrentHealth - Dmg;
    }
}
