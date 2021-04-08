using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController2 : MonoBehaviour
{
    public Transform door2;
    public Transform player2;
    // public bool pointRight;
    // Start is called before the first frame update
    void Start()
    {
        //  pointRight = true;
        transform.rotation = Quaternion.Euler(0, 0, 120);

    }

    // Update is called once per frame
    void Update()
    {

        if (door2.transform.position.x > player2.transform.position.x)
        {
            /* if (!pointRight)
             {
                 transform.rotation = Quaternion.Euler(0, 0, 120);
             }*/
            //transform.position = new Vector2(player.transform.position.x + 2f, door.position.y);
            if (door2.transform.position.y - player2.transform.position.y > 1f)
            {
                transform.position = new Vector2(player2.transform.position.x + 1f, player2.transform.position.y + 1f);
            }
            else if (player2.transform.position.y - door2.transform.position.y > 2)
            {
                transform.position = new Vector2(player2.transform.position.x + 1f, player2.transform.position.y - 1f);
            }
            else if (door2.transform.position.x - player2.transform.position.x > 1)
            {
                transform.position = new Vector2(player2.transform.position.x + 1f, door2.transform.position.y);
            }
            else
                transform.position = new Vector2(player2.transform.position.x, player2.transform.position.y);


        }
    }
}
