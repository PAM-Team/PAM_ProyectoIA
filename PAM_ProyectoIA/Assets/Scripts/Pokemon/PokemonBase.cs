using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new pokemon")]

public class PokemonBase : ScriptableObject
{
    [SerializeField] string name;
    
    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;

    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int deffense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;

    //Needs to be reworked
    [SerializeField] List<MoveBase> knownMoves;

    public string Name
    {
        get { return name; }
    }

    public string Description
    {
        get { return description; }
    }

    public Sprite FrontSprite
    {
        get { return frontSprite; }
    }

    public Sprite BackSprite
    {
        get { return backSprite; }
    }
    public PokemonType Type1
    {
        get { return type1; }
    }

    public PokemonType Type2
    {
        get { return type2; }
    }

    public int MaxHP
    {
        get { return maxHP; }
    }

    public int Attack
    {
        get { return attack; }
    }

    public int Defense
    {
        get { return deffense; }
    }

    public int SpAttack
    {
        get { return spAttack; }
    }

    public int SpDefense
    {
        get { return spDefense; }
    }

    public int Speed
    {
        get { return speed; }
    }

    public List<MoveBase> KnownMoves
    {
        get { return knownMoves; }
    }
}

public enum PokemonType
{
    None,
    Normal,
    Fire,
    Water,
    Electric,
    Grass,
    Ice,
    Fighting,
    Posion,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon,
    Dark,
    Steel
}

public class TypeChart
{
    float[][] chart =
   {//            NOR FIR WAT ELE GRA ICE FIG POI GRO FLY PSY BUG ROC GHO DRA DAR STE
     /*NOR*/ new float[]{ 1f,1f,1f,1f,1f,1f,1f,1f,1f,1f,1f,1f,0.5f,0f, 1f, 1f, 0.5f},
     /*FIR*/ new float[]{ 1f,0.5f,0.5f,1f,2f,2f,1f,1f,1f,1f,1f,2f,0.5f,1f, 0.5f, 1f, 2f},
     /*WAT*/ new float[]{ 1f,2f,0.5f,1f,0.5f,1f,1f,1f,2f,1f,1f,1f,2f,1f, 0.5f, 1f, 1f},
     /*ELE*/ new float[]{ 1f,2f,0.5f,0.5f,1f,1f,1f,0f,2f,1f,1f,1f,1f,1f, 0.5f, 1f, 1f},
     /*GRA*/ new float[]{ 1f,0.5f,2f,1f,0.5f,1f,1f,0.5f,2f,0.5f,1f,0.5f,2f,1f, 0.5f, 1f, 0.5f},
     /*ICE*/ new float[]{ 1f,0.5f,0.5f,1f,2f,0.5f,1f,1f,2f,2f,1f,1f,1f,1f, 2f, 1f, 0.5f},
     /*FIG*/ new float[]{ 2f,1f,1f,1f,1f,2f,1f,0.5f,1f,0.5f,0.5f,0.5f,2f,0f, 1f, 2f, 2f},
     /*POI*/ new float[]{ 1f,1f,1f,1f,2f,1f,1f,0.5f,0.5f,1f,1f,1f,0.5f,0.5f, 1f, 1f, 0f},
     /*GRO*/ new float[]{ 1f,2f,1f,2f,0.5f,1f,1f,2f,0f,1f,0.5f,2f,1f,1f, 1f, 1f, 2f},
     /*FLY*/ new float[]{ 1f,1f,1f,0.5f,2f,1f,2f,1f,1f,1f,1f,2f,0.5f,1f, 1f, 1f, 0.5f},
     /*PSY*/ new float[]{ 1f,1f,1f,1f,1f,1f,2f,2f,1f,1f,0.5f,1f,1f,1f, 1f, 0f, 0.5f},
     /*BUG*/ new float[]{ 1f,0.5f,1f,1f,2f,1f,0.5f,0.5f,1f,0.5f,2f,1f,1f,0.5f, 1f, 2f, 0.5f},
     /*ROC*/ new float[]{ 1f,2f,1f,1f,1f,2f,0.5f,1f,0.5f,2f,1f,2f,1f,1f, 1f, 1f, 0.5f},
     /*GHO*/ new float[]{ 0f,1f,1f,1f,1f,1f,1f,1f,1f,1f,2f,1f,1f,2f, 1f, 0.5f, 1f},
     /*DRA*/ new float[]{ 1f,1f,1f,1f,1f,1f,1f,1f,1f,1f,2f,1f,1f,1f, 2f, 1f, 0.5f},
     /*DAR*/ new float[]{ 1f,1f,1f,1f,1f,1f,0.5f,1f,1f,1f,2f,1f,1f,2f, 1f, 0.5f, 1f},
     /*STE*/ new float[]{ 1f,0.5f,0.5f,0.5f,1f,2f,1f,1f,1f,1f,1f,1f,2f,1f, 1f, 1f, 0.5f},
    };
}