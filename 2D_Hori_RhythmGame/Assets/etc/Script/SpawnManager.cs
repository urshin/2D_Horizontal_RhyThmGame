using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("利")]
    public GameObject Enemy1;
    public float spawnInterval = 1.0f; // 利 积己 埃拜



    public int BPM = 0;
    float currentTime = 0f;

    public Transform tfNoteAppcar = null;


    private void Start()
    {
        //StartCoroutine(SpawnEnemy1());
    }

    private void Update()
    {

        currentTime += Time.deltaTime;
        if(currentTime >= 60f/BPM)
        {
            GameObject t_note = Instantiate(Enemy1, tfNoteAppcar.position, Quaternion.identity);
            t_note.transform.SetParent(this.transform);
            currentTime -= 60f / BPM;
        }


    }

    //IEnumerator SpawnEnemy1()
    //{
    //    while (true) // 公茄 风橇
    //    {
    //        Debug.Log("enemy");
    //        Instantiate(Enemy1,transform.position+ new Vector3(0,0,10),Quaternion.identity);
    //        yield return new WaitForSecondsRealtime(spawnInterval);
    //    }
    //}
}
