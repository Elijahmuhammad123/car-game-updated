using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carcontroller : MonoBehaviour
{
    public Rigidbody2D body, Wheel_f, Wheel_b;
    public float power, bodyPower;
    Rigidbody2D rb;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
		body = GameObject.Find("body").GetComponent<Rigidbody2D>();
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            Wheel_f.AddTorque(-power);
            Wheel_b.AddTorque(-power);
			body.AddTorque(-bodyPower);
        }
        if (Input.GetKey("a"))
        {
            Wheel_f.AddTorque(power);
            Wheel_b.AddTorque(power);
			body.AddTorque(bodyPower);
        }
    }
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Respawn")
        {
            rb.velocity = Vector3.zero;
            transform.position = startPos;
        }
    }

}
