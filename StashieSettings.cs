﻿using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stashie
{
    public class StashieSettings : ISettings
    {
        public List<string> AllStashNames = [];
        public Dictionary<string, ListIndexNode> CustomFilterOptions;

        public StashieSettings()
        {
            Enable = new ToggleNode(false);
            DropHotkey = Keys.F3;
            ExtraDelay = new RangeNode<int>(0, 0, 2000);
            HoverItemDelay = new RangeNode<int>(5, 0, 2000);
            StashItemDelay = new RangeNode<int>(5, 0, 2000);
            CustomFilterOptions = [];
            VisitTabWhenDone = new ToggleNode(false);
            TabToVisitWhenDone = new RangeNode<int>(0, 0, 40);
            BackToOriginalTab = new ToggleNode(false);
        }

        [Menu("Filter File")]
        public ListNode FilterFile { get; set; } = new ListNode();

        [Menu("Stash Hotkey")]
        public HotkeyNode DropHotkey { get; set; }

        [Menu("Extra Delay", "Delay to wait after each inventory clearing attempt(in ms).")]
        public RangeNode<int> ExtraDelay { get; set; }

        [Menu("HoverItem Delay", "Delay used to wait inbetween checks for the Hoveritem (in ms).")]
        public RangeNode<int> HoverItemDelay { get; set; }

        [Menu("StashItem Delay", "Delay used to wait after moving the mouse on an item to Stash until clicking it(in ms).")]
        public RangeNode<int> StashItemDelay { get; set; }

        [Menu("When done, go to tab.",
            "After Stashie has dropped all items to their respective tabs, then go to the set tab.")]
        public ToggleNode VisitTabWhenDone { get; set; }

        [Menu("tab (index)")]
        public RangeNode<int> TabToVisitWhenDone { get; set; }

        [Menu("Go back to the tab you were in prior to Stashing")]
        public ToggleNode BackToOriginalTab { get; set; }

        public ToggleNode Enable { get; set; }

        public int[,] IgnoredCells { get; set; } =
        {
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        };

        public int[,] IgnoredExpandedCells { get; set; } =
        {
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 0}
        };
    }
}