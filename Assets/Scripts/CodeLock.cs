using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodeLock : MonoBehaviour
{
    public TextMeshPro textval;
    public int correctrow;
    public int selectedvalue = 0;
    public bool correct;
    public bool firstC = true;

    public void CheckRow()
    {
       if(firstC == true)
       {
            textval.text = selectedvalue.ToString();
            firstC = false;
            if (selectedvalue == correctrow)
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
      }
    }
}
