using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawnhead : MonoBehaviour
{
	GameObject body, Wheel_b, Wheel_f ;
	Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
		body = GameObject.Find("body");
		Wheel_b= GameObject.Find("Wheel_b");
		Wheel_f = GameObject.Find("Wheel_f");
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	
		private void OnCollisionEnter2D (Collision2D c)
		{
			if (c.gameObject.tag == "Track")
			{
				body.transform.position = startPos;
				body.transform.rotation = Quaternion.identity;
				body.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
				body.GetComponent<Rigidbody2D>().angularVelocity = 0;
				Wheel_b.GetComponent<Rigidbody2D>().angularVelocity = 0;
				Wheel_f.GetComponent<Rigidbody2D>().angularVelocity = 0;
				
				
			}
			
		}
		 private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Checkpoint")
        {
            startPos = c.transform.position;
        }
    }
		
	
}

