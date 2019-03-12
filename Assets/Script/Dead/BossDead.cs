using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson;

public class BossDead : MonoBehaviour {

    public AudioSource DeathSound;
    public GameObject LevelMusic;
    public GameObject Camfollow;
    public GameObject ThePlayer;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        LevelMusic.SetActive(false);
        DeathSound.Play();
        Camfollow.GetComponent<CameraMove>().enabled = false;
        ThePlayer.GetComponent<ThirdPersonUserControl>().enabled = false;
        ThePlayer.GetComponent<ThirdPersonCharacter>().enabled = false;
        ThePlayer.GetComponent<CapsuleCollider>().enabled = false;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(3);
    }
}
