using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine("Transfer");
    }

    IEnumerator Transfer()
    {
        yield return new WaitForSeconds(1.5f);
        gameObject.transform.parent.position = new Vector3(0, 0, gameObject.transform.position.z + 150);
    }
}
