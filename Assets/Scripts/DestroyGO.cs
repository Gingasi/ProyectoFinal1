using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGO : MonoBehaviour
    
{

    public int Coin = 5;
    public int CoinVariant = 1;
    public int Contador = 0;



    // Update is called once per frame
    void Start()
    {
        Contador = 0;
    }
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("city"))
        {
            Debug.Log($"GAME OVER");
                Time.timeScale = 0;
        }
       
        if (otherCollider.gameObject.CompareTag("Meteor"))
        {
            Debug.Log($"GAME OVER");
                Time.timeScale = 0;
        }

        if (otherCollider.gameObject.CompareTag("coins"))
        {
            
            Contador += 5;
            if (Contador >= 10)
            {
                Debug.Log("GANASTE");
                Time.timeScale = 0;
            }
        }
       
        /*if (otherCollider.gameObject.CompareTag("coinvariant"))
        {
           
            Contador += 1;
            if (Contador >= 10)
            {
                Debug.Log("GANASTE");
                Time.timeScale = 0;
            }

        }*/




    }
}
