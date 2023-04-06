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

namespace MCSkinn
{
	public partial class StampOptions : ToolOptionBase
	{
		public StampOptions()
		{
			InitializeComponent();
		}

		private void StampOptions_Load(object sender, EventArgs e)
		{
			checkBox1.Checked = GlobalSettings.PencilIncremental;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			GlobalSettings.PencilIncremental = checkBox1.Checked;
		}

		public override void BoxShown()
		{
			groupBox1.Controls.Add(Brushes.BrushBox);
			Brushes.BrushBox.Location = new Point(9, 19);
		}

		public override void BoxHidden()
		{
			groupBox1.Controls.Remove(Brushes.BrushBox);
		}
	}
}