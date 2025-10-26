using Godot;
using System;

public partial class Utility : Node
{

    public GurpsInformation setInformation(String name, String player,
    int pointTotal, int unspentPoints, int height,
    int weight, int sizeModifier, int age, String appearance)
    {
        return new GurpsInformation.Builder()
        .setName(name)
        .setPlayer(player)
        .setPointTotal(pointTotal)
        .setUnspentPoints(unspentPoints)
        .setHeight(height)
        .setWeight(weight)
        .setSizeModifier(sizeModifier)
        .setAge(age)
        .setAppearance(appearance)
        .build();
    }

    public void setStats()
    {

    }

    public void setEncumberance()
    {

    }

    public void setLanguages()
    {

    }

    public void setCulture() { }
    public void setDefenseRating()
    {

    }

    public void setGurpsDefense()
    {

    }

    public void setReactionModifier() { }

    public void setAdvantagesAndPerks() { }

    public void setDisadvantagesAndQuirks() { }

    public void setSkills() { }

    public void setHandWeapons() { }

    public void setRangedWeapons() { }

    public void setArmorAndPossessions() { }

    public void setCharacterNotes() { }

    public void createGurpsSheet()
    {
        
    }
}
