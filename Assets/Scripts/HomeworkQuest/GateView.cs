using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GateView : MonoBehaviour
{
    [SerializeField] HingeJoint2D _hingeJoint;

    [SerializeField] private int _id;



    public Action<CargoView> OnLevelObjectContact;

    public int Id  => _id; 

    private void Awake()
    {
        _hingeJoint.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var contactObject = collider.gameObject.GetComponent<CargoView>();

        if (contactObject)
        {
            _hingeJoint.gameObject.SetActive(true);
            OnLevelObjectContact?.Invoke(contactObject);
        }
    }
}
