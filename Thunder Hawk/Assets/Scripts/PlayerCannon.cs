using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCannon : MonoBehaviour
{
    public GameObject projectilePref;
    public AudioClip rocketLaunch;
    private AudioSource launchAudio;
    public float speed = 18f;

    // Start is called before the first frame update
    void Start()
    {
        launchAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePref, transform.position, projectilePref.transform.rotation);
            launchAudio.PlayOneShot(rocketLaunch, 1.0f);
        }
    }
}
