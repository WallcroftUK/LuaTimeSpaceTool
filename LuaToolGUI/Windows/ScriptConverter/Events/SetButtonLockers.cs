﻿using System;
using System.Xml.Serialization;

namespace ToolStationGUI.Windows.ScriptConverter.Events
{
    [Serializable]
    public class SetButtonLockers
    {
        #region Properties

        [XmlAttribute]
        public byte Value { get; set; }

        #endregion
    }
}