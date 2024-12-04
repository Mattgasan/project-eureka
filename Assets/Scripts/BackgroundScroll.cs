using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeedX = 0.005f; // Velocidade do scroll no eixo X
    public float scrollSpeedY = 0.005f; // Velocidade do scroll no eixo Y
    public Camera mainCamera;           // Referência à câmera

    private Renderer quadRenderer;

    void Start()
    {
        quadRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Altere o cálculo para movimento suave e controlado
        Vector2 offset = new Vector2(mainCamera.transform.position.x * scrollSpeedX, mainCamera.transform.position.y * scrollSpeedY);

        // Aplica o offset à textura de forma suave, controlando a velocidade
        quadRenderer.material.mainTextureOffset = new Vector2(offset.x, offset.y);
    }
}




