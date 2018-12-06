using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public bool isRotating;
    private bool isResseting = false;

    private Quaternion _from;
    private Quaternion _to;
    private Quaternion _initialQuaternion;
    private float _slerpDeltaTime;

    // Use this for initialization
    void Start () {
        _initialQuaternion = transform.rotation;
    }
	
	// Update is called once per frame
	void Update () {
        if (isRotating){
            transform.Rotate(new Vector3(0, 15, 0) * Time.deltaTime);
        }

        if (isResseting)
        {
            transform.rotation = Quaternion.Lerp(_from, _to, (Time.time - _slerpDeltaTime) * 2f);
            if (transform.rotation == _to)
            {
                isResseting = false;
            }
        }
    }

    public void resetRotation()
    {
        isRotating = false;
        isResseting = true;
        _slerpDeltaTime = Time.time;
        _from = transform.rotation;
        _to = _initialQuaternion;
    }
}
