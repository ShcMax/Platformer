using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonView : MonoBehaviour
{
    [SerializeField]
    private Transform _muzzleTransform;

    public Transform MuzzleTransform => _muzzleTransform; 
}
