﻿/*
 * Copyright © 2016 - 2017 EDDiscovery development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this
 * file except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software distributed under
 * the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF
 * ANY KIND, either express or implied. See the License for the specific language
 * governing permissions and limitations under the License.
 * 
 * EDDiscovery is not affiliated with Frontier Developments plc.
 */
namespace EDDiscovery.UserControls
{
    partial class UserControlCombatPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelStatus = new System.Windows.Forms.Panel();
            this.labelCredits = new ExtendedControls.LabelExt();
            this.labelTotalKills = new ExtendedControls.LabelExt();
            this.labelFactionKills = new ExtendedControls.LabelExt();
            this.labelBalance = new ExtendedControls.LabelExt();
            this.labelTotalCrimes = new ExtendedControls.LabelExt();
            this.labelFaction = new ExtendedControls.LabelExt();
            this.labelTotalReward = new ExtendedControls.LabelExt();
            this.labelFactionReward = new ExtendedControls.LabelExt();
            this.panelTop = new System.Windows.Forms.Panel();
            this.checkBoxCustomGridOn = new ExtendedControls.CheckBoxCustom();
            this.comboBoxCustomCampaign = new ExtendedControls.ComboBoxCustom();
            this.buttonExtEditCampaign = new ExtendedControls.ButtonExt();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataViewScrollerPanelCombat = new ExtendedControls.DataViewScrollerPanel();
            this.vScrollBarCustom1 = new ExtendedControls.VScrollBarCustom();
            this.dataGridViewCombat = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelStatus.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.dataViewScrollerPanelCombat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCombat)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.labelCredits);
            this.panelStatus.Controls.Add(this.labelTotalKills);
            this.panelStatus.Controls.Add(this.labelFactionKills);
            this.panelStatus.Controls.Add(this.labelBalance);
            this.panelStatus.Controls.Add(this.labelTotalCrimes);
            this.panelStatus.Controls.Add(this.labelFaction);
            this.panelStatus.Controls.Add(this.labelTotalReward);
            this.panelStatus.Controls.Add(this.labelFactionReward);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 32);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(798, 56);
            this.panelStatus.TabIndex = 5;
            // 
            // labelCredits
            // 
            this.labelCredits.Location = new System.Drawing.Point(4, 3);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(100, 24);
            this.labelCredits.TabIndex = 4;
            this.labelCredits.Text = "Credits";
            this.labelCredits.TextBackColor = System.Drawing.SystemColors.Control;
            this.toolTip.SetToolTip(this.labelCredits, "Current Credits");
            // 
            // labelTotalKills
            // 
            this.labelTotalKills.Location = new System.Drawing.Point(110, 3);
            this.labelTotalKills.Name = "labelTotalKills";
            this.labelTotalKills.Size = new System.Drawing.Size(100, 24);
            this.labelTotalKills.TabIndex = 4;
            this.labelTotalKills.Text = "Kills";
            this.labelTotalKills.TextBackColor = System.Drawing.SystemColors.Control;
            this.toolTip.SetToolTip(this.labelTotalKills, "Total kills in campaign");
            // 
            // labelFactionKills
            // 
            this.labelFactionKills.Location = new System.Drawing.Point(110, 29);
            this.labelFactionKills.Name = "labelFactionKills";
            this.labelFactionKills.Size = new System.Drawing.Size(100, 24);
            this.labelFactionKills.TabIndex = 4;
            this.labelFactionKills.Text = "Faction Kills";
            this.labelFactionKills.TextBackColor = System.Drawing.SystemColors.Control;
            this.toolTip.SetToolTip(this.labelFactionKills, "Faction Kills");
            // 
            // labelBalance
            // 
            this.labelBalance.Location = new System.Drawing.Point(315, 3);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(100, 24);
            this.labelBalance.TabIndex = 4;
            this.labelBalance.Text = "Balance";
            this.labelBalance.TextBackColor = System.Drawing.SystemColors.Control;
            this.toolTip.SetToolTip(this.labelBalance, "Total reward less any costs (fines, rebuys etc)");
            // 
            // labelTotalCrimes
            // 
            this.labelTotalCrimes.Location = new System.Drawing.Point(420, 3);
            this.labelTotalCrimes.Name = "labelTotalCrimes";
            this.labelTotalCrimes.Size = new System.Drawing.Size(100, 24);
            this.labelTotalCrimes.TabIndex = 4;
            this.labelTotalCrimes.Text = "Crimes";
            this.labelTotalCrimes.TextBackColor = System.Drawing.SystemColors.Control;
            this.toolTip.SetToolTip(this.labelTotalCrimes, "How many times you\'ve been caught!");
            // 
            // labelFaction
            // 
            this.labelFaction.Location = new System.Drawing.Point(3, 29);
            this.labelFaction.Name = "labelFaction";
            this.labelFaction.Size = new System.Drawing.Size(100, 24);
            this.labelFaction.TabIndex = 4;
            this.labelFaction.Text = "Faction";
            this.labelFaction.TextBackColor = System.Drawing.SystemColors.Control;
            this.toolTip.SetToolTip(this.labelFaction, "Target Faction");
            // 
            // labelTotalReward
            // 
            this.labelTotalReward.Location = new System.Drawing.Point(210, 3);
            this.labelTotalReward.Name = "labelTotalReward";
            this.labelTotalReward.Size = new System.Drawing.Size(100, 24);
            this.labelTotalReward.TabIndex = 4;
            this.labelTotalReward.Text = "TotalReward";
            this.labelTotalReward.TextBackColor = System.Drawing.SystemColors.Control;
            this.toolTip.SetToolTip(this.labelTotalReward, "Total reward");
            // 
            // labelFactionReward
            // 
            this.labelFactionReward.Location = new System.Drawing.Point(210, 29);
            this.labelFactionReward.Name = "labelFactionReward";
            this.labelFactionReward.Size = new System.Drawing.Size(100, 24);
            this.labelFactionReward.TabIndex = 4;
            this.labelFactionReward.Text = "FactionReward";
            this.labelFactionReward.TextBackColor = System.Drawing.SystemColors.Control;
            this.toolTip.SetToolTip(this.labelFactionReward, "Reward associated with destroying the faction ships");
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.checkBoxCustomGridOn);
            this.panelTop.Controls.Add(this.comboBoxCustomCampaign);
            this.panelTop.Controls.Add(this.buttonExtEditCampaign);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(798, 32);
            this.panelTop.TabIndex = 5;
            // 
            // checkBoxCustomGridOn
            // 
            this.checkBoxCustomGridOn.AutoSize = true;
            this.checkBoxCustomGridOn.CheckBoxColor = System.Drawing.Color.Gray;
            this.checkBoxCustomGridOn.CheckBoxInnerColor = System.Drawing.Color.White;
            this.checkBoxCustomGridOn.CheckColor = System.Drawing.Color.DarkBlue;
            this.checkBoxCustomGridOn.FontNerfReduction = 0.5F;
            this.checkBoxCustomGridOn.ImageButtonDisabledScaling = 0.5F;
            this.checkBoxCustomGridOn.Location = new System.Drawing.Point(284, 7);
            this.checkBoxCustomGridOn.MouseOverColor = System.Drawing.Color.CornflowerBlue;
            this.checkBoxCustomGridOn.Name = "checkBoxCustomGridOn";
            this.checkBoxCustomGridOn.Size = new System.Drawing.Size(45, 17);
            this.checkBoxCustomGridOn.TabIndex = 3;
            this.checkBoxCustomGridOn.Text = "Grid";
            this.checkBoxCustomGridOn.TickBoxReductionSize = 10;
            this.toolTip.SetToolTip(this.checkBoxCustomGridOn, "Show grid when in transparent mode");
            this.checkBoxCustomGridOn.UseVisualStyleBackColor = true;
            // 
            // comboBoxCustomCampaign
            // 
            this.comboBoxCustomCampaign.ArrowWidth = 1;
            this.comboBoxCustomCampaign.BorderColor = System.Drawing.Color.White;
            this.comboBoxCustomCampaign.ButtonColorScaling = 0.5F;
            this.comboBoxCustomCampaign.DataSource = null;
            this.comboBoxCustomCampaign.DisableBackgroundDisabledShadingGradient = false;
            this.comboBoxCustomCampaign.DisplayMember = "";
            this.comboBoxCustomCampaign.DropDownBackgroundColor = System.Drawing.Color.Gray;
            this.comboBoxCustomCampaign.DropDownHeight = 400;
            this.comboBoxCustomCampaign.DropDownWidth = 600;
            this.comboBoxCustomCampaign.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxCustomCampaign.ItemHeight = 13;
            this.comboBoxCustomCampaign.Location = new System.Drawing.Point(0, 3);
            this.comboBoxCustomCampaign.MouseOverBackgroundColor = System.Drawing.Color.Silver;
            this.comboBoxCustomCampaign.Name = "comboBoxCustomCampaign";
            this.comboBoxCustomCampaign.ScrollBarButtonColor = System.Drawing.Color.LightGray;
            this.comboBoxCustomCampaign.ScrollBarColor = System.Drawing.Color.LightGray;
            this.comboBoxCustomCampaign.ScrollBarWidth = 16;
            this.comboBoxCustomCampaign.SelectedIndex = -1;
            this.comboBoxCustomCampaign.SelectedItem = null;
            this.comboBoxCustomCampaign.SelectedValue = null;
            this.comboBoxCustomCampaign.Size = new System.Drawing.Size(222, 21);
            this.comboBoxCustomCampaign.TabIndex = 1;
            this.comboBoxCustomCampaign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.comboBoxCustomCampaign, "Select Campaign to view");
            this.comboBoxCustomCampaign.ValueMember = "";
            this.comboBoxCustomCampaign.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomCampaign_SelectedIndexChanged);
            // 
            // buttonExtEditCampaign
            // 
            this.buttonExtEditCampaign.Location = new System.Drawing.Point(228, 3);
            this.buttonExtEditCampaign.Name = "buttonExtEditCampaign";
            this.buttonExtEditCampaign.Size = new System.Drawing.Size(50, 24);
            this.buttonExtEditCampaign.TabIndex = 2;
            this.buttonExtEditCampaign.Text = "Edit";
            this.toolTip.SetToolTip(this.buttonExtEditCampaign, "Edit user defined campaign");
            this.buttonExtEditCampaign.UseVisualStyleBackColor = true;
            this.buttonExtEditCampaign.Click += new System.EventHandler(this.buttonExtEditCampaign_Click);
            // 
            // dataViewScrollerPanelCombat
            // 
            this.dataViewScrollerPanelCombat.Controls.Add(this.vScrollBarCustom1);
            this.dataViewScrollerPanelCombat.Controls.Add(this.dataGridViewCombat);
            this.dataViewScrollerPanelCombat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewScrollerPanelCombat.InternalMargin = new System.Windows.Forms.Padding(0);
            this.dataViewScrollerPanelCombat.Location = new System.Drawing.Point(0, 88);
            this.dataViewScrollerPanelCombat.Name = "dataViewScrollerPanelCombat";
            this.dataViewScrollerPanelCombat.ScrollBarWidth = 20;
            this.dataViewScrollerPanelCombat.Size = new System.Drawing.Size(798, 273);
            this.dataViewScrollerPanelCombat.TabIndex = 3;
            this.dataViewScrollerPanelCombat.VerticalScrollBarDockRight = true;
            // 
            // vScrollBarCustom1
            // 
            this.vScrollBarCustom1.ArrowBorderColor = System.Drawing.Color.LightBlue;
            this.vScrollBarCustom1.ArrowButtonColor = System.Drawing.Color.LightGray;
            this.vScrollBarCustom1.ArrowColorScaling = 0.5F;
            this.vScrollBarCustom1.ArrowDownDrawAngle = 270F;
            this.vScrollBarCustom1.ArrowUpDrawAngle = 90F;
            this.vScrollBarCustom1.BorderColor = System.Drawing.Color.White;
            this.vScrollBarCustom1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.vScrollBarCustom1.HideScrollBar = false;
            this.vScrollBarCustom1.LargeChange = 0;
            this.vScrollBarCustom1.Location = new System.Drawing.Point(778, 21);
            this.vScrollBarCustom1.Maximum = -1;
            this.vScrollBarCustom1.Minimum = 0;
            this.vScrollBarCustom1.MouseOverButtonColor = System.Drawing.Color.Green;
            this.vScrollBarCustom1.MousePressedButtonColor = System.Drawing.Color.Red;
            this.vScrollBarCustom1.Name = "vScrollBarCustom1";
            this.vScrollBarCustom1.Size = new System.Drawing.Size(20, 252);
            this.vScrollBarCustom1.SliderColor = System.Drawing.Color.DarkGray;
            this.vScrollBarCustom1.SmallChange = 1;
            this.vScrollBarCustom1.TabIndex = 1;
            this.vScrollBarCustom1.Text = "vScrollBarCustom1";
            this.vScrollBarCustom1.ThumbBorderColor = System.Drawing.Color.Yellow;
            this.vScrollBarCustom1.ThumbButtonColor = System.Drawing.Color.DarkBlue;
            this.vScrollBarCustom1.ThumbColorScaling = 0.5F;
            this.vScrollBarCustom1.ThumbDrawAngle = 0F;
            this.vScrollBarCustom1.Value = -1;
            this.vScrollBarCustom1.ValueLimited = -1;
            // 
            // dataGridViewCombat
            // 
            this.dataGridViewCombat.AllowUserToAddRows = false;
            this.dataGridViewCombat.AllowUserToDeleteRows = false;
            this.dataGridViewCombat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCombat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCombat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCombat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Event,
            this.Description,
            this.Reward});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCombat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCombat.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCombat.Name = "dataGridViewCombat";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCombat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCombat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewCombat.Size = new System.Drawing.Size(778, 273);
            this.dataGridViewCombat.TabIndex = 0;
            this.dataGridViewCombat.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCombat_CellDoubleClick);
            this.dataGridViewCombat.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridViewCombat_SortCompare);
            this.dataGridViewCombat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridViewCombat_MouseDown);
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Event
            // 
            this.Event.HeaderText = "Event";
            this.Event.Name = "Event";
            this.Event.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.FillWeight = 200F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Reward
            // 
            this.Reward.HeaderText = "Reward";
            this.Reward.Name = "Reward";
            this.Reward.ReadOnly = true;
            // 
            // UserControlCombatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataViewScrollerPanelCombat);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelTop);
            this.Name = "UserControlCombatPanel";
            this.Size = new System.Drawing.Size(798, 361);
            this.panelStatus.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.dataViewScrollerPanelCombat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCombat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private ExtendedControls.ComboBoxCustom comboBoxCustomCampaign;
        private ExtendedControls.ButtonExt buttonExtEditCampaign;
        private ExtendedControls.DataViewScrollerPanel dataViewScrollerPanelCombat;
        private ExtendedControls.VScrollBarCustom vScrollBarCustom1;
        private System.Windows.Forms.DataGridView dataGridViewCombat;
        private ExtendedControls.LabelExt labelTotalKills;
        private ExtendedControls.LabelExt labelFactionKills;
        private ExtendedControls.LabelExt labelTotalCrimes;
        private ExtendedControls.LabelExt labelTotalReward;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reward;
        private ExtendedControls.LabelExt labelFaction;
        private ExtendedControls.LabelExt labelFactionReward;
        private ExtendedControls.LabelExt labelBalance;
        private System.Windows.Forms.Panel panelStatus;
        private ExtendedControls.LabelExt labelCredits;
        private System.Windows.Forms.Panel panelTop;
        private ExtendedControls.CheckBoxCustom checkBoxCustomGridOn;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
