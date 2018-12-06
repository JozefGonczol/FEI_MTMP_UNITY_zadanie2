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

    private Vector3[] positions = new Vector3[2];
    private Quaternion[] rotations = new Quaternion[2];


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
        //engine
        positions[1] = new Vector3(3.014f, 0.4800012f, 0.742f);
        rotations[1] = Quaternion.Euler(0.0f, -138.865f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void toPosition(int position)
    {
        r.resetRotation();
        cm.changePosition(positions[position], rotations[position]);
    }

    public void resetCamera() {
        cm.changePosition(positions[0], rotations[0]);
    }
}
