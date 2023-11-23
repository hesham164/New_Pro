using UnityEngine;

public class Panel2_Disapear : MonoBehaviour
{
    public GameObject panel2;
    private bool isPanel2Active = true;

    private void Start()
    {
        // Ensure that panel2 is initially active
        panel2.SetActive(true);
    }

    public void Panel2_Dis()
    {
        // Toggle the visibility of panel2
        isPanel2Active = !isPanel2Active;
        panel2.SetActive(isPanel2Active);
    }
}
