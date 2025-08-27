using Godot;
using System;
using System.Text.Json;

public partial class DeserializeTest : Node2D
{

    public override void _Ready()
    {
        deserialize();
    }


    public override void _Process(double delta)
    {

    }

    public void deserialize()
    {
        String filePath = "resources\\gurps_character_sheet.json";
        FileAccess file = FileAccess.Open(filePath, FileAccess.ModeFlags.Read);
        if (file == null)
        {
            return;
        }

        string jsonText = file.GetAsText();
        file.Close();
        // GD.Print(jsonText);
        // JsonSerializer.Deserialize<GurpsSheetModel>(jsonText);

        //IT WORKS??
        GurpsSheetModel gurpsSheetModel = JsonSerializer.Deserialize<GurpsSheetModel>(jsonText);
        GD.Print(gurpsSheetModel.stats.health.stat);
        // GD.Print(gurpsSheetModel.stats.fatigue_points.stat);
    }
}
