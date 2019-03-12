
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalLife : MonoBehaviour {

    public static int LivesAmount = 3;
    public int InternalLives;
    public Text LifeTextBox;

    private void Update()
    {
        InternalLives = LivesAmount;
        LifeTextBox.text = "" + InternalLives;

        if(InternalLives == 0)
        {
            StartCoroutine(GameoverScene());
        }
    }

    IEnumerator GameoverScene()
    {
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene(3);
    }

    /*public void decrease()
    {
        LivesAmount -= 1;
    }

    public void increase()
    {
        LivesAmount += 1;
    }*/
}
