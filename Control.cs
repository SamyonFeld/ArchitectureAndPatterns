using UnityEngine;

public class Control : IControl
{
    public float AddControlForce(float axis, float maxObjectForce)
    {
        return axis * maxObjectForce;
    }
}
