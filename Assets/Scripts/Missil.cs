using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{
    public GameObject Misil;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(Misil, transform.position,
                transform.rotation);
        }
    }
    
}
