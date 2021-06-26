using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAnim : MonoBehaviour
{
    public Animator anim;
    public RedLock openRR;
    public GreenLock openRG;
    public BlueLock openRB;
    public GreenButton openRBlack;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (gameObject.name == "RedKlapa")
        {
            anim.SetBool("openRR.open", openRR.open);
        }
        if (gameObject.name == "KlapaBlack")
        {
            anim.SetBool("openRBlack.blackBox", openRBlack.blackBox);
        }
        if (gameObject.name == "BlueKlapa")
        {
            anim.SetBool("openRB.open", openRB.open);
        }
        if (gameObject.name == "GreenKlapa")
        {
            anim.SetBool("openRG.open", openRG.open);
        }
    }
}
