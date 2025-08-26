using Godot;
using System;
using System.Diagnostics.Tracing;

public class GurpsSheetModel
{
        public GurpsInformation information { get; set; }
        public GurpsStats stats { get; set; }
        public GurpsEncumbrance encumbrance { get; set; }
        public GurpsLanguages[] languages { get; set; }
        public GurpsCulture culture { get; set; }
        public GurpsDefenseRating defense_rating { get; set; }
        public GurpsDefense defense { get; set; }
        public GurpsReactionModifier reaction_modifier { get; set; }
        public GurpsAdvantagesAndDisadvantages[] advantages_and_perks { get; set; }
        public GurpsAdvantagesAndDisadvantages[] disadvantages_and_quirks { get; set; }
        public GurpsSkills[] skills { get; set; }
        public GurpsHandWeapons[] hand_weapons { get; set; }
        public GurpsRangedWeapons[] ranged_weapons { get; set; }
        public GurpsArmorAndPossesions[] armor_and_possesions { get; set; }
        public String character_notes { get; set; }


    public struct GurpsInformation
    {
        public String name { get; set; }
        public String player { get; set; }
        public int point_total { get; set; }
        public int unspent_points { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public int size_modifier { get; set; }
        public int age { get; set; }
        public String appearance { get; set; }

    }

    public struct GurpsStats
    {
        public Stats strength { get; set; }
        public Stats dexterity { get; set; }
        public Stats intelligence { get; set; }
        public Stats health { get; set; }
        public Stats hit_points { get; set; }
        public Stats will { get; set; }
        public Stats perception { get; set; }
        public Stats fatigue_points { get; set; }
        public int basic_lift { get; set; }
        public Stats basic_speed { get; set; }
        public Stats damage { get; set; }
        public Stats basic_move { get; set; }
    }

    public struct Stats
    {
        public int stat { get; set; }
        public int cost { get; set; }
        public int current { get; set; }
    }

    public struct GurpsEncumbrance
    {
        public Encumbrance none { get; set; }
        public Encumbrance light_1 { get; set; }
        public Encumbrance medium_2 { get; set; }
        public Encumbrance heavy_3 { get; set; }
        public Encumbrance x_heavy_4 { get; set; }
    }

    public struct Encumbrance
    {
        public int basic_lift { get; set; }
        public int basic_move { get; set; }
        public int dodge { get; set; }
    }

    public struct GurpsLanguages
    {
        public String language { get; set; }
        public String spoke { get; set; }
        public String written { get; set; }
        public int cost { get; set; }
    }


    public struct GurpsCulture
    {
        public TechLevel tech_level { get; set; }
        public CulturalFamiliarity[] cultural_familiarity { get; set; }
    }

    public struct TechLevel
    {
        public int level { get; set; }
        public int cost { get; set; }
    }

    public struct CulturalFamiliarity
    {
        public String description { get; set; }
        public int cost { get; set; }
    }

    public struct GurpsDefenseRating
    {
        public int head { get; set; }
        public int torso { get; set; }
        public int arm { get; set; }
        public int hand { get; set; }
        public int leg { get; set; }
        public int foot { get; set; }
    }

    public struct GurpsDefense
    {
        public int parry { get; set; }
        public int block { get; set; }

    }

    public struct GurpsReactionModifier
    {
        public ReactionModifier appearance { get; set; }
        public ReactionModifier status { get; set; }
        public ReactionModifier[] reputation { get; set; }
    }

    public struct ReactionModifier
    {
        public String description { get; set; }
        public int modifier { get; set; }
    }


    public struct GurpsAdvantagesAndDisadvantages
    {
        public String description { get; set; }
        public int cost { get; set; }
    }


    public struct GurpsSkills
    {
        public String name { get; set; }
        public int level { get; set; }
        public int relative_level { get; set; }
        public int cost { get; set; }

    }

    public struct GurpsHandWeapons
    {
        public String weapon { get; set; }
        public int damage { get; set; }
        public int reach { get; set; }
        public int parry { get; set; }
        public String notes { get; set; }
        public int cost { get; set; }
        public int weight { get; set; }

    }

    public struct GurpsRangedWeapons
    {
        public String weapon { get; set; }
        public int damage { get; set; }
        public int accuracy { get; set; }
        public int range { get; set; }
        public float rate_of_fire_per_second { get; set; }
        public int shots { get; set; }
        public int strength { get; set; }
        public int bulk { get; set; }
        public int recoil { get; set; }
        public String notes { get; set; }
        public int cost { get; set; }
        public int weight { get; set; }
    }


    public struct GurpsArmorAndPossesions
    {
        public String item { get; set; }
        public String location { get; set; }
        public int cost { get; set; }
        public int weight { get; set; }
    }



}
