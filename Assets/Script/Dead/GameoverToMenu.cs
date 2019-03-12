
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverToMenu : MonoBehaviour {

    IEnumerator Start () {
        yield return new WaitForSeconds(2f);
        GlobalLife.LivesAmount += 3;
        GlobalScore.CurrentScore = 0;
        GlobalCoins.CoinCount = 0;
        SceneManager.LoadScene(0);
    }
	
}
