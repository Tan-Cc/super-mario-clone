
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;

public class CountDown1 : MonoBehaviour {

    public int Totaltime = 301;
    public Text TimeDisplay;
    public int Calculatingtime;
    public AudioSource DeadSound;
    public GameObject LevelMusic;
    public GameObject Camfollow;
    public GameObject ThePlayer;
    public int Keepzero;
    public static int TimeLeft;

    private void Update()
    {
        TimeLeft = Totaltime;
        if (Keepzero == 0)
        {
            TimeDisplay.text = "" + Totaltime;
        }

        if(Calculatingtime == 0)
        {
            StartCoroutine(Deducttime());
        }

        if(Totaltime == 0)
        {
            StartCoroutine(Timeup());
        }
    }

    IEnumerator Deducttime()
    {
        Calculatingtime = 1;
        Totaltime -= 1;
        yield return new WaitForSeconds(1f);
        Calculatingtime = 0;
    }

    IEnumerator Timeup()
    {
        Totaltime -= 1;
        Keepzero = 1;
        TimeDisplay.text = "0";
        GlobalLife.LivesAmount -= 1;
        LevelMusic.SetActive(false);
        DeadSound.Play();
        Camfollow.GetComponent<CameraMove>().enabled = false;
        ThePlayer.GetComponent<ThirdPersonUserControl>().enabled = false;
        ThePlayer.GetComponent<ThirdPersonCharacter>().enabled = false;
        ThePlayer.GetComponent<CapsuleCollider>().enabled = false;
        yield return new WaitForSeconds(1f);
        GlobalScore.CurrentScore = 0;
        GlobalCoins.CoinCount = 0;
        SceneManager.LoadScene(1);
    }
}
