using UnityEngine;
using System.Collections;

public class MFCD_Zoomcontrol : MonoBehaviour {
	private Camera camera;
	public float maxFov = 60;
	public float minFov = 10;
	public float zoomSpeed = 3.0f;
	public float currentFov = 60;

	// Use this for initialization
	void Start () {
		camera = gameObject.GetComponent<Camera>();
		if (this.camera == null) {
			Debug.LogError("MFCD_Zoomcontrol needs to be attached to camera!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		float d = Input.GetAxis("Mouse ScrollWheel");
		currentFov -= (d * zoomSpeed);
		currentFov = currentFov > maxFov ? maxFov : currentFov < minFov ?  minFov : currentFov;
		this.camera.fieldOfView = currentFov;
		/*if (d > 0f)
		{

		}
		else if (d < 0f)
		{
			// scroll down
		}*/
	}
}
