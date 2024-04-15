using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteAlways]
public class BendingManager : MonoBehaviour
{
    private const string BendingFeature = "_ENABLE_BENDING";

    #region MonoBehaviour

    private void Awake()
    {
        if (Application.isPlaying)
            Shader.EnableKeyword(BendingFeature);
        else
            Shader.DisableKeyword(BendingFeature);
    }
    private void OnEnable()
    {
        RenderPipelineManager.beginCameraRendering += onBeginCameraRendering;
        RenderPipelineManager.endCameraRendering += onEndCameraRendering;
    }

    private void OnDisable() 
    {
        RenderPipelineManager.beginCameraRendering -= onBeginCameraRendering;
        RenderPipelineManager.endCameraRendering -= onEndCameraRendering;
    }

    #endregion

    #region Methods

    private static void onBeginCameraRendering(ScriptableRenderContext ctx, Camera cam)
    {
        cam.cullingMatrix = Matrix4x4.Ortho(-99, 99, -99, 99, 0.001f, 99) * cam.worldToCameraMatrix;
    }
    private static void onEndCameraRendering(ScriptableRenderContext ctx, Camera cam)
    {
        cam.ResetCullingMatrix();
    }

    #endregion
}
