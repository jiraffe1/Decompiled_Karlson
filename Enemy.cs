using UnityEngine;

public class Enemy : MonoBehaviour
{
	public LayerMask objectsAndPlayer;
	public GameObject startGun;
	public Transform gunPosition;
	public GameObject currentGun;
	public Transform leftArm;
	public Transform rightArm;
	public Transform head;
	public Transform hips;
	public Transform player;
}
