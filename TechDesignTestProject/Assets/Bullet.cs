using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speedX;

    private void OnEnable()
    {
    }

    private void Update()
    {
        gameObject.transform.Translate(Vector3.right * _speedX * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
