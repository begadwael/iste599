using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

[CreateAssetMenu(fileName = "messages/Narrator Message", menuName = "Narrator message")]
public class Narratormessage : ScriptableObject
{
    [TextArea(3, 10)]
    public string message;

    private string From = "Narrator";

    [SerializeField] public Sprite PortraitImage;
}
