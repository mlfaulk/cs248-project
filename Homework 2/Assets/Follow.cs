using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public GameObject flurry_prefab;

	// Use this for initialization
	void Start () {
		var v3 = Input.mousePosition;
		v3.z = 10;
		v3 = Camera.main.ScreenToWorldPoint(v3);

	}
	
	// Update is called once per frame
	void Update () {
		var v3 = Input.mousePosition;
		v3.z = 10;
		v3 = Camera.main.ScreenToWorldPoint(v3);
		//flurry_prefab.transform.position = v3;
		Instantiate (flurry_prefab, v3, transform.rotation);
	}
}
