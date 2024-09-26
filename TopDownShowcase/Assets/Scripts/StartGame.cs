using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    string levelToLoad = "FirstLevel";
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        //IF press the button it starts the game
        if (collision.gameObject.tag == "Start")
        {

            SceneManager.LoadScene(levelToLoad);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }

    public void StartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}