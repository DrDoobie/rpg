using UnityEngine;

[ExecuteInEditMode]
public class DepthTexture : MonoBehaviour
{
    private Camera mainCam;

    void Start () {
        mainCam = GetComponent<Camera>();
        mainCam.depthTextureMode = DepthTextureMode.Depth;
    }
}
