using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsRaycast : MonoBehaviour
{
    public float distanceRay;
    public Transform target;
    private void FixedUpdate()

    {
        int layerMask = 9;
        var start = transform.position;
        start.y += 1.5f; 
        RaycastHit hit;
        
        
            if (Physics.Raycast(start, transform.forward, out hit, layerMask))
            {
                 if (hit.transform.gameObject.layer == layerMask)
                    {
                        Debug.DrawRay(start, transform.forward * 3, Color.green);
                        transform.LookAt(target.position);
                        gameObject.transform.position = Vector3.MoveTowards(transform.position, target.position, 0.05f);
                    }
                
            }
        else
        {
            Debug.DrawRay(start, transform.forward * 3, Color.red);
        }
        
        
    }
}
