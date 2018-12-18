using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuRotatRotator : MonoBehaviour {

    public Material newMaterial;
    static public Color red = new Color(1,0,0,1);
    static public Color white = new Color(1, 1, 1, 1);
    static public Color yellow = new Color(1f, 0.92f, 0.016f, 1f);
    static public Color orange = new Color(1,165f/255f,0,1);
    static public Color pink = new Color(1, 192f/255f, 203f/255f,1);
    float timeBetweenChange = 2f;
    float timeToChange = 0f;
    Color[] cols = { white, yellow, orange, red, pink };
    int count = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up,1);
        if(Time.timeSinceLevelLoad > timeToChange){
            newMaterial.SetColor("_Color",cols[count]);
            count++;
            if (count > 4)
                count = 0;
        }
	}
}
