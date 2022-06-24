using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] Transform[] transforms;

    [ContextMenu("Setup")]
    public void Setup()
    {
        lineRenderer.positionCount = transforms.Length;
        for (int i = 0; i < transforms.Length; i++)
        {
            lineRenderer.SetPosition(i, transforms[i].position);
        }
    }

    private void Update()
    {
        Setup();
    }

    private void OnValidate()
    {
        Setup();
    }
}