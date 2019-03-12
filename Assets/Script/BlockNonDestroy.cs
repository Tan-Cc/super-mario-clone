
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockNonDestroy : MonoBehaviour {

    public float xPos;
    public float yPos;
    public float zPos;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        transform.GetComponent<Collider>().isTrigger = false;
        if(other.gameObject.tag == "Player")
        {
            //让木块被player碰撞时时上移
            this.transform.position = new Vector3(xPos, yPos + 0.2f, zPos);
            yield return new WaitForSeconds(0.08f);
            this.transform.position = new Vector3(xPos, yPos, zPos);
            yield return new WaitForSeconds(0.25f);
            transform.GetComponent<Collider>().isTrigger = true;
        }
    }

    void Start () {
        xPos = transform.position.x;
        yPos = transform.position.y;
        zPos = transform.position.z;
	}
	
}
