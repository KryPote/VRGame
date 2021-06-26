using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButton : MonoBehaviour
{
    public CodeLock CL1;
    public CodeLock CL2;
    public CodeLock CL3;
    public bool blackBox = false;

    public void CheckGreen()
    {
        if (CL1.correct && CL2.correct && CL3.correct)
        {
            blackBox = true;
            CL1.textval.text = "^";
            CL2.textval.text = "_";
            CL3.textval.text = "^";
        }
    }

}
