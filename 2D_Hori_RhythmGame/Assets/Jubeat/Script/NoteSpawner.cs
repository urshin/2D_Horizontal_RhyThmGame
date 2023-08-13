using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public List<Animator> anime = new List<Animator>();

    int RandomNote;
    [SerializeField] int value;
    
    

    void Start()
    {
        anime.Add(transform.Find("Note_1").gameObject.GetComponent<Animator>());
        anime.Add(transform.Find("Note_2").gameObject.GetComponent<Animator>());
        anime.Add(transform.Find("Note_3").gameObject.GetComponent<Animator>());
        anime.Add(transform.Find("Note_4").gameObject.GetComponent<Animator>());
        anime.Add(transform.Find("Note_5").gameObject.GetComponent<Animator>());
        anime.Add(transform.Find("Note_6").gameObject.GetComponent<Animator>());
        anime.Add(transform.Find("Note_7").gameObject.GetComponent<Animator>());
        anime.Add(transform.Find("Note_8").gameObject.GetComponent<Animator>());
        anime.Add(transform.Find("Note_9").gameObject.GetComponent<Animator>());

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

        StartCoroutine(SpawnNote());
    }

    IEnumerator SpawnNote()   
    {
        while(true)
        {
            int rannum = Random.Range(0, 9);
            anime[rannum].SetTrigger("Pop");
            
            yield return new WaitForSeconds(Metronome.tikTime);
        }
    }

}
