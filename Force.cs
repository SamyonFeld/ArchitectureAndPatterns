using UnityEngine;

public class Force : IForce
{    
    public void AddThrustForce(Rigidbody unit, float force, float minForce, float maxForce)
    {
        unit.AddForce(unit.transform.up * Mathf.Clamp(force, minForce, maxForce));
    }
}
