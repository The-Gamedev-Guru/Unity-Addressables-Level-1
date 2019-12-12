using UnityEngine;

public class SkyboxManager : MonoBehaviour
{
    [SerializeField] private Material[] _skyboxMaterials;

    public void SetSkybox(int skyboxIndex)
    {
        RenderSettings.skybox = _skyboxMaterials[skyboxIndex];
    }
}
