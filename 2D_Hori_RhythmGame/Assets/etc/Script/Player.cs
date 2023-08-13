using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("겜 오브젝트")]
    [SerializeField] GameObject MainCamera; 
    private float originalCameraSpeed;



    [Header("Dash Info")]
    [SerializeField] private float dashDuration;
    [SerializeField] private float dashSpeed;
    private float dashTime;
    


    [Header("Attack Info")]
    [SerializeField] private float attackDuration;
    private float attackTime;

    Animator anime;
    void Start()
    {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        originalCameraSpeed = MainCamera.GetComponent<CameraScroll>().CameraSpeed;
        anime = GetComponentInChildren<Animator>();
    }

    void Update()
    {

        dashTime -= Time.deltaTime;
        attackTime -= Time.deltaTime;

        //조작 에니메이션
        if (Input.GetKeyDown(KeyCode.F))
        {
            dashTime = dashDuration;
            anime.SetTrigger("DashTrigger");

        }

       // anime.SetBool("Dash", dashTime > 0);



        if (Input.GetKeyDown(KeyCode.J))
        {
            //attackTime = attackDuration;
            anime.SetTrigger("AttackTrigger");
        }
        
        





        if(dashTime >0)
        {
           MainCamera.GetComponent<CameraScroll>().CameraSpeed *= dashSpeed;

        }
        else
        {
            MainCamera.GetComponent<CameraScroll>().CameraSpeed = originalCameraSpeed;

        }


        //anime.SetBool("Attack", attackTime > 0);
        
    }




}
