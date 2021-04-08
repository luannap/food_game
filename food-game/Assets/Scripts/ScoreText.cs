using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    PersistentData persistentData;
    Text text;
    const int MAX = 5;
    // Start is called before the first frame update
    void Start()
    {
        persistentData = GameObject.FindGameObjectWithTag("persistent").GetComponent<PersistentData>();
        text = gameObject.GetComponent<Text>();
        text.text = persistentData.totalScore.ToString();
        GameObject[] g = GameObject.FindGameObjectsWithTag("newhigh");
        string key = "Score";
        for(int i = 0; i < MAX; i++)
        {
            string ckey = key + i;
            if (!PlayerPrefs.HasKey(ckey) || persistentData.totalScore > PlayerPrefs.GetInt(ckey))
            {
                for(int j = 0; j < g.Length; j++)
                {
                    g[j].SetActive(true);
                }
                return;
            }
        }
        for (int j = 0; j < g.Length; j++)
        {
            g[j].SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
