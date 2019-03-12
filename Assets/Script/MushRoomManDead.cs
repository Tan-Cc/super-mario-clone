
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushRoomManDead : MonoBehaviour {

    public GameObject MushroomMan;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        MushroomMan.GetComponent<MushroomManMove>().enabled = false;
        MushroomMan.transform.localScale -= new Vector3(0, 0.8f, 0);
        MushroomMan.transform.localPosition -= new Vector3(0, 0.4f, 0);
        GlobalScore.CurrentScore += 100;
        yield return new WaitForSeconds(1f);
        MushroomMan.transform.position = new Vector3(0, -1000, 0);
    }
}
