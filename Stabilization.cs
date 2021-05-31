using UnityEngine;

public class Stabilization : IStabilization
{
    private float stabilizationForce = 0;
    private float speedY;
    private float speedYCoefficient = 5f;
    private float positionY = 0f;
    private float zeroVelocityTolerance = 0f;
    private float positionDifference = 0f;
    private bool positionSaved = false;
    public float Stabilize(Rigidbody drone)
    {
        speedY = drone.velocity.y;
        positionDifference = drone.transform.position.y - positionY;
        if(speedY < zeroVelocityTolerance && speedY > -zeroVelocityTolerance)
        {
            if(!positionSaved)
            {
                positionY = drone.transform.position.y;
                positionSaved = true;
            }
            stabilizationForce = -Physics.gravity.y - positionDifference - speedY * speedYCoefficient;
            return stabilizationForce;
        }
        else
        {
            if (speedY < 0) { stabilizationForce = -Physics.gravity.y - speedY * speedYCoefficient; }
            else { stabilizationForce = -speedY * speedYCoefficient; }
            return stabilizationForce;
        }
    }
}
