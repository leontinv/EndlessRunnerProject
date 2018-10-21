using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Vector2 newPos;
    public float speed;
    public float Ypos;
    public float MaxHeight;
    public float MinHeight;
    public float health;
    public GameObject effect;
    public Animator camAnim;
    private Shake shake;

    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }
    void Update() {

        transform.position = Vector2.MoveTowards(transform.position, newPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && (transform.position.y < MaxHeight))
        {
            shake.CamShake();
            Instantiate(effect, transform.position, Quaternion.identity);
            newPos = new Vector2(transform.position.x, transform.position.y + Ypos);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && (transform.position.y > MinHeight))
        {
            shake.CamShake();
            Instantiate(effect, transform.position, Quaternion.identity);
            newPos = new Vector2(transform.position.x, transform.position.y - Ypos); 
        }
		
	}
}
