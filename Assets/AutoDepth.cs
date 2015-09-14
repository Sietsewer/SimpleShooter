using UnityEngine;
using System.Collections;

public class AutoDepth : MonoBehaviour {
	public UnityStandardAssets.ImageEffects.DepthOfField depthOfField;
	public RangeFinder rangeFinder;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (rangeFinder.hasRange) {
			depthOfField.focalLength = rangeFinder.range;
		}
	}
}
