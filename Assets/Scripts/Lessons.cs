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
    private MainHeroWalker _mainHeroWalker;    
   
    void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform);
        _spriteAnimator = new SpriteAnimator(_spriteAnimationsConfig);
        _spriteAnimator.StartAnimation(_characterView.SpriteRenderer, Track.walk, true, 10);
        _mainHeroWalker = new MainHeroWalker(_characterView, _spriteAnimator);
    }
   
    void Update()
    {
        _paralaxManager.Update();
        _spriteAnimator.Update();
        _mainHeroWalker.Update();
    }
}
