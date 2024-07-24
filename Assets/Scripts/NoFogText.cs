using UnityEngine;

[ExecuteInEditMode]
public class DisableFogForText : MonoBehaviour
{
    private bool originalFogState;

    void OnWillRenderObject()
    {
        // Save the original fog state
        originalFogState = RenderSettings.fog;
        // Disable fog
        RenderSettings.fog = false;
    }

    void OnRenderObject()
    {
        // Restore the original fog state
        RenderSettings.fog = originalFogState;
    }
}
