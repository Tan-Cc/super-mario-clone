using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pipe002 : MonoBehaviour {

    public AudioSource PipeSound;
    public GameObject FadeScreen;
    public GameObject Maincam;
    public GameObject Secondcam;
    public GameObject PipeEntry;
    public GameObject MainPlayer;

    Animator fade;
    Animator main;

    private void Start()
    {
        main = PipeEntry.GetComponent<Animator>();
    }

    private IEnumerator OnTriggerEnter(Collider col)
    {
        PipeSound.Play();
        FadeScreen.SetActive(true);
        fade = FadeScreen.GetComponent<Animator>();

        
        fade.Play("Fadescreen");
        yield return new WaitForSeconds(1f);

        Maincam.SetActive(true);
        Secondcam.SetActive(false);

        MainPlayer.transform.position = new Vector3(27.54f, 0.62f, 0.53f);

        main.Play("Pipe002");
        yield return new WaitForSeconds(1.5f);

        FadeScreen.SetActive(false);
    }
}
