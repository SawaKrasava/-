using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Увеличение силы прыжка на большее значение
        other.GetComponent<FirstPersonMovement>().JumpStrength = 10f;
    }

    private void OnTriggerExit(Collider other)
    {
        //Понижение силы прыжка до исходного
        other.GetComponent<FirstPersonMovement>().JumpStrength = 2f;
    }
}
