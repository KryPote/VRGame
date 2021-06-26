using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class BlackLockFake : MonoBehaviour
{
    public GameObject BlackKey;
    public Teleport f3;

    private void PlayAudioClip(AudioSource source, AudioClip clip)
    {
        source.clip = clip;
        source.Play();
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == BlackKey)
        {
            PlayAudioClip(f3.audiohammer, f3.f3);
        }
    }
}
