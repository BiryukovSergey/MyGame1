using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField]
    private BigExplosion _explosion;
    [SerializeField]
    private Mine _mine;
    [SerializeField]
    private float _force;

        private void OnTriggerEnter(Collider other)
        {
        if (gameObject.CompareTag("Enemy") || gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * -1 * _force);
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * _force * 2);
            //var a = Instantiate(_mine, transform.position, transform.rotation);
            var b = Instantiate(_explosion, transform.position, transform.rotation);

            Destroy(b.gameObject, 1);
            gameObject.SetActive(false);
            
        }
    }
}
