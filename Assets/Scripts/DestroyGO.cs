using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGO : MonoBehaviour
    
{

    
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
            Destroy(otherCollider.gameObject);
            Contador += 5;
            if (Contador >= 10)
            {
                Debug.Log("GANASTE");
                Time.timeScale = 0;
            }
        }
       
       if (otherCollider.gameObject.CompareTag("coinvariant"))
        {
            Destroy(otherCollider.gameObject);
            Contador += 1;
            if (Contador >= 10)
            {
                Debug.Log("GANASTE");
                Time.timeScale = 0;
            }

        }




    }
}
