using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSpin : MonoBehaviour
{
	public float SpinSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, SpinSpeed, 0f, Space.Self);
    }
}
