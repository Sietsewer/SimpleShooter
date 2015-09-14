using UnityEngine;
using System.Collections;

public class CameraForceAspect : MonoBehaviour {

	public int width = 1;
	public int height = 1;
	public Camera target;

	// Use this for initialization
	void Start () {
		target.aspect = width / height;
	}
}
