using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    private int damage = 1;
    public float speed;
    public GameObject particleEffect;
    private Shake shake;
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("player"))
        {
            shake.CamShake();
            Instantiate(particleEffect, transform.position, Quaternion.identity);
            collider.GetComponent<PlayerMovement>().health -= damage;
            Destroy(gameObject);
        }
       
    }
	void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
	}
}
