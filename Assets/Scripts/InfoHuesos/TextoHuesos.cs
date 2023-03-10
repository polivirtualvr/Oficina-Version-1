using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoHuesos : MonoBehaviour
{
    public GameObject notaVisual;
    public GameObject objVisual;
    public GameObject camaraVisual;
    public GameObject objEnEscena;

    public bool activa;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&& activa == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            notaVisual.SetActive(true);
            objVisual.SetActive(true);
            camaraVisual.SetActive(true);
            objEnEscena.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.R)&& activa == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            notaVisual.SetActive(false);
            objVisual.SetActive(false);
            camaraVisual.SetActive(false);
            objEnEscena.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            activa = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            activa = false;
            notaVisual.SetActive(false);
            objVisual.SetActive(false);
            camaraVisual.SetActive(false);
            objEnEscena.SetActive(true);
        }
    }
}
