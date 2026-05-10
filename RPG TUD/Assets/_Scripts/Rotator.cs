using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
	public float xSpeed = 3f;
	public float ySpeed = 3f;
	public float zSpeed = 3f;


    // Update is called once per frame
    void Update()
    {
		transform.Rotate(xSpeed, ySpeed, zSpeed * Time.deltaTime / 0.01f, Space.Self);
	}
}
