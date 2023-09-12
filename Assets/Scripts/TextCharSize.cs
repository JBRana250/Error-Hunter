using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script contains the default size of all the characters when font size = 1. (+ maybe other related info?)
// it will be static in case I will need to use it across scenes (ex change size of text on main menu screen)

static class TextCharSize
{
    //the information will be contained primarily in a dictionary, in a string : object format, where the string acts as the reference variable for each character object,
    // and I will just instantiate the character objects without a reference variable.

    //im having this be a class so each 'character' object can have multiple 'size' attributes, incase I need it in the future (ex diff fonts?)
    public class Character
    {
        public Vector2 charSize;

        public Character(Vector2 Size)
        {
            charSize = Size;
        }
    }

    public static Dictionary<string, Character> Characters = new Dictionary<string, Character>();

    //go through all characters that I may need and add them to the dictionary
    public static void AddCharacters()
    {
        Characters.Add("a", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("b", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("c", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("d", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("e", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("f", new Character(new Vector2(0.03f, 0.12f)));
        Characters.Add("g", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("h", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("i", new Character(new Vector2(0.03f, 0.12f)));
        Characters.Add("j", new Character(new Vector2(0.03f, 0.12f)));
        Characters.Add("k", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("l", new Character(new Vector2(0.03f, 0.12f)));
        Characters.Add("m", new Character(new Vector2(0.09f, 0.12f)));
        Characters.Add("n", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("o", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("p", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("q", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("r", new Character(new Vector2(0.04f, 0.12f)));
        Characters.Add("s", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("t", new Character(new Vector2(0.03f, 0.12f)));
        Characters.Add("u", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("v", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("w", new Character(new Vector2(0.08f, 0.12f)));
        Characters.Add("x", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("y", new Character(new Vector2(0.05f, 0.12f)));
        Characters.Add("z", new Character(new Vector2(0.05f, 0.12f)));
        Characters.Add("A", new Character(new Vector2(0.07f, 0.12f)));
        Characters.Add("B", new Character(new Vector2(0.07f, 0.12f)));
        Characters.Add("C", new Character(new Vector2(0.08f, 0.12f)));
        Characters.Add("D", new Character(new Vector2(0.08f, 0.12f)));
        Characters.Add("E", new Character(new Vector2(0.07f, 0.12f)));
        Characters.Add("F", new Character(new Vector2(0.07f, 0.12f)));
        Characters.Add("G", new Character(new Vector2(0.08f, 0.12f)));
        Characters.Add("H", new Character(new Vector2(0.08f, 0.12f)));
        Characters.Add("I", new Character(new Vector2(0.03f, 0.12f)));
        Characters.Add("J", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("K", new Character(new Vector2(0.07f, 0.12f)));
        Characters.Add("L", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("M", new Character(new Vector2(0.09f, 0.12f)));
        Characters.Add("N", new Character(new Vector2(0.08f, 0.12f)));
        Characters.Add("O", new Character(new Vector2(0.08f, 0.12f)));
        Characters.Add("P", new Character(new Vector2(0.07f, 0.12f)));
        Characters.Add("Q", new Character(new Vector2(0.08f, 0.12f)));
        Characters.Add("R", new Character(new Vector2(0.08f, 0.12f)));
        Characters.Add("S", new Character(new Vector2(0.07f, 0.12f)));
        Characters.Add("T", new Character(new Vector2(0.07f, 0.12f)));
        Characters.Add("U", new Character(new Vector2(0.08f, 0.12f)));
        Characters.Add("V", new Character(new Vector2(0.07f, 0.12f)));
        Characters.Add("W", new Character(new Vector2(0.10f, 0.12f)));
        Characters.Add("X", new Character(new Vector2(0.07f, 0.12f)));
        Characters.Add("Y", new Character(new Vector2(0.07f, 0.12f)));
        Characters.Add("Z", new Character(new Vector2(0.07f, 0.12f)));
        Characters.Add("1", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("2", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("3", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("4", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("5", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("6", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("7", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("8", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("9", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("0", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("!", new Character(new Vector2(0.04f, 0.12f)));
        Characters.Add("@", new Character(new Vector2(0.11f, 0.12f)));
        Characters.Add("#", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("$", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("%", new Character(new Vector2(0.09f, 0.12f)));
        Characters.Add("^", new Character(new Vector2(0.05f, 0.12f)));
        Characters.Add("&", new Character(new Vector2(0.07f, 0.12f)));
        Characters.Add("*", new Character(new Vector2(0.04f, 0.12f)));
        Characters.Add("(", new Character(new Vector2(0.04f, 0.12f)));
        Characters.Add(")", new Character(new Vector2(0.04f, 0.12f)));
        Characters.Add(" ", new Character(new Vector2(0.02f, 0.12f)));
        Characters.Add("\"", new Character(new Vector2(0.04f, 0.12f)));
        Characters.Add("=", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add(":", new Character(new Vector2(0.03f, 0.12f)));
        Characters.Add("[", new Character(new Vector2(0.03f, 0.12f)));
        Characters.Add("]", new Character(new Vector2(0.03f, 0.12f)));
        Characters.Add(",", new Character(new Vector2(0.03f, 0.12f)));
        Characters.Add("+", new Character(new Vector2(0.06f, 0.12f)));
        Characters.Add("-", new Character(new Vector2(0.04f, 0.12f)));
    }
}