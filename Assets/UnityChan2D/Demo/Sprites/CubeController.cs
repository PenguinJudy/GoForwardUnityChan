using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
    public AudioClip sound;


    private float speed = -0.2f;
    private float deadLine = -10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(this.speed, 0, 0);
        if(transform.position.x <this.deadLine){
            Destroy(gameObject);
        }
	}
    void OnCollisionEnter2D(Collision2D collision){
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}
