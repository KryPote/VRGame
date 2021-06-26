using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenLock : MonoBehaviour
{
    public bool open;
    public GameObject GreenKey;

    void Start()
    {
        open = false;
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == GreenKey)
        {
            open = true;
        }
    }
}
