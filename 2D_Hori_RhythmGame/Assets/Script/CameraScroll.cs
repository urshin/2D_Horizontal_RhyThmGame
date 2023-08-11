using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraScroll : MonoBehaviour
{
    public float CameraSpeed = 3f;
    

    [SerializeField] float posValue;

    Vector2 startPos;
    float newPos;

    // Start is called before the first frame update
    void Start()
    {  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(CameraSpeed * Time.deltaTime, 0, 0);
    }

}
