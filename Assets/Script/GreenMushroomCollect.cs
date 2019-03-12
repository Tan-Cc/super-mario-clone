
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMushroomCollect : MonoBehaviour {

        public AudioSource LifeSound;
        //public GlobalLife globalLife;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                this.transform.position = new Vector3(0, -1000, 0);
                LifeSound.Play();
                GlobalLife.LivesAmount += 1;
                //globalLife.increase();
            }
        }
}
