using System;
using UnityEngine;

public class CargoView : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Collider2D _collider;
    [SerializeField] private Rigidbody2D _rigidbody;



    private void OnCollisionEnter(Collision collision)
    {
        var objectContact = collision.gameObject.GetComponent<CharacterView>();
        if (objectContact)
        {
            _rigidbody.gameObject.SetActive(false);
            _collider.isTrigger = true;            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var objectContact = collision.gameObject.GetComponent<GateView>();
        if (objectContact)
        {
            _transform = objectContact.transform;
        }
    }
}
