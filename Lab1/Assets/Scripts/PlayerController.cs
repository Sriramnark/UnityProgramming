using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed = 3;
    public float speed = 15.0f;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //Move the vehicle forward
        transform.Translate(Vector3.forward *Time.deltaTime *speed *forwardInput);
        transform.Rotate(Vector3.right, Time.deltaTime *turnSpeed* horizontalInput);
    }
}
