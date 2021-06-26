using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Endgame : MonoBehaviour
{
    public AudioSource music;
    public GameObject canvas;
    public GameObject Trigger;
    public Teleport f5;
    public GameObject Area;
    public GameObject Black;

    public bool active = true;

    private void PlayAudioClip(AudioSource source, AudioClip clip)
    {
        source.clip = clip;
        source.Play();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (active == true)
        {
            if (collision.gameObject == Trigger)
            {
                active = false;
                PlayAudioClip(f5.audiohammer, f5.f5);
                StartCoroutine(Bounds());
            }
        }
    }
    IEnumerator Bounds()
    {
        yield return new WaitForSeconds(12);
        canvas.SetActive(true);
        yield return new WaitForSeconds(4);
        Black.SetActive(true);
        yield return new WaitForSeconds(5);
        Application.Quit();

    }
}
