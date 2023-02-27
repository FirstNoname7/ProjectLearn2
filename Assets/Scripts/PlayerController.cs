using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 20;
    private float horizontalInput;
    private float verticalInput;
    public GameObject prefab;
    private Vector3 startPos;
    private void Start()
    {
        startPos = transform.position;
        //GetBoundedMovementPosition(startPos, new Vector3(10, transform.position.y, transform.position.z), 10);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, gameObject.transform.position, prefab.transform.rotation);
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        //transform.position = transform.position.x >= 15 || transform.position.x <= -15 ? transform.localPosition.normalized * 15 : transform.position;
        //transform.position = transform.position.z >= 15 || transform.position.z < 0 ? transform.localPosition.normalized * 15 : transform.position;
        if (Math.Abs(transform.position.x) > 15 || Math.Abs(transform.position.z) > 15) //���� ������� �� x ��� z ������ 15, ��:
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -15, 15), 0, Mathf.Clamp(transform.position.z, -15, 15)); //������������ �������� � ������� Mathf.Clamp
                                                                                                                                         //(1 �������� = ���, �� ������� �������� ������������,
                                                                                                                                         //2 �������� = ����������� �������� ��� 1-��� ���������,
                                                                                                                                         //3 �������� = ������������ �������� ��� 3-��� ���������)
        //if (transform.position.z > 10)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, 10);
        //    Debug.Log(transform.position.normalized);
        //}
        //if (transform.position.z < 0)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        //    Debug.Log(transform.position.normalized);
        //}
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    }

    public Vector3 GetBoundedMovementPosition(Vector3 originPoint, Vector3 targetPoint, float maxDistance)
    {
        float distance = Vector3.Distance(originPoint, targetPoint);
        Vector3 direction = (targetPoint - originPoint).normalized;
        //Debug.Log(startPos);
        if(distance > maxDistance)
        {
            Debug.Log("�������� �� ���������");
        }
        return distance > maxDistance ? direction * maxDistance + originPoint : originPoint;
    }
}
