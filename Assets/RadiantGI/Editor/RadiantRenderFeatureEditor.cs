using UnityEditor;

namespace RadiantGI.Universal {

    [CustomEditor(typeof(RadiantRenderFeature))]
    public class RadiantRenderFeatureEditor : Editor {

        SerializedProperty renderPassEvent, renderingPath, ignorePostProcessingOption;
        SerializedProperty ignoreOverlayCameras, camerasLayerMask;

        private void OnEnable() {
            renderPassEvent = serializedObject.FindProperty("renderPassEvent");
            renderingPath = serializedObject.FindProperty("renderingPath");
            ignorePostProcessingOption = serializedObject.FindProperty("ignorePostProcessingOption");
            ignoreOverlayCameras = serializedObject.FindProperty("ignoreOverlayCameras");
            camerasLayerMask = serializedObject.FindProperty("camerasLayerMask");
        }

        public override void OnInspectorGUI() {
            EditorGUILayout.PropertyField(renderPassEvent);
            EditorGUILayout.PropertyField(ignorePostProcessingOption);
            EditorGUILayout.PropertyField(renderingPath);
            EditorGUILayout.PropertyField(ignoreOverlayCameras);
            EditorGUILayout.PropertyField(camerasLayerMask);
            EditorGUILayout.HelpBox("Please make sure the rendering path matches the rendering path of the URP asset above (working in deferred is recommended for best results). Use 'Both' only if your scene uses opaque materials that uses forward rendering path like the URP Complex Lit shader.", MessageType.Info);
        }
    }
}
