using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

    private float rotationSpeed = 50F;
    private Quaternion targetRot;
    
	void Start ()
    {
        targetRot = transform.rotation;
	}

	void Update ()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
	}

}
