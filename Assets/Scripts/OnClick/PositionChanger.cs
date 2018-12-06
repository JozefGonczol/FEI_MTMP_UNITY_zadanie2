using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChanger : MonoBehaviour {

    private GameObject platform;
    private GameObject camera;
    private Rotator r;
    private CameraMover cm;
    private Quaternion initPos;
    private GameObject target;


    private Vector3[] positions = new Vector3[5];
    private Quaternion[] rotations = new Quaternion[5];
    private string[] canvases = new string[2];

    public GameObject engine;
    public GameObject cockpit;
    public GameObject canons;
    public GameObject torpedo;

    // Use this for initialization
    void Start()
    {
        platform = GameObject.Find("Platform");
        camera = GameObject.Find("Main Camera");
        initPos = platform.transform.rotation;
        r = platform.GetComponent<Rotator>();
        cm = camera.GetComponent<CameraMover>();

        //default
        positions[0] = new Vector3(0.0f, 1.5f, -10.0f);
        rotations[0] = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        canvases[0] = "Menu";
        //engine
        positions[1] = new Vector3(3.014f, 0.4800012f, 0.742f);
        rotations[1] = Quaternion.Euler(0.0f, -138.865f, 0.0f);
        canvases[1] = "Engine";
        //cockpit
        positions[2] = new Vector3(-0.04f, 2.32f, 0.44f);
        rotations[2] = Quaternion.Euler(90.0f, 0.0f, 0.0f);
        //canons
        positions[3] = new Vector3(0.0f, 1.00f, -2.0f);
        rotations[3] = Quaternion.Euler(30.0f, 0.0f, 0.0f);
        //torpedo loauncher
        positions[4] = new Vector3(0.0f, 0.50f, -2.6f);
        rotations[4] = Quaternion.Euler(-15.0f, 0.0f, 0.0f);

        resetCanvases();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void toPosition(int position)
    {
        r.resetRotation();
        cm.changePosition(positions[position], rotations[position]);
        resetCanvases();
        showStat(position);
    }

    public void resetCamera() {
        cm.changePosition(positions[0], rotations[0]);
        resetCanvases();
    }

    private void resetCanvases() {
        engine.SetActive(false);
        cockpit.SetActive(false);
        canons.SetActive(false);
        torpedo.SetActive(false);
    }

    private void showStat(int index) {
        switch (index) {
            case 1:
                engine.SetActive(true);
                break;
            case 2:
                cockpit.SetActive(true);
                break;
            case 3:
                canons.SetActive(true);
                break;
            case 4:
                torpedo.SetActive(true);
                break;
        }
    }
}
