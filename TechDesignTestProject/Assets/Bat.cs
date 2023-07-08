using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Bat : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _downSpeed;
    [SerializeField] private bool isAlive = true;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _animator.enabled = false;
        isAlive = false;
    }

    private void Update()
    {
        if (isAlive) return;
        else
        {
            Death();
            CheckDestroy();
        }
    }

    private void Death()
    {
        transform.Translate(Vector3.down * _downSpeed * Time.deltaTime);
        transform.Rotate(0f, 0f, -5f * Time.deltaTime);
    }

    private void CheckDestroy()
    {
        if (gameObject.transform.position.y > -100) return;
        else
        {
            Destroy(gameObject);
        }
    }
}
