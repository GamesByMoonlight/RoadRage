using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_testPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    float xmove;
    Rigidbody myRigidbody;
    Vector3 movement;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        xmove = Input.GetAxis("Horizontal")*4;
        movement = new Vector3(xmove,0,0);
        myRigidbody.velocity = movement;

    }
}
