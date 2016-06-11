using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("Horizontal")*3 * Time.deltaTime, 0, 0, Space.World);
        if(Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, .2f), ForceMode2D.Impulse);   //Esto es lento
        }
	}
}
