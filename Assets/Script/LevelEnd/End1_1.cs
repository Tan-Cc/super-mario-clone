
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End1_1 : MonoBehaviour {

    public GameObject FadeScreen;
    public GameObject ThePlayer;
    public int TimeScore;
    public int TimeLeftInt;

    Animator fade;

    private IEnumerator OnTriggerEnter(Collider other)
    {
        FadeScreen.SetActive(true);

        fade = FadeScreen.GetComponent<Animator>();

        TimeLeftInt = CountDown1.TimeLeft;
        TimeScore = TimeLeftInt * 10;
        GlobalScore.CurrentScore += TimeScore; 

        fade.Play("Fadescreen");
        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene(4);
    }
}
