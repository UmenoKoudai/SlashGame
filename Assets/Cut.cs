using BLINDED_AM_ME;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    [SerializeField] GameObject _cutObject;
    [SerializeField] Transform _anchorPoint;
    [SerializeField] Transform _normalDirection;
    [SerializeField] Material _cutMesh; 
    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            MeshCut.Cut(_cutObject, _anchorPoint.position, _normalDirection.position, _cutMesh);
        }
    }
}
