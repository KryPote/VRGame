using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleButton : MonoBehaviour
{
    public int number;
    public CodeLock CL;

    public void GiveNumber()
    {
        if(CL.firstC == true)
        {
            CL.selectedvalue = number;
        }

    }
}
