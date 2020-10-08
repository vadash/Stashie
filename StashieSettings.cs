﻿using System.Collections.Generic;
using System.Windows.Forms;
using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace Stashie
{
    public class StashieSettings : ISettings
    {
        public List<string> AllStashNames = new List<string>();
        public Dictionary<string, ListIndexNode> CustomFilterOptions;
        public Dictionary<string, RangeNode<int>> CustomRefillOptions;

        public StashieSettings()
        {
            Enable = new ToggleNode(false);
            DropHotkey = Keys.F3;
            ExtraDelay = new RangeNode<int>(0, 0, 2000);
            BlockInput = new ToggleNode(false);
            AlwaysUseArrow = new ToggleNode(false);
            RefillCurrency = new ToggleNode(false);
            CurrencyStashTab = new ListIndexNode();
            AllowHaveMore = new ToggleNode(false);
            CustomFilterOptions = new Dictionary<string, ListIndexNode>();
            CustomRefillOptions = new Dictionary<string, RangeNode<int>>();
            VisitTabWhenDone = new ToggleNode(false);
            TabToVisitWhenDone = new RangeNode<int>(0, 0, 40);
        }


        [Menu("Stash Hotkey", 1001, 1000)] public HotkeyNode DropHotkey { get; set; }

        [Menu("Extra Delay", "Is it going too fast? Then add a delay (in ms).")]
        public RangeNode<int> ExtraDelay { get; set; }

        [Menu("Block Input", "Block user input (except: Ctrl+Alt+Delete) when dropping items to stash.")]
        public ToggleNode BlockInput { get; set; }

        [Menu("When done, go to tab.",
            "After Stashie has dropped all items to their respective tabs, then go to the following tab.")]
        public ToggleNode VisitTabWhenDone { get; set; }

        [Menu("tab (index)", 4001, 4000)] public RangeNode<int> TabToVisitWhenDone { get; set; }
        public ToggleNode RefillCurrency { get; set; }
        public ListIndexNode CurrencyStashTab { get; set; }
        public ToggleNode AllowHaveMore { get; set; }

        [Menu("Force arrow key switching", "Always switch stash tabs via keyboard arrows")]
        public ToggleNode AlwaysUseArrow { get; set; }


        public ToggleNode Enable { get; set; }

        public int[,] IgnoredCells { get; set; } =
        {
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1}
        };
    }
}