using System;
using UnityEngine;

public class SelectionController : MonoBehaviour
{
    private bool isOverCarPart = false;
    private static GameObject _target = null;


    #region action delegates
    public static Action<string> OnObjectSelected;
    public static Action OnObjectDeSelected;
    #endregion
    
    public static GameObject Target { get => _target;}

 
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            GameObject hitObject = hitInfo.transform.gameObject;
            if (hitObject.tag == "CarPart")
            {
                if (!isOverCarPart)
                {
                    _target = hitObject; 
                    isOverCarPart = true;
                }
            }
            else
            {
                if (isOverCarPart)
                {
                    _target = null; 
                    isOverCarPart = false;
                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (isOverCarPart == true && _target != null)
            {
                OnObjectSelected(_target.name);
                isOverCarPart = false;
            }
            else
                Debug.Log("not over car part.");
        }
    }

}
