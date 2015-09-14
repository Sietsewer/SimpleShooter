using UnityEngine;
using System.Collections;

public class RangeFinder : MonoBehaviour {
	private Camera camera;
	public bool hasRange;
	public float range;
	// Use this for initialization
	void Start () {
		camera = gameObject.GetComponent<Camera>();
		if (this.camera == null) {
			Debug.LogError("RangeFinder needs to be attached to camera!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray ray = this.camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
		if (Physics.Raycast (ray, out hit)) {
			range = Vector3.Distance(this.transform.position, hit.point);
			hasRange = true;
		} else {
			hasRange = false;
		}
	}
}
