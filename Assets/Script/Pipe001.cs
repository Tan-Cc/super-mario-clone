using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe001 : MonoBehaviour
{

    public GameObject PipeEntry;
    public GameObject maincmam;
    public GameObject secondcam;
    public GameObject mainplayer;

    Animator m_anim;
    Animator fade;

    public int StoodOn;

    public GameObject Fadescreen;

    public AudioSource PipeSound;

    void OnTriggerEnter(Collider col)
    {
        StoodOn = 1;
    }

    void OnTriggerExit(Collider col)
    {
        StoodOn = 0;
    }

    private IEnumerator WaitingForPipe()
    {
        PipeSound.Play();
        fade = Fadescreen.GetComponent<Animator>();
        m_anim.Play("Pipe001");
        yield return new WaitForSeconds(1.5f);

        Fadescreen.SetActive(true);
        fade.Play("Fadescreen");
        yield return new WaitForSeconds(0.495f);

        secondcam.SetActive(true);
        maincmam.SetActive(false);
        Vector3 vector = new Vector3(18.23f, -16.88f, -11.37f);
        mainplayer.transform.position = vector;

        fade.speed = 1;
        yield return new WaitForSeconds(0.495f);
        fade.speed = 0;
        Fadescreen.SetActive(false);
    }

    private void Start()
    {
        m_anim = PipeEntry.GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetButtonDown("GoDown"))
        {
            if(StoodOn == 1)
            {
                Vector3 vector = new Vector3(0, -1000, 0);
                transform.position = vector;
                StartCoroutine(WaitingForPipe());
            }
        }
    }
}