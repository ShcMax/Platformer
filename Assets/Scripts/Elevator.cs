using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator
{
    private readonly ElevatorView _elevatorView;
    private SliderJoint2D _sliderJoint;

    public Elevator(ElevatorView elevatorView, SliderJoint2D sliderJoint)
    {
        _elevatorView = elevatorView;
        _sliderJoint = sliderJoint;
    }

    public void FixedUpdate()
    {
        _sliderJoint = _elevatorView.SliderJoint;
        JointMotor2D jointMotor2D = _sliderJoint.motor;       
        

        if (_elevatorView.transform.position.y <= _elevatorView.StartPosition)
        {
            jointMotor2D.motorSpeed = -_elevatorView.SpeedMotor;
            _sliderJoint.motor = jointMotor2D;
        }
        if (_elevatorView.transform.position.y >= _elevatorView.EndPosition)
        {
            jointMotor2D.motorSpeed = _elevatorView.SpeedMotor;
            _sliderJoint.motor = jointMotor2D;
        }        
    }
}
