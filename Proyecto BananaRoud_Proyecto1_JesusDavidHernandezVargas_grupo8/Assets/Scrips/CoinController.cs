using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Moneda");

        if (SceneManager.GetActiveScene().name == "Nivel_1") {
            SceneManager.LoadScene("Nivel_2");
        }
        else {
            SceneManager.LoadScene("Menu_Inicio");
        }

    }
}
