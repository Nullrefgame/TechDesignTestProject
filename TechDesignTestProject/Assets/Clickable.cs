using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Animator))]

public abstract class Clickable : MonoBehaviour
{
    [SerializeField] protected BoxCollider2D _boxCollider2D;
    [SerializeField] protected Animator _animator;

    private void Awake()
    {
        _boxCollider2D = gameObject.GetComponent<BoxCollider2D>();
        _animator = gameObject.GetComponent<Animator>();
    }


    protected virtual void OnMouseDown()
    {
        Debug.Log("Click");
    }
}
