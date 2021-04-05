using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAngle : MonoBehaviour
{
    [SerializeField] private Transform _start; //стартовая позция(поворот)
    [SerializeField] private Transform _finish; // финишняя позиция (поворот)
    private bool _check; // проверка состояния
    public float speed;
    private float move;
    void Start()
    {
        _check = true;
    }

    void Update()
    {
        move = speed * Time.deltaTime; // движение турели

        if(Quaternion.Angle(transform.rotation, _finish.rotation) < 0.5f) //если угол между стартом и финишем меньше
        {
            _check = true;
        }
        else if (Quaternion.Angle(transform.rotation, _start.rotation) < 0.5f)
        {
            _check = false;
        }

        if (_check)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, _start.rotation, move);
        }
        else 
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, _finish.rotation, move);
        }
    }
}
