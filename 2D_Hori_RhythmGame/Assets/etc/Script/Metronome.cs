using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Metronome : MonoBehaviour
{
    AudioSource playTik;
    public AudioClip Tik;

    [SerializeField] float musicBPM; //음악 BPM
    [SerializeField] float stdBPM; //기본 BPM = 60
    [SerializeField] float musicTempo;
    [SerializeField] float stdTempo;

    float tikTime = 0;
    float nextTime = 0;

    private void Start()
    {
        playTik= GetComponent<AudioSource>(); //오디오 소스 가져오기
    }

    private void Update()
    {
        tikTime = (stdBPM / musicBPM) * (musicTempo / stdTempo);

        nextTime += Time.deltaTime;

        if(nextTime > tikTime)
        {
            StartCoroutine(PlayTik(tikTime));
            nextTime = 0;
        }
    }

    IEnumerator PlayTik(float tikTime)
    {
        Debug.Log(nextTime);//시간 오차 확인
        playTik.PlayOneShot(Tik);//사운드 재생
        yield  return new WaitForSeconds(tikTime); //설정해둔 tikTime만큼 기다림
    }


}
