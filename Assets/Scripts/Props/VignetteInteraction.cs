using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VignetteInteraction : MonoBehaviour
{
    private Animator _animator;

    private float _dist = 0.0f;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        FullScreenManager.Instance.VignettePostProcess.SetFloat(FullScreenManager.Instance.VignetteAmountName, 5.0f);
    }

    private void Update()
    {
        _dist = Vector3.Distance(GameManager.Instance.Player.transform.position, transform.position);

        if(_dist <= 5.0f && _animator.GetBool("isActive"))
        {
            FullScreenManager.Instance.VignettePostProcess.SetFloat(FullScreenManager.Instance.VignetteAmountName, _dist);
        }
        else
        {
            FullScreenManager.Instance.VignettePostProcess.SetFloat(FullScreenManager.Instance.VignetteAmountName, 5.0f);
        }
    }
}
