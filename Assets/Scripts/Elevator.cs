using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator
{
    private readonly ElevatorView _elevatorView;    

    public Elevator(ElevatorView elevatorView)
    {
        _elevatorView = elevatorView;       
    }

    public void FixedUpdate()
    {
        SliderJoint2D sliderJoint2D = _elevatorView.SliderJoint;
        JointMotor2D jointMotor2D = sliderJoint2D.motor;       
        

        if (_elevatorView.transform.position.y <= _elevatorView.PositionY1)
        {
            jointMotor2D.motorSpeed = -_elevatorView.SpeedMotor;
            sliderJoint2D.motor = jointMotor2D;
        }
        if (_elevatorView.transform.position.y >= _elevatorView.PositionY2)
        {
            jointMotor2D.motorSpeed = _elevatorView.SpeedMotor;
            sliderJoint2D.motor = jointMotor2D;
        }        
    }
}
