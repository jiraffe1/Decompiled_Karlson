using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GameState : MonoBehaviour
{
	public GameObject ppVolume;
	public PostProcessProfile pp;
	public bool graphics;
	public bool muted;
	public bool blur;
	public bool shake;
	public bool slowmo;
	public float fov;
	public float cameraShake;
}
