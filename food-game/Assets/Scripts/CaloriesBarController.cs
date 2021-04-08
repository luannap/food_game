using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class CaloriesBarController : MonoBehaviour
{
    public float BarScaleX = 2f;
    float OriginalX;
    float NewX;
    Renderer rend;
    public Stats s;
    public float CurrentEnergy;
    public Text energyText;

    // Start is called before the first frame update
    void Start()
    {
        CurrentEnergy = s.GetEnergy();
        transform.localScale = new Vector2(0.65f, 0.18f);
        rend = GetComponent<Renderer>();
        DisplayEnergy();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (BarScaleX < 0.71f && BarScaleX > 0f)
        {
            UpdateBar();
            DisplayEnergy();
        }
    }
    void UpdateBar()
    {

        OriginalX = rend.bounds.min.x;
        CurrentEnergy = s.GetEnergy();

        BarScaleX = 0.71f - ((0.71f / 100) * CurrentEnergy);
        
        transform.localScale = new Vector2(BarScaleX, 0.18f);

        NewX = rend.bounds.min.x;
        transform.Translate(new Vector2(-(OriginalX - NewX), 0f));

    }

    void DisplayEnergy()
    {
        energyText.text = "" + CurrentEnergy;
    }

}

    


