using UnityEngine;

public class PlayerMovement : MonoBehaviour
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
	public LayerMask whatIsWallrunnable;
	public LineRenderer lr;
	public ParticleSystem ps;
	public bool exploded;
	public bool paused;
	public LayerMask whatIsGrabbable;
	public LayerMask whatIsHittable;
}
