using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    [SerializeField]
    string levelToLoad = "WinScreen";
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
        //IF I hit a trophy I win
        if (collision.gameObject.tag == "Trophy")
        {

                SceneManager.LoadScene(levelToLoad);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}