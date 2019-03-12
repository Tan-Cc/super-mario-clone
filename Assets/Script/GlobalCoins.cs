
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoins : MonoBehaviour {

    public static int CoinCount;
    public int Internalcoin;
    public Text Coindisplay;

	void Update () {
        Coindisplay.text = "Coins: " + CoinCount;
        Internalcoin = CoinCount;
	}
}
