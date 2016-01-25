using UnityEngine;
using System.Collections;

public class Firework : MonoBehaviour {

	public GameObject flurry_prefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			var v3 = Input.mousePosition;
			v3.z = 10;
			v3 = Camera.main.ScreenToWorldPoint(v3);
			Instantiate (flurry_prefab, v3, transform.rotation);
		}
	}
}
