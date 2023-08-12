using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Map_Scrolling : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        //무한 맵을 위한 자기 자신 위치에서 다음 배경 옆으로 이동 (한 배경에 x = 18)
        transform.position += new Vector3(54,0,0); 
    }

}
