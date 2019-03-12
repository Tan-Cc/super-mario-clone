using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayButtonScript : MonoBehaviour {

	void Start () {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
	}

	void OnClick () {
        SceneManager.LoadScene(1);
    }
}
