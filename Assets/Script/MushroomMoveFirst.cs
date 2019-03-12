
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomMoveFirst : MonoBehaviour {

    public GameObject ActualMushrooom;
    public GameObject ThisMushroom;

    private void Update()
    {
        transform.parent = null;
        transform.Translate(Vector3.up * 2 * Time.deltaTime, Space.World);
        StartCoroutine(CloseAnim());
        ThisMushroom.SetActive(false);
        ActualMushrooom.SetActive(true);
    }

    private IEnumerator CloseAnim()
    {
        yield return new WaitForSeconds(0.5f);
    }
}
