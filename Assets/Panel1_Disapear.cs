using UnityEngine;

public class Panel1_Disapear : MonoBehaviour
{
    public GameObject panel1;
    private bool isPanel1Active = true;

    private void Start()
    {
        // Ensure that panel1 is initially active
        panel1.SetActive(true);
    }

    public void Panel1_Dis()
    {
        // Toggle the visibility of panel1
        isPanel1Active = !isPanel1Active;
        panel1.SetActive(isPanel1Active);
    }
}
