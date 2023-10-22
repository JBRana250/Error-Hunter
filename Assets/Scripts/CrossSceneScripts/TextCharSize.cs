using System.Collections.Generic;
using UnityEngine;

static class TextCharSize
{
    // The Character class remains the same
    public class Character
    {
        public Vector2 charSize;

        public Character(Vector2 Size)
        {
            charSize = Size;
        }
    }

    // Initialize the dictionary with character objects. This is initialized with the elements already inside so I dont have to use add method anymore.
    public static Dictionary<string, Character> Characters = new Dictionary<string, Character>
    {
        { "a", new Character(new Vector2(0.06f, 0.12f)) },
        { "b", new Character(new Vector2(0.06f, 0.12f)) },
        { "c", new Character(new Vector2(0.06f, 0.12f)) },
        { "d", new Character(new Vector2(0.06f, 0.12f)) },
        { "e", new Character(new Vector2(0.06f, 0.12f)) },
        { "f", new Character(new Vector2(0.03f, 0.12f)) },
        { "g", new Character(new Vector2(0.06f, 0.12f)) },
        { "h", new Character(new Vector2(0.06f, 0.12f)) },
        { "i", new Character(new Vector2(0.03f, 0.12f)) },
        { "j", new Character(new Vector2(0.03f, 0.12f)) },
        { "k", new Character(new Vector2(0.06f, 0.12f)) },
        { "l", new Character(new Vector2(0.03f, 0.12f)) },
        { "m", new Character(new Vector2(0.09f, 0.12f)) },
        { "n", new Character(new Vector2(0.06f, 0.12f)) },
        { "o", new Character(new Vector2(0.06f, 0.12f)) },
        { "p", new Character(new Vector2(0.06f, 0.12f)) },
        { "q", new Character(new Vector2(0.06f, 0.12f)) },
        { "r", new Character(new Vector2(0.04f, 0.12f)) },
        { "s", new Character(new Vector2(0.06f, 0.12f)) },
        { "t", new Character(new Vector2(0.03f, 0.12f)) },
        { "u", new Character(new Vector2(0.06f, 0.12f)) },
        { "v", new Character(new Vector2(0.06f, 0.12f)) },
        { "w", new Character(new Vector2(0.08f, 0.12f)) },
        { "x", new Character(new Vector2(0.06f, 0.12f)) },
        { "y", new Character(new Vector2(0.05f, 0.12f)) },
        { "z", new Character(new Vector2(0.05f, 0.12f)) },
        { "A", new Character(new Vector2(0.07f, 0.12f)) },
        { "B", new Character(new Vector2(0.07f, 0.12f)) },
        { "C", new Character(new Vector2(0.08f, 0.12f)) },
        { "D", new Character(new Vector2(0.08f, 0.12f)) },
        { "E", new Character(new Vector2(0.07f, 0.12f)) },
        { "F", new Character(new Vector2(0.07f, 0.12f)) },
        { "G", new Character(new Vector2(0.08f, 0.12f)) },
        { "H", new Character(new Vector2(0.08f, 0.12f)) },
        { "I", new Character(new Vector2(0.03f, 0.12f)) },
        { "J", new Character(new Vector2(0.06f, 0.12f)) },
        { "K", new Character(new Vector2(0.07f, 0.12f)) },
        { "L", new Character(new Vector2(0.06f, 0.12f)) },
        { "M", new Character(new Vector2(0.09f, 0.12f)) },
        { "N", new Character(new Vector2(0.08f, 0.12f)) },
        { "O", new Character(new Vector2(0.08f, 0.12f)) },
        { "P", new Character(new Vector2(0.07f, 0.12f)) },
        { "Q", new Character(new Vector2(0.08f, 0.12f)) },
        { "R", new Character(new Vector2(0.08f, 0.12f)) },
        { "S", new Character(new Vector2(0.07f, 0.12f)) },
        { "T", new Character(new Vector2(0.07f, 0.12f)) },
        { "U", new Character(new Vector2(0.08f, 0.12f)) },
        { "V", new Character(new Vector2(0.07f, 0.12f)) },
        { "W", new Character(new Vector2(0.10f, 0.12f)) },
        { "X", new Character(new Vector2(0.07f, 0.12f)) },
        { "Y", new Character(new Vector2(0.07f, 0.12f)) },
        { "Z", new Character(new Vector2(0.07f, 0.12f)) },
        { "1", new Character(new Vector2(0.06f, 0.12f)) },
        { "2", new Character(new Vector2(0.06f, 0.12f)) },
        { "3", new Character(new Vector2(0.06f, 0.12f)) },
        { "4", new Character(new Vector2(0.06f, 0.12f)) },
        { "5", new Character(new Vector2(0.06f, 0.12f)) },
        { "6", new Character(new Vector2(0.06f, 0.12f)) },
        { "7", new Character(new Vector2(0.06f, 0.12f)) },
        { "8", new Character(new Vector2(0.06f, 0.12f)) },
        { "9", new Character(new Vector2(0.06f, 0.12f)) },
        { "0", new Character(new Vector2(0.06f, 0.12f)) },
        { "!", new Character(new Vector2(0.04f, 0.12f)) },
        { "@", new Character(new Vector2(0.11f, 0.12f)) },
        { "#", new Character(new Vector2(0.06f, 0.12f)) },
        { "$", new Character(new Vector2(0.06f, 0.12f)) },
        { "%", new Character(new Vector2(0.09f, 0.12f)) },
        { "^", new Character(new Vector2(0.05f, 0.12f)) },
        { "&", new Character(new Vector2(0.07f, 0.12f)) },
        { "*", new Character(new Vector2(0.04f, 0.12f)) },
        { "(", new Character(new Vector2(0.04f, 0.12f)) },
        { ")", new Character(new Vector2(0.04f, 0.12f)) },
        { " ", new Character(new Vector2(0.02f, 0.12f)) },
        { "\"", new Character(new Vector2(0.04f, 0.12f)) },
        { "=", new Character(new Vector2(0.06f, 0.12f)) },
        { ":", new Character(new Vector2(0.03f, 0.12f)) },
        { "[", new Character(new Vector2(0.03f, 0.12f)) },
        { "]", new Character(new Vector2(0.03f, 0.12f)) },
        { ",", new Character(new Vector2(0.03f, 0.12f)) },
        { "+", new Character(new Vector2(0.06f, 0.12f)) },
        { "-", new Character(new Vector2(0.04f, 0.12f)) }
    };
}
