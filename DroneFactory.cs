using UnityEngine;

internal sealed class DroneFactory : IDroneFactory
{
    public Drone Create(GameObject drone)
    {
        var _drone = Object.Instantiate(drone);
        return new Drone(_drone);
    }
}
