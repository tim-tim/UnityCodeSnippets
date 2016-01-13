using UnityEngine;
using System.Collections;
using System.Collections.Generic; // List support

public class UseCoroutine : MonoBehaviour 
{
    // 1 spin at 1 second
    [SerializeField]
    float rotationFrequency = 1;

    IEnumerator Spin()
    {
        while(true)
        {
            transform.Rotate(Vector3.up, rotationFrequency * 360 * Time.deltaTime);
            yield return 0;
        }
    }
    	
	void Start ()
    {
        //StartCoroutine("Spin");
	}
	

	void Update ()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCoroutine("Spin");
        }

        if (Input.GetMouseButtonUp(0))
        {
            StopCoroutine("Spin");
        }

    }
}