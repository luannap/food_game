using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public PersistentData persistentData;
    public Stats stats;

    public AudioSource sound;
    public AudioClip s;

    // Start is called before the first frame update
    void Start()
    {
        persistentData = GameObject.FindGameObjectWithTag("persistent").GetComponent<PersistentData>();
        stats = GameObject.FindGameObjectWithTag("GameController").GetComponent<Stats>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sound.Play();
            persistentData.totalScore += stats.GetScore();
            Invoke("nextScene", s.length);
        }
    }

    void nextScene()
    {
        SceneManager.LoadScene("clear");

    }
}
