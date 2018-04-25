﻿using System.Collections.Generic;

namespace HotTips
{
    public class EmbeddedTipsProvider : ITipGroupProvider
    {
        private static EmbeddedTipsProvider _instance;
        public static EmbeddedTipsProvider Instance()
        {
            if (_instance == null)
            {
                _instance = new EmbeddedTipsProvider();
            }
            return _instance;
        }

        public List<string> GetGroupDefinitions()
        {
            List<string> tipGroups = new List<string>();
            tipGroups.Add(GetGroupPath("general"));
            tipGroups.Add(GetGroupPath("editor"));
            return tipGroups;
        }

        private static string GetGroupPath(string groupName)
        {
            return Utils.GetLocalExtensionDir() + "/Groups/" + groupName + ".json";
        }

        public string GetTipPath(string contentFile)
        {
            return Utils.GetLocalExtensionDir() + "/Tips/" + contentFile;
        }
    }
}