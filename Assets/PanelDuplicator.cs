using UnityEngine;

public class PanelDuplicator : MonoBehaviour
{
    public GameObject panelToDuplicate;
    private GameObject duplicatedPanel;

    public void DuplicatePanel()
    {
        if (panelToDuplicate != null)
        {
            // Create a duplicate of the panel
            duplicatedPanel = Instantiate(panelToDuplicate, panelToDuplicate.transform.parent);

            // Optionally, modify the duplicated panel's properties if needed
            // For example, adjust its position or any other settings

            // Calculate the position offset for the duplicate (e.g., move it 2 units to the right)
            float offset = 6.0f;

            // Set the position of the duplicated panel to the right of the original panel
            duplicatedPanel.transform.position = new Vector3(panelToDuplicate.transform.position.x + offset, panelToDuplicate.transform.position.y, panelToDuplicate.transform.position.z);
        }
        else
        {
            Debug.LogError("Panel to duplicate is not assigned!");
        }
    }
}
