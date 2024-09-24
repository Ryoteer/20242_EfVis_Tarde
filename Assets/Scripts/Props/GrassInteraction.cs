using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GrassInteraction : MonoBehaviour
{
    [Header("<color=green>Rendering</color>")]
    [SerializeField] private Renderer[] _grassRenderers;
    [SerializeField] private string _distName = "_Distance";

    private Material[] _grassMats;

    private void Start()
    {
        _grassMats = new Material[_grassRenderers.Length];

        for (int i = 0; i < _grassMats.Length; i++)
        {
            _grassMats[i] = _grassRenderers[i].material;
        }
    }

    private void Update()
    {
        for (int i = 0; i < _grassMats.Length; i++)
        {
            _grassMats[i].SetFloat(_distName, Vector3.Distance(transform.position, GameManager.Instance.Player.transform.position));
        }
    }
}
