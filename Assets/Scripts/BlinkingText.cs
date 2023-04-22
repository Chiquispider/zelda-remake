using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BlinkingText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textComponent;
    public float blinkInterval = 0.5f;

    private void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
        InvokeRepeating("ToggleVisibility", 0, blinkInterval); // call ToggleVisibility function repeatedly with given interval
    }
    private void ToggleVisibility()
    {
        textComponent.enabled = !textComponent.enabled; // toggle the text's visibility
    }
}
