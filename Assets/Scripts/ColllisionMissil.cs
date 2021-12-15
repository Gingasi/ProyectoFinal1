using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColllisionMissil : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("city"))
        {
            Destroy(gameObject);
            Destroy(otherCollider.gameObject);
        }


        if (otherCollider.gameObject.CompareTag("Meteor"))
        {
            Destroy(gameObject);
            Destroy(otherCollider.gameObject);
        }
    }
}
