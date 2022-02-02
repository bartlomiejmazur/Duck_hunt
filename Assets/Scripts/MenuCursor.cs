using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCursor : MonoBehaviour
{
    public Texture2D cursorArrow;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.SetCursor(cursorArrow, Vector2.zero, CursorMode.ForceSoftware);
    }
}
