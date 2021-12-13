using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private Vector3 initialPos = new Vector3(0, 100, 0);
    private Quaternion initialRot = Quaternion.Euler(10, 0, 0);
    private float verticalInput;
    private float horizontalInput;
    private float turnspeed = 20f;
    private float yMax = 200f;
    private float xMax = 320f;
    private float zMax = 200f;

    public GameObject Misil;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPos; //indicamos la posición inicial
        transform.rotation = initialRot; //indicamos la rotación inicial, esto es porque los helicópteros no se mueven horizontalmente, si no un poco inclinados
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.right * turnspeed * Time.deltaTime * -verticalInput);
        transform.Rotate(Vector3.up * turnspeed * Time.deltaTime * horizontalInput);

        if (transform.position.x > xMax)
        {
            transform.position = new Vector3(xMax, transform.position.y,
                transform.position.z);
        }

    
        if (transform.position.x < -xMax)
        {
            transform.position = new Vector3(-xMax, transform.position.y,
                transform.position.z);
        }

        if (transform.position.y > yMax)
        {
            transform.position = new Vector3(transform.position.x, yMax,
                transform.position.z);
        }

     
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x, 0,
                transform.position.z);
        }
        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y, zMax);
        }

        if (transform.position.z < -zMax)
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y, zMax);
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(Misil, transform.position,
                transform.rotation);
        }
    }
}
