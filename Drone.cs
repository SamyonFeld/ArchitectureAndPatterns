using UnityEngine;

public class Drone
{
    public GameObject drone;
    public float MinForce { get; } = -30.0f;
    public float MaxForce { get; } = 80.0f;

    public Drone(GameObject _drone)
    {
        drone = _drone;
    }
}
