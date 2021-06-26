using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class BlackLock : MonoBehaviour
{
    public bool open;
    public GameObject BlackKey;
    public Teleport f4;
    public bool Active = true;

    private void PlayAudioClip(AudioSource source, AudioClip clip)
    {
        source.clip = clip;
        source.Play();
    }

    void Start()
    {
        open = false;
    }

    public void OnCollisionEnter(Collision col)
    {
        if(Active == true)
        {
            if (col.gameObject == BlackKey)
            {
                Active = false;
                open = true;
                PlayAudioClip(f4.audiohammer, f4.f4);
            }
        }
        
    }

}
