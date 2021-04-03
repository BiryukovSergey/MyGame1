using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRb : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _speedRotation;
    [SerializeField]
    private string _idleTrigger;
    [SerializeField]
    private string _idleTriggerJump;
    [SerializeField]
    private string idleTriggerBackSpeed;
    private int _idleTriggerId; // id бега
    private int _idleTriggerIdJump; // id прыжка
    private int _idleTriggerIdBackSpeed;
    private Rigidbody _rb;
    private Vector3 _derection;
    private Animator _animator;

    private void Jump()
    {
        _animator.SetTrigger(_idleTriggerIdJump);
    }



    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
        _idleTriggerId = Animator.StringToHash(_idleTrigger);
        _idleTriggerIdJump = Animator.StringToHash(_idleTriggerJump);
        _idleTriggerIdBackSpeed = Animator.StringToHash(idleTriggerBackSpeed);
    }


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); 
        float vertical = Input.GetAxis("Vertical");
        
        _rb.AddForce(transform.forward * _speed * vertical);
        transform.Rotate(0, horizontal * _speedRotation, 0);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
           _animator.SetTrigger(_idleTriggerIdJump);
           
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _animator.SetFloat(_idleTriggerId,1);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            _animator.SetFloat(_idleTriggerId,0);
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            _animator.SetFloat(_idleTriggerIdBackSpeed,1);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            _animator.SetFloat(_idleTriggerIdBackSpeed,0);
        }






        /* if (Input.GetKeyDown(KeyCode.W))
         {
              // = _animator.GetFloat("Speed");
             _animator.SetFloat(_idleTriggerId, 1);
 
         }
         if (Input.GetKeyDown(KeyCode.S))
         {
             // = _animator.GetFloat("Speed");
             _animator.SetFloat(_idleTriggerId, 0);
 
         }
         */
        /*_derection.x = Input.GetAxis("Horizontal"); Код движения без физики
       _derection.z = Input.GetAxis("Vertical");
       _derection.y = Input.GetAxis("Jump");*/
        //Старый скрипт поворота и движения
        //var _move = _derection * (speed * Time.deltaTime);
        //transform.Translate(_move);
        //if (Input.GetKeyDown(KeyCode.Q))
        //    transform.rotation *= Quaternion.Euler(0, -45, 0);
        //if (Input.GetKeyDown(KeyCode.E))
        //    transform.rotation *= Quaternion.Euler(0, 45, 0);
    }
}
