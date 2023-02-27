using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 30.0f; //скорость перемещения объекта, к которому прикреплен этот скрипт

    void Update()
    {
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }
}
