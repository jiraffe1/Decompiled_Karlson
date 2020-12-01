using UnityEngine;

public class Movement : MonoBehaviour
{
	public GameObject spawnWeapon;
	public PhysicMaterial deadMat;
	public Transform playerCam;
	public Transform orientation;
	public Transform gun;
	public Rigidbody rb;
	public bool grounded;
	public Transform groundChecker;
	public LayerMask whatIsGround;
	public LineRenderer lr;
	public ParticleSystem ps;
	public bool paused;
	public LayerMask whatIsGrabbable;
	public LayerMask whatIsHittable;
}
