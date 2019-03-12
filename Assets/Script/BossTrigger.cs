
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigger : MonoBehaviour {

    public GameObject MainCam;
    public GameObject BackWall;

    private void OnTriggerEnter(Collider other)
    {
        MainCam.GetComponent<CameraMove>().enabled = false;
        BackWall.SetActive(true);
    }
}
