using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{

    public Stats s;
    public AudioSource Background;
    public AudioSource Alert;
    public AudioSource Dying;
    public AudioSource GameEnd;
    // Start is called before the first frame update
    void Start()
    {
        Background.Play();
        
    }

    // Update is called once per frame
    void Update()
    {

        if(s.GetEnergy() <= 10 && s.GetEnergy() >= 2)
        {
            Background.Pause();
            Dying.Pause();
            if (!Alert.isPlaying)
            {
                Alert.Play(0);
            }
     
        }
        else if(s.GetEnergy() < 2 && s.GetEnergy()!= 0)
        {
            Background.Pause();
            Alert.Pause();
            if (!Dying.isPlaying)
            {
                Dying.Play(0);
            }
        }
        else if(s.GetEnergy() == 0)
        {
            Background.Pause();
            Alert.Pause();
            if (!Dying.isPlaying)
            {
                Invoke("Restart", 0.05f);
            }
           

        }
        else
        {
            if(!Background.isPlaying)
            {
                Background.Play();
            }
            Alert.Pause();
            Dying.Pause();

        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
