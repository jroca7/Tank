using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyByContact : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene(0);
            GameController.Score = 0;
        }

        if (collision.transform.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}

