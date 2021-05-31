using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject drone;
    Rigidbody droneBody;
    Drone _drone;

    InputAxisNames axisNames;

    IForce force;
    IControl control;
    IStabilization stabilization;
    
    private float controlForce;
    
    void Start()
    {
        axisNames = new InputAxisNames();
        force = new Force();
        control = new Control();
        stabilization = new Stabilization();
        IDroneFactory droneFactory = new DroneFactory();
        _drone = droneFactory.Create(drone);
        droneBody = _drone.drone.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetAxis(axisNames.VERTICAL) != 0)
            controlForce = control.AddControlForce(Input.GetAxis(axisNames.VERTICAL), _drone.MaxForce);
        else
            controlForce = stabilization.Stabilize(droneBody);
    }

    void FixedUpdate()
    {
        force.AddThrustForce(droneBody, controlForce, _drone.MinForce, _drone.MaxForce);
    }
}
