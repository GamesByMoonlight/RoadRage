using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_player : MonoBehaviour
{
    public float xmove;
    public float zmove;
    Rigidbody myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        xmove = Input.GetAxis("Horizontal")*30;
        zmove = Input.GetAxis("Vertical")*30;
        myRigidbody.velocity = new Vector3(zmove, 0, xmove);
    }
}
