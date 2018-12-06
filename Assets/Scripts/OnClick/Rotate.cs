using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour {

    private GameObject platform;
    private Rotator r;
    private GameObject menu;
    private PositionChanger pc;

    // Use this for initialization
    void Start () {

        platform = GameObject.Find("Platform");
        r = platform.GetComponent<Rotator>();
        menu = GameObject.Find("Menu");
        pc = menu.GetComponent<PositionChanger>();
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void togleRotation() {
        pc.resetCamera();
        r.isRotating = !r.isRotating;
    }
}
