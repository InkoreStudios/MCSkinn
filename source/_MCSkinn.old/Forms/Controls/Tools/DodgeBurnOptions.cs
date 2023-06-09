﻿//
//    MCSkinn, a 3d skin management studio for Minecraft
//    Copyright (C) 2013 Altered Softworks & MCSkinn Team
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.Drawing;
using MCSkinn.Forms.Controls;
using MCSkinn.Forms.Controls.Tools;
using MCSkinn.Scripts.Setting;
using Brushes = MCSkinn.Forms.Controls.Brushes;
using Brush = MCSkinn.Forms.Controls.Brush;

namespace MCSkinn
{
    public partial class DodgeBurnOptions : ToolOptionBase
    {
        private bool _skipSet;

        public DodgeBurnOptions()
        {
            InitializeComponent();
        }

        public bool Inverted
        {
            get { return radioButton2.Checked; }
        }

        private void DodgeBurnOptions_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = GlobalSettings.DodgeBurnIncremental;
            SetExposure(GlobalSettings.DodgeBurnExposure);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            GlobalSettings.DodgeBurnIncremental = checkBox1.Checked;
        }

        private void SetExposure(float f)
        {
            _skipSet = true;
            numericUpDown1.Value = (decimal)(f * 100.0f);
            trackBar1.Value = (int)(f * 100.0f);
            _skipSet = false;

            GlobalSettings.DodgeBurnExposure = f;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (_skipSet)
                return;

            SetExposure((float)numericUpDown1.Value / 100.0f);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (_skipSet)
                return;

            SetExposure(trackBar1.Value / 100.0f);
        }

        public override void BoxShown()
        {
            BrushPanel.Controls.Add(Brushes.BrushBox);
            Brushes.BrushBox.Location = new Point(0, 0);
            Brushes.BrushBox.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        public override void BoxHidden()
        {
            BrushPanel.Controls.Remove(Brushes.BrushBox);
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
    }
}