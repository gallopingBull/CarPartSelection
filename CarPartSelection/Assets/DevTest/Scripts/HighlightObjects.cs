
using UnityEngine;

public class HighlightObjects : MonoBehaviour
{
    private Material _originalMat;
    [SerializeField] Material _highLightMat;

    private void Start()
    {
        _originalMat = GetComponent<MeshRenderer>().material;
    }
    void OnMouseOver()
    {

        GetComponent<MeshRenderer>().material = _highLightMat;
    }

    void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material = _originalMat;
    }
}
