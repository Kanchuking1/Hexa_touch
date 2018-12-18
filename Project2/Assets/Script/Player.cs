using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour {

    public Text ScoreUI;
    public GameObject gameOverScreen;
    public GameObject scoreBox;
    public GameObject pauseButton;
    public GameObject resumeButton;
    public TextMeshProUGUI EndScore;

    static public bool alive = true;

    public float moveSpeed = 330f;
    static public int score = 0;
    public float movement = 0f;


	// Use this for initialization
	void Start () {
        alive = true;
        score = 0;
        gameOverScreen.SetActive(false);
        scoreBox.SetActive(true);
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
	}

    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    // Update is called once per frame
    void Update () {
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if(touchPosition.x > 0){
                movement = 1;
            }
            else{
                movement = -1;
            }
        }
        else{
            movement = 0;
        }
        ScoreUI.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //score = 0;
        alive = false;
        EndScore.text = score.ToString();
        scoreBox.SetActive(false);
        gameOverScreen.SetActive(true);
    }

}
