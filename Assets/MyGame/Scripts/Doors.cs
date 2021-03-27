using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Doors : MonoBehaviour
{
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }
    //private void OnTriggerStay(Collider other)
    //{
        
    //}
    private void OnTriggerStay(Collider other)
    {
        
            if (other.gameObject.CompareTag("Player"))
            {
                _anim.SetBool("IsOpen", _anim);
            }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            {
            
                _anim.SetBool("IsOpen", !_anim);
            }   
    }
}
