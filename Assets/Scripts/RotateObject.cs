using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

    private float rotationSpeed = 25F;

	void Update ()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
	}

}
