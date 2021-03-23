using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineLesson5 : MonoBehaviour
{
    [SerializeField]
    private GameObject _mineAtPlayer; // пустой объект для создания мины
    [SerializeField]
    private GameObject _player;
    private GameObject _explosionObject; // переменная которой присвоен взрыв
    public GameObject mine; // префаб мины
    public GameObject explosion; //префаб взрыва

    private void Off()
    {
        gameObject.SetActive(false);
        _explosionObject.SetActive(false);
    }
    
    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.GetComponent<CapsuleCollider>())
      {
            _player.transform.position = Vector3.MoveTowards(transform.position, Vector3.forward*3, 2);
            _explosionObject = Instantiate(explosion, transform.position, Quaternion.identity);
            Invoke("Off", 2);
       }

     }
    
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.G))
        {
            
        var _mineAtPlayers = Instantiate(mine, _mineAtPlayer.transform.position, transform.rotation);
            if (Input.GetKeyDown(KeyCode.C) && _mineAtPlayers != null)
            {
                var a = Instantiate(explosion, _mineAtPlayer.transform.position, transform.rotation);
                Destroy(a, 1);
                Destroy(_mineAtPlayers);
            }

        }
    }
}
