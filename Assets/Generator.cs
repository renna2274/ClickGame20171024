using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {
    public GameObject Sphere;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(gameObject);

        }
	}
}
