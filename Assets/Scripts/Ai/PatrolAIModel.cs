using UnityEngine;

public class PatrolAIModel
{
    private readonly Transform[] _waypoints;
    private int _currentPointIndex;

    private PatrolAIModel(Transform [] waypoints)
    {
        _waypoints = waypoints;
        _currentPointIndex = 0;
    }

    public Transform GetNextTarget()
    {
        if (_waypoints == null)
            return null;

        _currentPointIndex = (_currentPointIndex + 1) % _waypoints.Length;
        return _waypoints[_currentPointIndex];
    }

    public Transform GetLosesTarget(Vector2 fromPosition)
    {
        if (_waypoints == null)
            return null;

        var closesIndex = 0;
        var closesDistance = 0f;

        for (var i = 0; i < _waypoints.Length; i++)
        {
            var distance = Vector2.Distance(fromPosition, _waypoints[i].position);

            if(closesDistance > distance)
            {
                closesDistance = distance;
                closesIndex = i;
            }
        }
        _currentPointIndex = closesIndex;
        return _waypoints[_currentPointIndex];
    }
}
