using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {
    private bool moveCamera;
    private GameObject targetPosition;
    private float speed = 1.0f;

	// Use this for initialization
	void Start () {
       moveCamera = false;
        targetPosition = new GameObject();
	}
	
	// Update is called once per frame
	void Update () {
        if (moveCamera)
        {
            this.transform.position = Vector3.Lerp(transform.position, targetPosition.transform.position, speed * Time.deltaTime);
            this.transform.rotation = Quaternion.Lerp(transform.rotation, targetPosition.transform.rotation, speed * Time.deltaTime);
            if (transform == targetPosition.transform)
            {
                moveCamera = false;
            }
        }
	}

    public void changePosition(Vector3 position, Quaternion rotation) {
        targetPosition.transform.position = position;
        targetPosition.transform.rotation = rotation;
        moveCamera = true;
    }

    
}
