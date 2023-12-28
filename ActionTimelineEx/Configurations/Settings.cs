using System;
using System.Collections.Generic;
using ActionTimelineEx.Configurations;
using Dalamud.Configuration;
using ECommons.DalamudServices;

namespace ActionTimeline;

[Serializable]
public class Settings : IPluginConfiguration
{
    public bool ShowTimelineOnlyInDuty = false;
    public bool ShowTimelineOnlyInCombat = false;
    public bool HideTimelineInCutscene = true;
    public bool HideTimelineInQuestEvent = true;
    public bool Record = true;
    public bool RecordTargetStatus = true;
    public List<DrawingSettings> TimelineSettings = new();
    public HashSet<ushort> HideStatusIds = new HashSet<ushort>();
    public bool PrintClipping = false;
    public int PrintClippingMin = 150;
    public int PrintClippingMax = 2000;
    public int Version { get; set; } = 6;

    public void Save()
    {
        Svc.PluginInterface.SavePluginConfig(this);
    }
}
