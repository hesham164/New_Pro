using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject panel1;
    public GameObject panel2;

    private bool isPanel1Active = true;

    private void Start()
    {
        // Ensure that one panel is initially active and the other is inactive
        panel1.SetActive(true);
        panel2.SetActive(false);
    }

    public void TogglePanels()
    {
        if (isPanel1Active)
        {
            panel1.SetActive(false);
            panel2.SetActive(true);
        }
        else
        {
            panel1.SetActive(true);
            panel2.SetActive(false);
        }

        // Toggle the flag for the next click
        isPanel1Active = !isPanel1Active;
    }
}
