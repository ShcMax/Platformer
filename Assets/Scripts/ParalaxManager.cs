using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxManager
{
    private readonly Camera _camera;
    private readonly Transform _backTransform;
    private readonly Vector3 _backStartPosition;
    private readonly Vector3 _cameraStartPosition;
    private const float _coef = 0.3f;


    public ParalaxManager(Camera camera, Transform backTransform)
    {
        _camera = camera;
        _backTransform = backTransform;
        _backStartPosition = _backTransform.position;
        _cameraStartPosition = _camera.transform.position;
    }

    public void Update()
    {
        _backTransform.position = _backStartPosition + (_camera.transform.position - _cameraStartPosition) * _coef;
    }
}
