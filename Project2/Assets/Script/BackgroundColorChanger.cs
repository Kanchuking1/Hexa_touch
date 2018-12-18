using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColorChanger : MonoBehaviour {

    // Use this for initialization
    static public Color redC = new Color(1-1, 1-0, 1-0, 1);
    static public Color whiteC = new Color(1-1, 1-1, 1-1, 1);
    static public Color yellowC = new Color(1-1f, 1f-0.92f, 1f-0.016f, 1f);
    static public Color orangeC = new Color(1-1, 1f - 165f / 255f, 1f-0, 1);
    static public Color pinkC = new Color(1-1,1f -  192f / 255f, 1f - 203f / 255f, 1);

    Color[] cols = { whiteC, yellowC, orangeC, redC, pinkC };

    public Camera cam;

    float timeBetweenChange = 2f;
    float timeToChange = 0f;
    int count = 1;

    void Update()
    {
        if (Time.timeSinceLevelLoad > timeToChange)
        {
            cam.backgroundColor = cols[count];
            count++;
            if (count > 4)
                count = 0;
            timeToChange += timeBetweenChange;
        }
    }
}
