using UnityEngine;
using UnityEngine.UI;
using TMPro; // Si vous utilisez TextMeshPro

public class ToggleTextsOnButtonPress : MonoBehaviour
{
    // Référence au bouton
    public Button toggleButton;

    // Tableau de GameObjects contenant les textes à activer/désactiver
    public GameObject[] textsToToggle;

    void Start()
    {
        // Assurez-vous que le bouton est assigné
        if (toggleButton != null)
        {
            // Ajouter une action au clic du bouton
            toggleButton.onClick.AddListener(ToggleTexts);
        }
    }

    void ToggleTexts()
    {
        // Parcourir tous les GameObjects contenant les textes et les activer/désactiver
        foreach (GameObject textObject in textsToToggle)
        {
            // Inverser l'état actif du GameObject
            textObject.SetActive(!textObject.activeSelf);
        }
    }
}
