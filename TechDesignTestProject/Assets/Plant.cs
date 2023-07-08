using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : Clickable
{
    [SerializeField] private Transform _bullet;
    [SerializeField] private Transform _parent;

    protected override void OnMouseDown()
    {
        base.OnMouseDown();
        _animator.SetTrigger("attack");
    }

    protected void OnAttackEnded()
    {
        Debug.Log("Attack ended");
        MakeBullet();

    }

    private void MakeBullet()
    {
        Transform bullet = GameObject.Instantiate<Transform>(_bullet);
        bullet.SetParent(_parent);
    }
}
