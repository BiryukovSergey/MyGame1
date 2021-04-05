using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Vector3 direction;
    public float speed;
    
        void Update()
        {
            direction.x = Input.GetAxis("Horizontal");
            direction.z = Input.GetAxis("Vertical");
            direction.y = Input.GetAxis("Jump");
            var move = direction * (speed * Time.deltaTime);
            transform.Translate(move);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.transform.Rotate(0, 45, 0);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.transform.Rotate(0, -45, 0);
        }
        }
}
