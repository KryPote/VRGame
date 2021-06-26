using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    public CodeLock CL1;
    public CodeLock CL2;
    public CodeLock CL3;


    public void Reset()
    {
        CL1.selectedvalue = 0;
        CL1.textval.text = "-";
        CL1.firstC = true;
        CL1.correct = false;

        CL2.selectedvalue = 0;
        CL2.textval.text = "-";
        CL2.firstC = true;
        CL2.correct = false;

        CL3.selectedvalue = 0;
        CL3.textval.text = "-";
        CL3.firstC = true;
        CL3.correct = false;
    }

}
