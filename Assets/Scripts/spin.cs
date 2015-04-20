using UnityEngine;
using System.Collections;

public class spin : MonoBehaviour
{
	public float amount = 50f;
	
	
	void FixedUpdate ()
	{
		//doesn`t work
		//float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
		//float v = Input.GetAxis("Vertical") * amount * Time.deltaTime;
		
		float h = amount * Time.deltaTime;
		float v = amount * Time.deltaTime;
		
		GetComponent<Rigidbody>().AddTorque(transform.up * h);
		GetComponent<Rigidbody>().AddTorque(transform.right * v);
	}
}