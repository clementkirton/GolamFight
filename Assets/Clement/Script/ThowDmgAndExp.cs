using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThowDmgAndExp : MonoBehaviour
{

    Health h;
    public GameObject Obj;
    public GameObject P_Exp;
    Rigidbody rb;
    public AudioSource As;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        As = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        

        if (col.gameObject.CompareTag("Dmg"))
        {
            As.Play();
            GameObject Exp = Instantiate(P_Exp, transform.position , Quaternion.identity) as GameObject;
            for (int i = 0; i < 4; i++)
            {
                Vector3 VectorRand = new Vector3(Random.Range(-0.01f, 0.01f), Random.Range(-0.01f, 0.01f), Random.Range(-0.01f, 0.1f));
                GameObject rubble = Instantiate(Obj, transform.position + VectorRand, Quaternion.identity) as GameObject;
            }
            Destroy(this.gameObject);

        }

        else if(col.gameObject.CompareTag("Player"))
        {
            As.Play();
            h = (Health)col.gameObject.GetComponent("Health");
            int damage = Mathf.Abs((int)rb.velocity.x) + Mathf.Abs((int)rb.velocity.z) + Mathf.Abs((int)rb.velocity.y);
            h.TakeDamage(damage/3);
            print(damage/3);

            GameObject Exp = Instantiate(P_Exp, transform.position , Quaternion.identity) as GameObject;

            for (int i = 0; i < 4; i++)
            {
                Vector3 VectorRand = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f));
                GameObject rubble = Instantiate(Obj, transform.position + VectorRand, Quaternion.identity) as GameObject;
            }
            Destroy(this.gameObject);
        }

        


    }
}
