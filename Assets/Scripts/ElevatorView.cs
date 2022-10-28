using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorView: MonoBehaviour
{
    [SerializeField]
    private SliderJoint2D _sliderJoint;
    
    private float _startPosition = -1.8f;
    private float _endPosition = 2.3f;

    private float _speedMotor = 1f; 
    
    public float StartPosition => _startPosition;
    public float EndPosition => _endPosition;
    public float SpeedMotor => _speedMotor;

    public SliderJoint2D SliderJoint => _sliderJoint;
}
