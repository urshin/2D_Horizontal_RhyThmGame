using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Map_Scrolling : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        //���� ���� ���� �ڱ� �ڽ� ��ġ���� ���� ��� ������ �̵� (�� ��濡 x = 18)
        transform.position += new Vector3(54,0,0); 
    }

}
