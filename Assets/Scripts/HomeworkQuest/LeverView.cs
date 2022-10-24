using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LeverView : MonoBehaviour
{
    [SerializeField] DistanceJoint2D _distanceJoint;
    [SerializeField] HingeJoint2D _hingeJoint;
    [SerializeField] Collider2D _collider;
    private float breakForce = 30;
    private bool _active = false; 

    [SerializeField] Text _text;
    

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.GetComponent<CharacterView>())
        {
            _text.gameObject.SetActive(true);
            _active = true;
        }        
    }    
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && )
        {
            _hingeJoint.useMotor = true;
            _distanceJoint.breakForce = breakForce;
            _text.text = string.Empty;
        }
    }
}
