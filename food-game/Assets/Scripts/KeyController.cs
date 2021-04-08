using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    public Transform door;
    public Transform player;
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

        /*if(door.transform.position.x > player.transform.position.x)
        {
          
            if (door.transform.position.y - player.transform.position.y > 1.5f && door.transform.position.x - player.transform.position.x > 3f)
            {
                transform.position = new Vector2(player.transform.position.x + 4f, player.transform.position.y + 1.5f);
            }
            else if (player.transform.position.y - door.transform.position.y > 2)
            {
                transform.position = new Vector2(player.transform.position.x + 4f, player.transform.position.y - 1.5f);
            }
            else if (door.transform.position.x - player.transform.position.x > 3)
            {
                transform.position = new Vector2(player.transform.position.x + 4f, door.transform.position.y);
            }
            else
                transform.position = new Vector2(door.transform.position.x, door.transform.position.y);

       

       } */

        transform.position = new Vector2(getXPos(), getYPos());

    }

    float getYPos(){
        if (door.transform.position.y - player.transform.position.y >= 1.5f) {
            return (player.transform.position.y + 1.5f);
        }
        else if (player.transform.position.y - door.transform.position.y >= 0.9f){
            return (player.transform.position.y - 0.9f);
        }
        else if (door.transform.position.x - player.transform.position.x < 0.3f &&
                (player.transform.position.y - door.transform.position.y < 0.3f || door.transform.position.y - player.transform.position.y < 0.3f))
        {
            return (player.transform.position.y);
        }
        else
            return door.transform.position.y;
    }

    float getXPos()
    {
        if (door.transform.position.x - player.transform.position.x >= 4f)
        {
            return (player.transform.position.x + 4f);
        }
        else if (door.transform.position.x - player.transform.position.x < 0.3f)
        {
            return (player.transform.position.x);
        }
        else
            return door.transform.position.x;
    }
}
