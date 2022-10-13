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
        var speed = _elevatorView.SliderJoint.motor;
        speed.motorSpeed = _elevatorView.SpeedMotor;
        Debug.Log(speed.motorSpeed);

        if (_elevatorView.transform.position.y <= _elevatorView.PositionY1)
        {
            
        }
        if (_elevatorView.transform.position.y >= _elevatorView.PositionY2)
        {
                        
        }        
    }
}
