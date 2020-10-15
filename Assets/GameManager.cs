using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public Transform character;
    public delegate void MouseClickDelegate();

    public static MouseClickDelegate OnLeftClickEvent;
    public static MouseClickDelegate OnRightClickEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnLeftClickEvent?.Invoke();
        }

        if (Input.GetMouseButtonDown(1))
        {
            OnRightClickEvent?.Invoke();
        }

    }


    public static Vector3 MousePosition()
    {
        Vector3 charPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        charPos -= charPos.z * new UnityEngine.Vector3(0, 0, 1);
        return charPos;
    }

}
