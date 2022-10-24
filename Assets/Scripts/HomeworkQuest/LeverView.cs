using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LeverView : MonoBehaviour
{
    [SerializeField] DistanceJoint2D _distanceJoint;
    [SerializeField] HingeJoint2D _hingeJoint;
    [SerializeField] Collider2D _collider;
    private float breakForce = 1;
    private bool _active = false; 

    [SerializeField] Text _text;

    public bool Active { get => _active; set => _active = value; }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.GetComponent<CharacterView>())
        {
            _text.text = "ֽאזלטעו: Space";
            Active = true;
        }        
    }    
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Active == true)
        {
            _hingeJoint.useMotor = true;
            _distanceJoint.breakForce = breakForce;
            _text.gameObject.SetActive(false);
        }
    }
}
