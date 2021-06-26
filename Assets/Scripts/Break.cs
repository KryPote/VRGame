using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Break : MonoBehaviour
{
    public GameObject fractured;
    public float breakForce;
    public BlackLock openR;

    void Update()
    {
        if (openR.open == true)
        {
            BreakTheThing();
        }
    }

    public void BreakTheThing()
    {
        GameObject frac = Instantiate(fractured, transform.position, transform.rotation);
        foreach(Rigidbody rb in frac.GetComponentsInChildren<Rigidbody>())
        {
            Vector3 force = (rb.transform.position - transform.position).normalized * breakForce;
            rb.AddForce(force);
        }
        Destroy(gameObject);
    }
}
