using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    public Texture2D cursorTexture;
    private Vector2 hotspot = Vector2.zero;
    void Start()
    {
        hotspot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
        Cursor.SetCursor(cursorTexture, hotspot, CursorMode.Auto);
    }

    void Update()
    {
        
    }
    //Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
}
