using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorBehavior : MonoBehaviour
{
    public Animator doorAnimator;
    public PersistentData persistentData;
    public Stats stats;

    public AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        persistentData = GameObject.FindGameObjectWithTag("persistent").GetComponent<PersistentData>();
        stats = GameObject.FindGameObjectWithTag("GameController").GetComponent<Stats>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        sound.Play();
        if (other.gameObject.tag == "Player")
        {
                Invoke("NextScene", 0.49f);
                doorAnimator.SetTrigger("isOpen");

        }

    }

    void NextScene()
    {
        persistentData.totalScore += stats.GetScore();
        SceneManager.LoadScene("Level2");
    }


}
