using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    public float vel = 2f;
    private Rigidbody2D rg;

	// Use this for initialization
	void Start () {
        rg = GetComponent<Rigidbody2D>();
        rg.velocity = vel * Vector2.left;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D otro)
	{
        if (otro.gameObject.tag == "Destructor")
            Destroy(gameObject);
	}
}
