using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(Input.GetAxis("Horizontal") * 3 * Time.deltaTime, 0.0f), ForceMode2D.Force);
        if(Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, .2f), ForceMode2D.Impulse);   //Esto es lento
        }
	}
}
