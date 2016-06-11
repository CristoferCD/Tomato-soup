using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

    public GameObject target;   //A donde mira la cámara
    public GameObject limIzq;   //Objeto que delimita el lado izquierdo
    public GameObject limDer;   //Objeto que delimita el lado derecho
    private Renderer rendIzq;
    private Renderer rendDer;
    private Vector3 posAnterior;
    private float offset = 5.0f;
    private float valorIzq;
    private float valorDer;

	// Use this for initialization
	void Start () {
        rendIzq = limIzq.GetComponent<Renderer>();
        rendDer = limDer.GetComponent<Renderer>();
        float anchoIzq = 2.0f * Mathf.Abs(transform.position.z - limIzq.transform.position.z) * Mathf.Tan(GetComponent<Camera>().fieldOfView * 0.5f * Mathf.Deg2Rad) * GetComponent<Camera>().aspect;
        float anchoDer = 2.0f * Mathf.Abs(transform.position.z - limDer.transform.position.z) * Mathf.Tan(GetComponent<Camera>().fieldOfView * 0.5f * Mathf.Deg2Rad) * GetComponent<Camera>().aspect;
        valorIzq = limIzq.transform.position.x + anchoIzq / 2.0f;
        valorDer = limDer.transform.position.x - anchoDer / 2.0f;
    }
	
	// Update is called once per frame
	void Update () {
        float posicion = Mathf.Min(valorDer, Mathf.Max(valorIzq, target.transform.position.x));
        transform.position = new Vector3(posicion, transform.position.y, transform.position.z);
    }
}
