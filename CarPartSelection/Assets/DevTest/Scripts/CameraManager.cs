
using Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private CinemachineVirtualCamera _currentCam;
    public CinemachineVirtualCamera defaultCam;
    public CinemachineVirtualCamera[] cameras;

    public static CameraManager camManager;
    private void Awake()
    {
        if (camManager == null)
            camManager = this;
        else
            Destroy(this);

    }
    public void Start()
    {
        _currentCam = defaultCam;

    }
    public void ChangeCamera(int index)
    {
        var tmpCam = _currentCam;
        _currentCam = cameras[index];
        _currentCam.gameObject.SetActive(true);
        tmpCam.gameObject.SetActive(false);

    }
}
