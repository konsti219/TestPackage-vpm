using UnityEditor;

public class ExampleEditorScript
{
    [MenuItem("Window/Test")]
    static void Test()
    {
        EditorUtility.DisplayDialog("Example Script", "Opened This Dialog", "OK");
    }
}
