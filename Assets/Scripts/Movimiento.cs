using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddTorque(-Input.GetAxis("Horizontal") * Time.deltaTime);
        //rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * 3 * Time.deltaTime, 0.0f));
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(.3f * transform.up, ForceMode2D.Impulse);
        }
        if (rb.velocity.y < -0.05) {
            Time.timeScale = 0.5f;
            rb.angularVelocity = 720 * (-Input.GetAxis("Horizontal"));
        } else
            Time.timeScale = 1;
	}
}
