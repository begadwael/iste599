using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

[CreateAssetMenu(fileName = "messages/Choice Master Text", menuName = "Choice Master Text")]
public class ChoiceMasterText : ScriptableObject
{
    [TextArea(3, 10)]
    public string message;

    public bool isQuestion;
}
