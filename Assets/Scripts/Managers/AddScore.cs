using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public int Puntaje = 1;

    void OnDestroy()
    {
        GameController.Score += Puntaje;
    }



}
