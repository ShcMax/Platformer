using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LeverView : MonoBehaviour
{
    [SerializeField] DistanceJoint2D _distanceJoint;
    [SerializeField] HingeJoint2D _hingeJoint;
    private float breakForce = 30;

    [SerializeField] Text _text;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.GetComponent<CharacterView>())
        {
            _text.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _hingeJoint.useMotor = true;
                _distanceJoint.breakForce = breakForce;
                _text.gameObject.SetActive(false);
            }
        }                  
    }    
}
