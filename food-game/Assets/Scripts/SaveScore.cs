using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveScore : MonoBehaviour
{
    const int MAX = 5;
    public PersistentData persistent;
    public Text input;
    // Start is called before the first frame update
    void Start()
    {
        persistent = GameObject.FindGameObjectWithTag("persistent").GetComponent<PersistentData>();
    }
    public void Click()
    {
        GameObject[] g = GameObject.FindGameObjectsWithTag("newhigh");
        Save();
        for (int j = 0; j < g.Length; j++)
        {
            g[j].SetActive(false);
        }
    }
    public void Save()
    {
        string pname = input.text;
        Debug.Log(pname);
        int score = persistent.totalScore;
        string nkey = "Player";
        string skey = "Score";
        for(int i = 0; i < MAX; i++)
        {
            string cname = nkey + i;
            string cscore = skey + i;
            if (!PlayerPrefs.HasKey(cname))
            {
                PlayerPrefs.SetString(cname, pname);
                PlayerPrefs.SetInt(cscore, score);
                return;
            }
            if (score > PlayerPrefs.GetInt(cscore))
            {
                string tname = PlayerPrefs.GetString(cname);
                int tscore = PlayerPrefs.GetInt(cscore);
                PlayerPrefs.SetString(cname, pname);
                PlayerPrefs.SetInt(cscore, score);
                pname = tname;
                score = tscore;
            }
        }
    }
}
