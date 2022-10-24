using System;
using UnityEngine;

public class GateView : MonoBehaviour
{
    [SerializeField] GameObject _cargo;
    [SerializeField] Transform _transform;
    [SerializeField] HingeJoint2D _hingeJoint;    

    [SerializeField] private int _id;

    private bool active = false;



    public Action<CargoView> OnLevelObjectContact;

    public int Id  => _id;

    public bool Active { get => active; set => active = value; }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        var cargo = collider.gameObject.GetComponent<CargoView>();
        if (collider.gameObject.GetComponent<CargoView>())
        {
            Active = true;           
        }
        OnLevelObjectContact?.Invoke(cargo);
    }       

    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if(Active == true)
        {
            _hingeJoint.useMotor = true;
            _cargo.transform.position = _transform.position;            
        }
    }
}
