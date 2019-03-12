using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qblock002 : MonoBehaviour {

    public GameObject QBlock;
    public GameObject DeadBlock;
    public AudioSource CoinAudio;

    public float xPos;
    public float yPos;
    public float zPos;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //让木块被player碰撞时时上移
            this.transform.position = new Vector3(xPos, yPos + 0.2f, zPos);
            yield return new WaitForSeconds(0.08f);
            this.transform.position = new Vector3(xPos, yPos, zPos);
            //yield return new WaitForSeconds(0.25f);
            //transform.GetComponent<Collider>().isTrigger = true;

            CoinAudio.Play();
            GlobalCoins.CoinCount += 5;
            GlobalScore.CurrentScore += 50;

            QBlock.SetActive(false);
            DeadBlock.SetActive(true);

            transform.GetComponent<Collider>().isTrigger = false;
        }
    }

    void Start()
    {
        xPos = transform.position.x;
        yPos = transform.position.y;
        zPos = transform.position.z;
    }
}
