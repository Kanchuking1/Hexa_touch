using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour {

    public Rigidbody2D rb;
    public float shrinkSpeed = 4f;
    public Material newMaterial;
    static public Color red = new Color(1, 0, 0, 1);
    static public Color white = new Color(1, 1, 1, 1);
    static public Color yellow = new Color(1f, 0.92f, 0.016f, 1f);
    static public Color orange = new Color(1, 165f / 255f, 0, 1);
    static public Color pink = new Color(1, 192f / 255f, 203f / 255f, 1);
    float timeBetweenChange = 2f;
    float timeToChange = 0f;
    Color[] cols = { white, yellow, orange, red, pink };
    int count = 1;

    int colour = 0;
	// Use this for initialization
	void Start () {
        rb.rotation = Random.Range(0f,200f);
        transform.localScale = Vector3.one * 12f;
    }
	
	// Update is called once per frame
	void Update () {
        transform.localScale -= Time.deltaTime * Vector3.one * shrinkSpeed;

        if (Time.timeSinceLevelLoad > timeToChange && Player.alive == true)
        {
            newMaterial.color = cols[count];
            count++;
            if (count > 4)
                count = 0;
            timeToChange += timeBetweenChange;
        }

        if (transform.localScale.x < 1f/20f){
            if(Player.alive)
                Player.score++;
            Destroy(gameObject);
        }
	}
}
