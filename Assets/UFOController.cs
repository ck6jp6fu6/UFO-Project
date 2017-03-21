using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {

    public float forceValue;

    private Rigidbody2D rigidbody2D = null;

    public ScoreManager scoremanager;

	// Use this for initialization
	void Start () {
        rigidbody2D = this.GetComponent<Rigidbody2D>();	
	}

    public float speed;

	// Update is called once per frame
	void Update () {
        /*if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }*/

        Vector2 force2D = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            force2D.y += forceValue;
        }
        if (Input.GetKey(KeyCode.S))
        {
            force2D.y -= forceValue;
        }
        if (Input.GetKey(KeyCode.A))
        {
            force2D.x -= forceValue;
        }
        if (Input.GetKey(KeyCode.D))
        {
            force2D.x += forceValue;
        }

        rigidbody2D.AddForce(force2D);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        scoremanager.AddScore(100);
        other.gameObject.SetActive(false);
    }
}
