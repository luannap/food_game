using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuButtons : MonoBehaviour {


    public AudioSource MenuClick;
    public PersistentData persistentData;

    // Use this for initialization
    void Start () {
        persistentData = GameObject.FindGameObjectWithTag("persistent").GetComponent<PersistentData>();
	}
	
	// Update is called once per frame
	void Update () {
        Time.timeScale = 1.0f;
	}

	public void LoadDirections()
	{
        MenuClick.Play();
		SceneManager.LoadScene ("directions");
	}


    public void LoadSettings(){
        MenuClick.Play();
        SceneManager.LoadScene("settings");
    }

	public void LoadGame()
	{
        MenuClick.Play();
        persistentData.totalScore = 0;
        SceneManager.LoadScene ("Level1");
	}

    public void Quit()
    {
        MenuClick.Play();
        Application.Quit();
    }
}
