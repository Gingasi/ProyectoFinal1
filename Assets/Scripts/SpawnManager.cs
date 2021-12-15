using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Prefab;
    public float yMax = 95f;
    public float yMin = 90f;
    private float xMax = 200f;
    private float zMax = 200f;
    private Vector3 InitialPos = Vector3.zero;
    private float startTime = 2f;
    private float repeatRate = 5f;
 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPrefab", startTime, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public Vector3 RandomPosition()
    {
        return new Vector3(Random.Range(-xMax, xMax), Random.Range(90f, 95f), Random.Range(-zMax, zMax));
    }

    public void SpawnPrefab()
    {
        InitialPos = RandomPosition();
        Instantiate(Prefab, InitialPos,
            Prefab.transform.rotation);
    }
   
}
