using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Clickable
{
    [SerializeField] private GameObject _changeSceneButton;
    [SerializeField] private GameObject _bat;
    [SerializeField] private GameObject _popup;
    protected override void OnMouseDown()
    {
        base.OnMouseDown();

        if (isBatAlive())
        {
            ShowPopup();
        }
        else
        {
            ShowChangeSceneButton();
            Disappear();
        }
    }

    private bool isBatAlive()
    {
        if (_bat == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void ShowPopup()
    {
        _animator.SetTrigger("ClickTrigger");
        _popup.SetActive(true);
    }

    private void Disappear()
    {

    }

    private void ShowChangeSceneButton()
    {
        _popup.SetActive(false);
        _changeSceneButton.SetActive(true);
    }
}
