using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Metronome : MonoBehaviour
{
    AudioSource playTik;
    public AudioClip Tik;

    [SerializeField] float musicBPM; //���� BPM
    [SerializeField] float stdBPM; //�⺻ BPM = 60
    [SerializeField] float musicTempo;
    [SerializeField] float stdTempo;

    float tikTime = 0;
    float nextTime = 0;

    private void Start()
    {
        playTik= GetComponent<AudioSource>(); //����� �ҽ� ��������
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
        Debug.Log(nextTime);//�ð� ���� Ȯ��
        playTik.PlayOneShot(Tik);//���� ���
        yield  return new WaitForSeconds(tikTime); //�����ص� tikTime��ŭ ��ٸ�
    }


}
