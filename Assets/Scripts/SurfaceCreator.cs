using UnityEngine;

public class SurfaceCreator : MonoBehaviour
{

    private Mesh mesh;

    private void OnEnable()
    {
        if (mesh == null)
        {
            mesh = new Mesh();
            mesh.name = "Surface Mesh";
        }
        Refresh();
    }

    public void Refresh()
    {
    }
}