using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public GameObject Helices;
    public GameObject Coin;
    public GameObject HelicesTraseras;

    private float Helispeed = 1000f;
    private float speed = 40f;

    // Update is called once per frame
    void Update()
    {
        Helices.transform.Rotate(0, Time.deltaTime * Helispeed, 0);
        Coin.transform.Rotate(0, Time.deltaTime * speed, 0);
        HelicesTraseras.transform.Rotate(Time.deltaTime * speed, 0, 0);
    }
}
