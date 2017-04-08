using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

	public GameObject player;


	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (player != null) {
			Vector3 newPos = new Vector3 (
				                 Mathf.Clamp (player.transform.position.x, -1, 1),
				                 transform.position.y,
				                 Mathf.Clamp (player.transform.position.z, -1, 1));

			transform.position = Vector3.Lerp (transform.position, newPos, 0.3f);
		} else {
			player = GameObject.Find ("Player");
		}

	}
}
