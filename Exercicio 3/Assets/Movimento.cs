using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
	private Vector3 movimenta;
	private Rigidbody fisica;
	
	// Start is called before the first frame update
	void Start()
	{
		fisica = this.gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
    	void Update()
    	{
    	   
    	}
    	
    	private void FixedUpdate()
    	{
		movimenta.x = Input.GetAxis("Horizontal");
		movimenta.z = Input.GetAxis("Vertical");
		movimenta.y = 0;
		
		//this.gameObject.transform.Translate(movimenta);
		fisica.AddForce(movimenta);
    	}
}
