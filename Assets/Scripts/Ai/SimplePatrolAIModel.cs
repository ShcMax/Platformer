using UnityEngine;

public class SimplePatrolAIModel
{
    private readonly AIConfig _config;
    private Transform _target;
    private int _currentPointIndex;

    public SimplePatrolAIModel(AIConfig config)
    {
        _config = config;
        _target = GetNextPoint();
    }

    public Vector2 CalculateVelocity (Vector2 fromPosition)
    {
        var distance = Vector2.Distance(_target.position, fromPosition);

        if (distance <= _config.MinDistanceToTarget)
            _target = GetNextPoint();

        var direction = ((Vector2)_target.position - fromPosition).normalized;
        return direction * _config.Speed;
    }

    public Transform GetNextPoint()
    {
        _currentPointIndex = (_currentPointIndex + 1) % _config.Waypoints.Length;
        return _config.Waypoints[_currentPointIndex];
    }        
}
