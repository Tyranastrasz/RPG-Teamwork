using UnityEngine;
using System.Collections;

public class colorChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.renderer.material.color = Color.red;
        }
	}
}
