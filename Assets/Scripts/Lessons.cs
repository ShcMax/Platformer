using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SpriteRenderer _background;

    [SerializeField] private SpriteAnimationsConfig _spriteAnimationsConfig;
    [SerializeField] private CharacterView _characterView;

    private ParalaxManager _paralaxManager;
    private SpriteAnimator _spriteAnimator;
    
    // Start is called before the first frame update
    void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform);

        _spriteAnimator = new SpriteAnimator(_spriteAnimationsConfig);
        _spriteAnimator.StartAnimation(_characterView.SpriteRenderer, Track.walk, true, 10);
    }

    // Update is called once per frame
    void Update()
    {
        _paralaxManager.Update();
        _spriteAnimator.Update();
    }
}
