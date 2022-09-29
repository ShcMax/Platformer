using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SpriteRenderer _background;

    private ParalaxManager _paralaxManager;
    
    // Start is called before the first frame update
    void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform);
    }

    // Update is called once per frame
    void Update()
    {
        _paralaxManager.Update();
    }
}
