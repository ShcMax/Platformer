using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SpriteRenderer _background;
    [SerializeField] private SpriteAnimationsConfig _spriteAnimationsConfig;
    [SerializeField] private CharacterView _characterView;
    [SerializeField] private CannonView _cannonView;
    [SerializeField] private List<BulletView> _bullets;
    [SerializeField] private List<CoinView> _coinViews;
    [SerializeField] private List<SpikeView> _spikeViews;
    [SerializeField] private List<FinishView> _finishViews;

    [SerializeField] private ElevatorView _elevatorView;

    private ParalaxManager _paralaxManager;
    private SpriteAnimator _spriteAnimator;
    //private MainHeroWalker _mainHeroWalker;
    private AimingMuzzle _aimingMuzzle;
    private BulletsEmitter _bulletsEmitter;
    private MainHeroPhysicsWalker _mainHeroPhysicsWalker;
    private CoinsManager _coinsManager;
    private SpikesManager _spikesManager;
    private FinishManager _finishManager;
    private Elevator _elevator;
    

    void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform);
        _spriteAnimator = new SpriteAnimator(_spriteAnimationsConfig);
        _spriteAnimator.StartAnimation(_characterView.SpriteRenderer, Track.walk, true, 10);
        //_mainHeroWalker = new MainHeroWalker(_characterView, _spriteAnimator);
        _mainHeroPhysicsWalker = new MainHeroPhysicsWalker(_characterView, _spriteAnimator);
        _aimingMuzzle = new AimingMuzzle(_cannonView.transform, _characterView.transform);
        _bulletsEmitter = new BulletsEmitter(_bullets, _cannonView.MuzzleTransform);
        _coinsManager = new CoinsManager(_coinViews);
        _spikesManager = new SpikesManager(_spikeViews);
        _finishManager = new FinishManager(_finishViews);
        _elevator = new Elevator(_elevatorView);
    }

    void Update()
    {
        _paralaxManager.Update();
        _spriteAnimator.Update();
        //_mainHeroWalker.Update();
        _aimingMuzzle.Update();
        _bulletsEmitter.Update();        
    }

    private void FixedUpdate()
    {
        _mainHeroPhysicsWalker.FixedUpdate();
        _elevator.FixedUpdate();
    }

    private void OnDestroy()
    {
        _coinsManager.Dispose();
        _spikesManager.Dispose();
        _finishManager.Dispose();
    }
}
