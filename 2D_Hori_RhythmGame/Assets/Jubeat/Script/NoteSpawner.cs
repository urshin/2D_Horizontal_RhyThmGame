using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : NumPadTest
{

    int RandomNote;
    [SerializeField] int value;

    void Start()
    {
        StartCoroutine(Count321(3));
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Count321(int value)
    {
        for(int i = value; i>0; i--)
        {
            Debug.Log(i);
            yield return new WaitForSeconds(1);
        }
        StartCoroutine(CreateNote());

    }

    IEnumerator CreateNote()
    {
        while (true)
        {
            
           RandomNote = Random.Range(1, 10);
            switch(RandomNote)
            {
                case 1:
                    anime1.SetTrigger("Pop");
                    break;
                case 2:
                    anime2.SetTrigger("Pop");
                    break;
                case 3:
                    anime3.SetTrigger("Pop");
                    break;
                case 4:
                    anime4.SetTrigger("Pop");
                    break;
                case 5:
                    anime5.SetTrigger("Pop");
                    break;
                case 6:
                    anime6.SetTrigger("Pop");
                    break;
                case 7:
                    anime7.SetTrigger("Pop");
                    break;
                case 8:
                    anime8.SetTrigger("Pop");
                    break;
                case 9:
                    anime9.SetTrigger("Pop");
                    break;

            }
            yield return new WaitForSecondsRealtime(0.5f);

        }
    }
}
