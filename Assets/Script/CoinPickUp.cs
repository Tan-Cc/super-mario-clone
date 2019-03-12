
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {

    public AudioSource CoinAudio;

    void OnTriggerEnter(Collider col)
    {
        transform.position = new Vector3(0, -1000, 0);
        CoinAudio.Play();
        GlobalCoins.CoinCount += 1;
        GlobalScore.CurrentScore += 10;
    }
}
