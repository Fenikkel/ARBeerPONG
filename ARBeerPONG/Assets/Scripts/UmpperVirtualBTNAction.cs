using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class UmpperVirtualBTNAction : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vbBtnObj2;
    public GameObject ballon2;

    // Use this for initialization
    void Start()
    {

        ballon2 = GameObject.Find("baloBaix");

        vbBtnObj2 = GameObject.Find("UmpperVirtualBallonBTN");
        vbBtnObj2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //cubeAni.Play("cube_animation");
        Destroy(ballon2);
        Debug.Log("Umpper Button pressed");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //cubeAni.Play("none");
        Debug.Log("Umpper Button released");
    }
}
