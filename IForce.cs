using UnityEngine;

public interface IForce
{
    void AddThrustForce(Rigidbody unit, float force, float maxForce, float minForce);
}
