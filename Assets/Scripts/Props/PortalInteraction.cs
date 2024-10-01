using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalInteraction : MonoBehaviour, IInteract
{
    private bool _isActive = false;

    private Animator _anim;

    private void Start()
    {
        _anim = GetComponentInParent<Animator>();
    }

    public void OnInteract()
    {
        _isActive = !_isActive;

        _anim.SetBool("isActive", _isActive);
        _anim.SetTrigger("onInteraction");
    }
}
