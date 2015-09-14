using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RangeDisplay : MonoBehaviour {
	public RangeFinder rangeFinder;
	public UnityEngine.UI.Text text;
	public string preceding = "RANGE:  ";
	public string empty = "- - -";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		text.text = preceding + (rangeFinder.hasRange ? ""+(int)rangeFinder.range : empty);
	}
}
