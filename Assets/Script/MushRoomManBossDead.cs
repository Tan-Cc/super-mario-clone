
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MushRoomManBossDead : MonoBehaviour {

    public GameObject MushroomMan;
    public AudioSource Con;
    public GameObject LevelMusic;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        MushroomMan.GetComponent<MushroomManMove>().enabled = false;
        MushroomMan.transform.localScale -= new Vector3(0, 1.8f, 0);
        MushroomMan.transform.localPosition -= new Vector3(0, 1.4f, 0);
        GlobalScore.CurrentScore += 1000;
        yield return new WaitForSeconds(1f);
        MushroomMan.transform.position = new Vector3(0, -1000, 0);
        LevelMusic.SetActive(false);
        Con.Play();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(6);
    }
}
