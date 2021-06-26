using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLock : MonoBehaviour
{
    public bool open;
    public GameObject RedKey;

    void Start()
    {
        open = false;
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == RedKey)
        {
            open = true;
        }
    }
}
