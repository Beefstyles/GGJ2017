using UnityEngine;
using System.Collections;

public class FallingFallTrigger : MonoBehaviour {

	public bool isWalkable;
    FallingFloorControl ffc;
    public float DelayForFloorFalling;

    void Start()
    {
        ffc = GetComponentInParent<FallingFloorControl>();
    }

    void OnTriggerEnter(Collider coll)
    {
        if (ffc.WallPuzzleActive)
        {
            if (coll.gameObject.tag == "Player")
            {
                FallingWallAction(isWalkable);
            }
        }
    }

    private void FallingWallAction(bool isWalkable)
    {
        if (isWalkable)
        {
            //Debug.Log("Safe");
        }
        else
        {
            StartCoroutine("FloorDelayToTransparent");
        }

    }

    IEnumerator FloorDelayToTransparent()
    {
        float alpha = transform.GetComponent<MeshRenderer>().material.color.a;
        Color currentColour;
        currentColour = transform.GetComponent<MeshRenderer>().material.color;
        for (float t = 0F; t< DelayForFloorFalling; t+= Time.deltaTime)
        {
            currentColour.a = Mathf.Lerp(alpha, 0, t);
            transform.GetComponent<MeshRenderer>().material.color = currentColour;
            yield return null;
        }
        DisableFloor();
    }

    void DisableFloor()
    {
        gameObject.SetActive(false);
    }

}
