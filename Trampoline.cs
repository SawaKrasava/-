using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //���������� ���� ������ �� ������� ��������
        other.GetComponent<FirstPersonMovement>().JumpStrength = 10f;
    }

    private void OnTriggerExit(Collider other)
    {
        //��������� ���� ������ �� ���������
        other.GetComponent<FirstPersonMovement>().JumpStrength = 2f;
    }
}
