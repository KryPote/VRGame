using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLock : MonoBehaviour
{
    public bool open;
    public GameObject BlueKey;

    void Start()
    {
        open = false;
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == BlueKey)
        {
            open = true;
        }
    }
}
