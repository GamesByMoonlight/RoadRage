using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_roadScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject segment;
    float zPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zPosition = transform.position.z;

        transform.Translate(0,0,-1);
        if(zPosition == -32)
        {
            CreateNewSegment();    
        }
        if(zPosition < -64)
            Destroy(this.gameObject);

    }
    void CreateNewSegment()
    {
        Instantiate(segment, new Vector3(0,0,128),Quaternion.identity);
    }

}
