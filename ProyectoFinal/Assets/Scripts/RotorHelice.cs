using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotorHelice : MonoBehaviour
{
    public GameObject HelicesTraseras;
    private float speed = 800f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HelicesTraseras.transform.Rotate(Time.deltaTime * speed, 0, 0);
    }
}
