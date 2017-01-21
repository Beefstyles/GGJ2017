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
            Debug.Log("Safe");
        }
        else
        {
            StartCoroutine("DelayFloorFalling");
        }

    }

    IEnumerator DelayFloorFalling()
    {
        yield return new WaitForSeconds(DelayForFloorFalling);
        gameObject.SetActive(false);
    }

}
