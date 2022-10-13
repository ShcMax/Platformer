using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorView: MonoBehaviour
{
    [SerializeField]
    private SliderJoint2D _sliderJoint;
    
    private float _positionY1 = -1.5f;
    private float _positionY2 = 1.2f;

    private float _speedMotor = 0.5f; 
    
    public float PositionY1 => _positionY1;
    public float PositionY2 => _positionY2;
    public float SpeedMotor => _speedMotor;

    public SliderJoint2D SliderJoint => _sliderJoint;
}
