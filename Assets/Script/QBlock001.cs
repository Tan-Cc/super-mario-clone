using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QBlock001 : MonoBehaviour {

    public GameObject QBlock;
    public GameObject DeadBlock;
    public GameObject Mushroom;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        QBlock.SetActive(false);
        DeadBlock.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        Mushroom.SetActive(true);
    }
}
