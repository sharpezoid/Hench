using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The absolute bare bones of every card.
// Does nothing other than serve as the core framework.
// I should probably add "ghost" variables and functions.
[CreateAssetMenu(fileName = "New Card", menuName ="Cards/New Card")]
public class Card : ScriptableObject
{
    public string title;
    public string description;
    public Sprite artwork;
    public int cost;

    // these variables allow for cards to have effects inserted via the inspector
    public List<BaseEffect> Effects = new List<BaseEffect>(); 

    public string GetTitle()
    {
        return title;
    }
}
 