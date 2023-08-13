using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteJudge_4 : MonoBehaviour
{
    Animator noteJudge;
    private void Start()
    {
        noteJudge = GetComponent<Animator>();
    }

    void Perfect()
    {
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Debug.Log("Perfect");
            noteJudge.SetTrigger("Perfect");
        }
    }
    void Great()
    {
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Debug.Log("Great");
            noteJudge.SetTrigger("Great");
        }
    }
    void Good()
    {
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Debug.Log("Good");
            noteJudge.SetTrigger("Good");
        }
    }
    void Poor()
    {
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            Debug.Log("Poor");
            noteJudge.SetTrigger("Poor");
        }
    }
    void Miss()
    {

        Debug.Log("Miss");

    }
}
