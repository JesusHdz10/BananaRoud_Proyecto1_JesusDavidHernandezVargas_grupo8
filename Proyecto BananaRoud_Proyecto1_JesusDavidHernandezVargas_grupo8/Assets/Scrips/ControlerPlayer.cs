using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("aca es el start");
        gameObject.transform.position = new Vector3(-3.52f,0);
    }

    // esto es la funcion update
    void Update()
    {
        Debug.Log("aca es el update");
        //gameObject.transform.position = new Vector3(gameObject.transform.position.x + 2f * Time.deltaTime, 3.62f, 0);               

        if (Input.GetKey("right") && (gameObject.transform.position.x < 6.9)) {
            gameObject.transform.Translate(3.5f * Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey("left") && (gameObject.transform.position.x >= -6.9)) {
            gameObject.transform.Translate(-3.5f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("up") && gameObject.transform.position.y < 0)
        {
            gameObject.transform.Translate(0, 3.5f * Time.deltaTime, 0);
        }
    }
}