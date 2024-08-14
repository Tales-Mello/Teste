using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public float doorOpenAngle = 90.0f; // Ângulo para qual a porta deve abrir
    public float doorCloseAngle = 0.0f; // Ângulo para qual a porta deve fechar
    public float smooth = 2.0f; // Velocidade de movimento da porta

    private bool open = false; // Flag para controlar se a porta está aberta ou fechada

    void Update()
    {
        // Verifica se o jogador pressionou a tecla "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Inverte o estado da porta (abrir ou fechar)
            open = !open;
        }

        // Rotaciona a porta gradualmente para o ângulo correto baseado no estado atual
        if (open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorCloseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }
    }
}


