using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualBTNAction : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject vbBtnObj;
    private GameObject ballon;

    // Use this for initialization
    void Start () {

        ballon = GameObject.Find("baloBaix");

        vbBtnObj = GameObject.Find("VirtualBallonBTN");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        //cubeAni.Play("cube_animation");
        //Destroy(ballon);
        //Debug.Log("Button pressed");

        ballon.SetActive(false);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        //cubeAni.Play("none");
        //Debug.Log("Button released");
        ballon.SetActive(false);

    }
}
