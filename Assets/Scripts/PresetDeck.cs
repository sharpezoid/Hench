using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Preset Deck", menuName = "Cards/New Preset Deck")]
public class PresetDeck : ScriptableObject
{
    [SerializeField]
    public Deck Deck;
}
