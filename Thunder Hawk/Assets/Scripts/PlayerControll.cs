using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerControll : MonoBehaviour
{
    public float xrange = 9.3f;
    public float horzInput;
    public float vertInput;
    public float speed = 10f;
    public bool youDied = false;
    public float topBound = -6f;
    public float bottomBound = -12.5f;
    public Text gameOverText;
    public Button reset;
    private AudioSource playerAudio;
    
    // Start is called before the first frame update
    void Start()
    {
       // accept.onClick.StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > xrange)
        {
            transform.position = new Vector3 (xrange, transform.position.y, transform.position.z);
        }

        if(transform.position.x < -xrange)
        {
            transform.position = new Vector3 (-xrange, transform.position.y, transform.position.z);
        }

        if(transform.position.z > topBound)
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y, topBound);
        }

        if(transform.position.z < bottomBound)
        {
            transform.position = new Vector3 (transform.position.x, transform.position.y, bottomBound);
        }

        if(youDied == false)
        {
            horzInput = Input.GetAxis("Horizontal");

            vertInput = Input.GetAxis("Vertical");

            transform.Translate(Vector3.right * horzInput * Time.deltaTime * speed);

            transform.Translate(Vector3.forward * vertInput * Time.deltaTime * speed);

        }
        
        
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("enemy"))
        {
            youDied = true;
            //Debug.Log("YOU DIED");
            gameOverText.gameObject.SetActive(true);
            reset.gameObject.SetActive(true);
        }
        
       
        
         
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}