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

















}
