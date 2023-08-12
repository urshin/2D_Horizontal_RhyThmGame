using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteJudge : MonoBehaviour
{
   
    void Perfect()
    {
        if(Input.GetKeyDown(KeyCode.Keypad1))
        Debug.Log("PERFECT");
    }
    void Great()
    {
        Debug.Log("Great");

    }
}
