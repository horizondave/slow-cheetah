﻿namespace Microsoft.VisualStudio.SlowCheetah.VS
{
    partial class AdvancedOptionsUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedOptionsUserControl));
            this.components = new System.ComponentModel.Container();
            this.advancedOptionsDialogPageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdvancedGroupBox = new System.Windows.Forms.GroupBox();
            this.PreviewToolNameLabel = new System.Windows.Forms.Label();
            this.PreviewToolPathTextbox = new System.Windows.Forms.TextBox();
            this.OpenToolFileDialogButton = new System.Windows.Forms.Button();
            this.PreviewCommandLineLabel = new System.Windows.Forms.Label();
            this.PreviewToolCommandLineTextbox = new System.Windows.Forms.TextBox();
            this.CommandLineExplanationLabel = new System.Windows.Forms.Label();
            this.OpenToolFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.advancedOptionsDialogPageBindingSource)).BeginInit();
            this.AdvancedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedOptionsDialogPageBindingSource
            // 
            // This will be set in the Initialize method
            this.advancedOptionsDialogPageBindingSource.DataSource = null;
            // 
            // AdvancedGroupBox
            // 
            resources.ApplyResources(this.AdvancedGroupBox, "AdvancedGroupBox");
            this.AdvancedGroupBox.Controls.Add(this.PreviewToolNameLabel);
            this.AdvancedGroupBox.Controls.Add(this.PreviewToolPathTextbox);
            this.AdvancedGroupBox.Controls.Add(this.OpenToolFileDialogButton);
            this.AdvancedGroupBox.Controls.Add(this.PreviewCommandLineLabel);
            this.AdvancedGroupBox.Controls.Add(this.PreviewToolCommandLineTextbox);
            this.AdvancedGroupBox.Controls.Add(this.CommandLineExplanationLabel);
            this.AdvancedGroupBox.Name = "AdvancedGroupBox";
            this.AdvancedGroupBox.TabStop = false;
            // 
            // PreviewToolNameLabel
            // 
            resources.ApplyResources(this.PreviewToolNameLabel, "PreviewToolNameLabel");
            this.PreviewToolNameLabel.Name = "PreviewToolNameLabel";
            // 
            // PreviewToolPathTextbox
            // 
            this.PreviewToolPathTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advancedOptionsDialogPageBindingSource, "PreviewToolExecutablePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.PreviewToolPathTextbox, "PreviewToolPathTextbox");
            this.PreviewToolPathTextbox.Name = "PreviewToolPathTextbox";
            // 
            // OpenToolFileDialogButton
            // 
            resources.ApplyResources(this.OpenToolFileDialogButton, "OpenToolFileDialogButton");
            this.OpenToolFileDialogButton.Name = "OpenToolFileDialogButton";
            this.OpenToolFileDialogButton.UseVisualStyleBackColor = true;
            this.OpenToolFileDialogButton.Click += new System.EventHandler(this.OpenToolFileDialogButton_Click);
            // 
            // PreviewCommandLineLabel
            // 
            resources.ApplyResources(this.PreviewCommandLineLabel, "PreviewCommandLineLabel");
            this.PreviewCommandLineLabel.Name = "PreviewCommandLineLabel";
            // 
            // PreviewToolCommandLineTextbox
            // 
            this.PreviewToolCommandLineTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advancedOptionsDialogPageBindingSource, "PreviewToolCommandLine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            resources.ApplyResources(this.PreviewToolCommandLineTextbox, "PreviewToolCommandLineTextbox");
            this.PreviewToolCommandLineTextbox.Name = "PreviewToolCommandLineTextbox";
            // 
            // CommandLineExplanationLabel
            // 
            resources.ApplyResources(this.CommandLineExplanationLabel, "CommandLineExplanationLabel");
            this.CommandLineExplanationLabel.Name = "CommandLineExplanationLabel";
            // 
            // AdvancedOptionsUserControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdvancedGroupBox);
            this.Name = "AdvancedOptionsUserControl";
            ((System.ComponentModel.ISupportInitialize)(this.advancedOptionsDialogPageBindingSource)).EndInit();
            this.AdvancedGroupBox.ResumeLayout(false);
            this.AdvancedGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AdvancedGroupBox;
        private System.Windows.Forms.Label PreviewToolNameLabel;
        private System.Windows.Forms.TextBox PreviewToolPathTextbox;
        private System.Windows.Forms.TextBox PreviewToolCommandLineTextbox;
        private System.Windows.Forms.Label PreviewCommandLineLabel;
        private System.Windows.Forms.Button OpenToolFileDialogButton;
        private System.Windows.Forms.Label CommandLineExplanationLabel;
        private System.Windows.Forms.OpenFileDialog OpenToolFileDialog;
        private System.Windows.Forms.BindingSource advancedOptionsDialogPageBindingSource;
    }
}
