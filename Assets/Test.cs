using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public string message = "Where we're going, we don't need roads.";
    public float scrollSpeed = 50;

    Rect messageRect;

    void OnGUI()
    {
        // Set up the message's rect if we haven't already
        if (messageRect.width == 0)
        {
            Vector2 dimensions = GUI.skin.label.CalcSize(new GUIContent(message));

            // Start the message past the left side of the screen
            messageRect.x = -   dimensions.x;
            messageRect.width = dimensions.x;
            messageRect.height = dimensions.y;
        }

        messageRect.x += Time.deltaTime * scrollSpeed;

        // If the message has moved past the right side, move it back to the left
        if (messageRect.x > Screen.width)
        {
            messageRect.x = -messageRect.width;
        }

        GUI.Label(messageRect, message);
    }
}
