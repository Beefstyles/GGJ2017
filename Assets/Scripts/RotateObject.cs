using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

    public float RotationSpeed = 25F;

	void Update ()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * RotationSpeed);
	}

}
