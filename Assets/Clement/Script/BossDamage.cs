using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamage : MonoBehaviour
{
    BossHealth h;
    public GameObject P_Explosion;
    public GameObject FireSound;
   

    private void Start()
    {
        GameObject Sound = Instantiate(FireSound, transform.position, Quaternion.identity) as GameObject;
       
    }

    void OnCollisionEnter(Collision col)
    {


        
        if (col.gameObject.CompareTag("Boss"))
        {
            
           // print(col.gameObject);
            h = (BossHealth)col.gameObject.GetComponent("BossHealth");
            h.TakeDamage(30);
            
                        
            GameObject P_Explosion1 = Instantiate(P_Explosion, transform.position , Quaternion.identity) as GameObject;
            
            Destroy(this.gameObject);
        }
        else
        {
            
            GameObject P_Explosion1 = Instantiate(P_Explosion, transform.position , Quaternion.identity) as GameObject;

            Destroy(this.gameObject);
        }
    }
}
