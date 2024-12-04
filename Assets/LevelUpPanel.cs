using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpMenu : MonoBehaviour
{
    public GameObject levelUpPanel; // O painel de level up

    void Start()
    {
        levelUpPanel.SetActive(false); // Inicia escondido
    }

    public void ShowLevelUpPanel()
    {
        levelUpPanel.SetActive(true); // Mostra o painel quando o jogador sobe de nível
    }

    public void SelectCard(int cardIndex)
    {
        // Aqui você pode definir o comportamento do card baseado no índice
        if (cardIndex == 1)
        {
            // Card 1 - Exemplo de como mudar o tiro ou a habilidade
            // Modificar o tipo de tiro, velocidade ou dano
        }
        else if (cardIndex == 2)
        {
            // Card 2 - Outro comportamento
        }

        levelUpPanel.SetActive(false); // Esconde o painel após a seleção
    }

    public Animator levelUpAnimator; // Referência para o Animator

    // Chame esta função quando o jogador subir de nível ou quando precisar esconder o painel
    public void HideLevelUpWithAnimation()
    {
        levelUpAnimator.SetTrigger("Hide"); // Aciona o trigger de animação para esconder
    }

    // Chame esta função quando precisar mostrar o painel
    public void ShowLevelUpWithAnimation()
    {
        levelUpAnimator.SetTrigger("Show"); // Aciona o trigger de animação para mostrar
    }
}
