using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterView : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer;
    [SerializeField]
    private Rigidbody2D _rigidbody;
    [SerializeField]
    private Collider2D _collider;

    [Header("Settings")]
    [SerializeField]
    private float _walkSpeed = 1;

    [SerializeField]
    private float _animationSpeed = 3;

    [SerializeField]
    private float _jumpStartSpeed = 2;

    [SerializeField]
    private float _movingTresh = 0.1f;

    [SerializeField]
    private float _flyTresh = 0.3f;

    [SerializeField]
    private float _grounfLevel = 0f;

    [SerializeField]
    private float _acceleration = -10f;

    [SerializeField]
    private float _jumpForce = 100;

    public SpriteRenderer SpriteRenderer => _spriteRenderer;
    public float WalkSpeed => _walkSpeed;
    public float AnimationSpeed => _animationSpeed;
    public float JumpStartSpeed => _jumpStartSpeed;
    public float MovingTresh => _movingTresh; 
    public float FlyTresh => _flyTresh; 
    public float GrounfLevel => _grounfLevel;
    public float Acceleration => _acceleration;
    public float JumpForce => _jumpForce;
    public Rigidbody2D Rigidbody => _rigidbody;
    public Collider2D Collider => _collider;
}
