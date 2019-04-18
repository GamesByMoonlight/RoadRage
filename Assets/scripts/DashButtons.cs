using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashButtons : MonoBehaviour
{


    public float delayTime = 2f;
    public string buttonType;

    public void ActionButton(string ButtonType)
    {
        Invoke(ButtonType,0f);
    }


    void FireRocket()
    {

        Debug.Log("FireRocket");

    }

    void FireGun()
    {
        Debug.Log("FireGun");
    }

    void ReleaseOil()
    {
        Debug.Log("ReleaseOil");
    }


}
