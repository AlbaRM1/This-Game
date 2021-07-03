using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCollision : MonoBehaviour
{
    [SerializeField] private float _timeOfFalling;
    private float _timeOfDestroy = 5f;
    private Rigidbody _enemyRigidbody;

    private void Start()
    {
        _enemyRigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(FallingPlatform(_enemyRigidbody));
        }
        
    }

    IEnumerator FallingPlatform(Rigidbody _enemyRigidbody)
    {
        yield return new WaitForSeconds(_timeOfFalling);
        _enemyRigidbody.isKinematic = false;

        yield return new WaitForSeconds(_timeOfDestroy);
        Destroy(gameObject);
    }
}
