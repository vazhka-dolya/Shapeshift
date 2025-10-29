namespace Shapeshift
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelModelPointer = new System.Windows.Forms.Label();
            this.buttonFindModel = new System.Windows.Forms.Button();
            this.buttonInjectExtractor = new System.Windows.Forms.Button();
            this.groupExtractor = new System.Windows.Forms.GroupBox();
            this.buttonSaveModel = new System.Windows.Forms.Button();
            this.groupLoader = new System.Windows.Forms.GroupBox();
            this.buttonLoadF64 = new System.Windows.Forms.Button();
            this.buttonLoadMario = new System.Windows.Forms.Button();
            this.buttonLoadModel = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stayOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupExtractor.SuspendLayout();
            this.groupLoader.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // labelModelPointer
            // 
            resources.ApplyResources(this.labelModelPointer, "labelModelPointer");
            this.labelModelPointer.Name = "labelModelPointer";
            // 
            // buttonFindModel
            // 
            resources.ApplyResources(this.buttonFindModel, "buttonFindModel");
            this.buttonFindModel.Name = "buttonFindModel";
            this.buttonFindModel.UseVisualStyleBackColor = true;
            this.buttonFindModel.Click += new System.EventHandler(this.buttonFindModel_Click);
            // 
            // buttonInjectExtractor
            // 
            resources.ApplyResources(this.buttonInjectExtractor, "buttonInjectExtractor");
            this.buttonInjectExtractor.Name = "buttonInjectExtractor";
            this.buttonInjectExtractor.UseVisualStyleBackColor = true;
            this.buttonInjectExtractor.Click += new System.EventHandler(this.buttonInjectExtractor_Click);
            // 
            // groupExtractor
            // 
            this.groupExtractor.Controls.Add(this.buttonSaveModel);
            this.groupExtractor.Controls.Add(this.buttonInjectExtractor);
            resources.ApplyResources(this.groupExtractor, "groupExtractor");
            this.groupExtractor.Name = "groupExtractor";
            this.groupExtractor.TabStop = false;
            // 
            // buttonSaveModel
            // 
            resources.ApplyResources(this.buttonSaveModel, "buttonSaveModel");
            this.buttonSaveModel.Name = "buttonSaveModel";
            this.buttonSaveModel.UseVisualStyleBackColor = true;
            this.buttonSaveModel.Click += new System.EventHandler(this.buttonSaveModel_Click);
            // 
            // groupLoader
            // 
            this.groupLoader.Controls.Add(this.buttonLoadF64);
            this.groupLoader.Controls.Add(this.buttonLoadMario);
            this.groupLoader.Controls.Add(this.buttonLoadModel);
            resources.ApplyResources(this.groupLoader, "groupLoader");
            this.groupLoader.Name = "groupLoader";
            this.groupLoader.TabStop = false;
            // 
            // buttonLoadF64
            // 
            resources.ApplyResources(this.buttonLoadF64, "buttonLoadF64");
            this.buttonLoadF64.Name = "buttonLoadF64";
            this.buttonLoadF64.UseVisualStyleBackColor = true;
            this.buttonLoadF64.Click += new System.EventHandler(this.buttonLoadF64_Click);
            // 
            // buttonLoadMario
            // 
            resources.ApplyResources(this.buttonLoadMario, "buttonLoadMario");
            this.buttonLoadMario.Name = "buttonLoadMario";
            this.buttonLoadMario.UseVisualStyleBackColor = true;
            this.buttonLoadMario.Click += new System.EventHandler(this.buttonLoadMario_Click);
            // 
            // buttonLoadModel
            // 
            resources.ApplyResources(this.buttonLoadModel, "buttonLoadModel");
            this.buttonLoadModel.Name = "buttonLoadModel";
            this.buttonLoadModel.UseVisualStyleBackColor = true;
            this.buttonLoadModel.Click += new System.EventHandler(this.buttonLoadModel_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Name = "menuStrip2";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stayOnTopToolStripMenuItem,
            this.toolStripSeparator1,
            this.updatesToolStripMenuItem,
            this.updatesRefreshToolStripMenuItem});
            this.optionsToolStripMenuItem.Image = global::Shapeshift.Properties.Resources.updates_unknown;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            // 
            // stayOnTopToolStripMenuItem
            // 
            this.stayOnTopToolStripMenuItem.CheckOnClick = true;
            this.stayOnTopToolStripMenuItem.Image = global::Shapeshift.Properties.Resources.StayOnTop;
            this.stayOnTopToolStripMenuItem.Name = "stayOnTopToolStripMenuItem";
            resources.ApplyResources(this.stayOnTopToolStripMenuItem, "stayOnTopToolStripMenuItem");
            this.stayOnTopToolStripMenuItem.Click += new System.EventHandler(this.stayOnTopToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.Image = global::Shapeshift.Properties.Resources.updates_unknown;
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            resources.ApplyResources(this.updatesToolStripMenuItem, "updatesToolStripMenuItem");
            this.updatesToolStripMenuItem.Click += new System.EventHandler(this.updatesToolStripMenuItem_Click);
            // 
            // updatesRefreshToolStripMenuItem
            // 
            this.updatesRefreshToolStripMenuItem.Image = global::Shapeshift.Properties.Resources.updates_refresh;
            this.updatesRefreshToolStripMenuItem.Name = "updatesRefreshToolStripMenuItem";
            resources.ApplyResources(this.updatesRefreshToolStripMenuItem, "updatesRefreshToolStripMenuItem");
            this.updatesRefreshToolStripMenuItem.Click += new System.EventHandler(this.updatesRefreshToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Shapeshift.Properties.Resources.ShapeshiftIcon;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupLoader);
            this.Controls.Add(this.groupExtractor);
            this.Controls.Add(this.buttonFindModel);
            this.Controls.Add(this.labelModelPointer);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.groupExtractor.ResumeLayout(false);
            this.groupLoader.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelModelPointer;
        private System.Windows.Forms.Button buttonFindModel;
        private System.Windows.Forms.Button buttonInjectExtractor;
        private System.Windows.Forms.GroupBox groupExtractor;
        private System.Windows.Forms.Button buttonSaveModel;
        private System.Windows.Forms.GroupBox groupLoader;
        private System.Windows.Forms.Button buttonLoadModel;
        private System.Windows.Forms.Button buttonLoadMario;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stayOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesRefreshToolStripMenuItem;
        private System.Windows.Forms.Button buttonLoadF64;
    }
}

