
namespace TP_NOTE
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openaudio = new System.Windows.Forms.Button();
            this.Lecture = new System.Windows.Forms.Button();
            this.STOP = new System.Windows.Forms.Button();
            this.RECORD = new System.Windows.Forms.Button();
            this.RECORDSTOP = new System.Windows.Forms.Button();
            this.List_Son = new System.Windows.Forms.ListBox();
            this.ChoosePath = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DesignSong = new TP_NOTE.VerticalBar();
            this.DesignSong2 = new TP_NOTE.VerticalBar();
            this.DesignSong3 = new TP_NOTE.VerticalBar();
            this.DesignSong4 = new TP_NOTE.VerticalBar();
            this.DesignSong5 = new TP_NOTE.VerticalBar();
            this.DesignSong6 = new TP_NOTE.VerticalBar();
            this.DesignSong7 = new TP_NOTE.VerticalBar();
            this.SuspendLayout();
            // 
            // openaudio
            // 
            this.openaudio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openaudio.Image = ((System.Drawing.Image)(resources.GetObject("openaudio.Image")));
            this.openaudio.Location = new System.Drawing.Point(38, 257);
            this.openaudio.Name = "openaudio";
            this.openaudio.Size = new System.Drawing.Size(63, 62);
            this.openaudio.TabIndex = 0;
            this.openaudio.UseVisualStyleBackColor = false;
            this.openaudio.Click += new System.EventHandler(this.openaudio_Click);
            // 
            // Lecture
            // 
            this.Lecture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Lecture.Image = ((System.Drawing.Image)(resources.GetObject("Lecture.Image")));
            this.Lecture.Location = new System.Drawing.Point(107, 257);
            this.Lecture.Name = "Lecture";
            this.Lecture.Size = new System.Drawing.Size(293, 62);
            this.Lecture.TabIndex = 1;
            this.Lecture.UseVisualStyleBackColor = false;
            this.Lecture.Click += new System.EventHandler(this.Lecture_Click);
            // 
            // STOP
            // 
            this.STOP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.STOP.Image = ((System.Drawing.Image)(resources.GetObject("STOP.Image")));
            this.STOP.Location = new System.Drawing.Point(406, 257);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(66, 62);
            this.STOP.TabIndex = 2;
            this.STOP.UseVisualStyleBackColor = false;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // RECORD
            // 
            this.RECORD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RECORD.Image = ((System.Drawing.Image)(resources.GetObject("RECORD.Image")));
            this.RECORD.Location = new System.Drawing.Point(478, 81);
            this.RECORD.Name = "RECORD";
            this.RECORD.Size = new System.Drawing.Size(66, 56);
            this.RECORD.TabIndex = 3;
            this.RECORD.UseVisualStyleBackColor = false;
            this.RECORD.Click += new System.EventHandler(this.RECORD_Click);
            // 
            // RECORDSTOP
            // 
            this.RECORDSTOP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RECORDSTOP.Image = ((System.Drawing.Image)(resources.GetObject("RECORDSTOP.Image")));
            this.RECORDSTOP.Location = new System.Drawing.Point(478, 81);
            this.RECORDSTOP.Name = "RECORDSTOP";
            this.RECORDSTOP.Size = new System.Drawing.Size(66, 56);
            this.RECORDSTOP.TabIndex = 4;
            this.RECORDSTOP.UseVisualStyleBackColor = false;
            this.RECORDSTOP.Visible = false;
            this.RECORDSTOP.Click += new System.EventHandler(this.RECORDSTOP_Click);
            // 
            // List_Son
            // 
            this.List_Son.FormattingEnabled = true;
            this.List_Son.ItemHeight = 16;
            this.List_Son.Location = new System.Drawing.Point(38, 24);
            this.List_Son.Name = "List_Son";
            this.List_Son.Size = new System.Drawing.Size(434, 212);
            this.List_Son.TabIndex = 5;
            this.List_Son.SelectedIndexChanged += new System.EventHandler(this.List_Son_SelectedIndexChanged);
            // 
            // ChoosePath
            // 
            this.ChoosePath.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ChoosePath.Image = ((System.Drawing.Image)(resources.GetObject("ChoosePath.Image")));
            this.ChoosePath.Location = new System.Drawing.Point(478, 24);
            this.ChoosePath.Name = "ChoosePath";
            this.ChoosePath.Size = new System.Drawing.Size(66, 51);
            this.ChoosePath.TabIndex = 6;
            this.ChoosePath.UseVisualStyleBackColor = false;
            this.ChoosePath.Click += new System.EventHandler(this.ChoosePath_Click);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Enabled = false;
            this.path.Location = new System.Drawing.Point(550, 41);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(48, 17);
            this.path.TabIndex = 7;
            this.path.Text = "/Music";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DesignSong
            // 
            this.DesignSong.Location = new System.Drawing.Point(493, 164);
            this.DesignSong.Name = "DesignSong";
            this.DesignSong.Size = new System.Drawing.Size(28, 155);
            this.DesignSong.TabIndex = 0;
            // 
            // DesignSong2
            // 
            this.DesignSong2.Location = new System.Drawing.Point(527, 164);
            this.DesignSong2.Name = "DesignSong2";
            this.DesignSong2.Size = new System.Drawing.Size(28, 155);
            this.DesignSong2.TabIndex = 8;
            // 
            // DesignSong3
            // 
            this.DesignSong3.Location = new System.Drawing.Point(561, 164);
            this.DesignSong3.Name = "DesignSong3";
            this.DesignSong3.Size = new System.Drawing.Size(28, 155);
            this.DesignSong3.TabIndex = 9;
            // 
            // DesignSong4
            // 
            this.DesignSong4.Location = new System.Drawing.Point(595, 164);
            this.DesignSong4.Name = "DesignSong4";
            this.DesignSong4.Size = new System.Drawing.Size(28, 155);
            this.DesignSong4.TabIndex = 10;
            // 
            // DesignSong5
            // 
            this.DesignSong5.Location = new System.Drawing.Point(629, 164);
            this.DesignSong5.Name = "DesignSong5";
            this.DesignSong5.Size = new System.Drawing.Size(28, 155);
            this.DesignSong5.TabIndex = 11;
            // 
            // DesignSong6
            // 
            this.DesignSong6.Location = new System.Drawing.Point(663, 164);
            this.DesignSong6.Name = "DesignSong6";
            this.DesignSong6.Size = new System.Drawing.Size(28, 155);
            this.DesignSong6.TabIndex = 12;
            // 
            // DesignSong7
            // 
            this.DesignSong7.Location = new System.Drawing.Point(697, 164);
            this.DesignSong7.Name = "DesignSong7";
            this.DesignSong7.Size = new System.Drawing.Size(28, 155);
            this.DesignSong7.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 331);
            this.Controls.Add(this.DesignSong7);
            this.Controls.Add(this.DesignSong6);
            this.Controls.Add(this.DesignSong5);
            this.Controls.Add(this.DesignSong4);
            this.Controls.Add(this.DesignSong3);
            this.Controls.Add(this.DesignSong2);
            this.Controls.Add(this.DesignSong);
            this.Controls.Add(this.path);
            this.Controls.Add(this.ChoosePath);
            this.Controls.Add(this.List_Son);
            this.Controls.Add(this.RECORDSTOP);
            this.Controls.Add(this.RECORD);
            this.Controls.Add(this.STOP);
            this.Controls.Add(this.Lecture);
            this.Controls.Add(this.openaudio);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       
        #endregion

        private System.Windows.Forms.Button openaudio;
        private System.Windows.Forms.Button Lecture;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.Button RECORD;
        private System.Windows.Forms.Button RECORDSTOP;
        private System.Windows.Forms.ListBox List_Son;
        private System.Windows.Forms.Button ChoosePath;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Timer timer1;
        private VerticalBar DesignSong;
        private VerticalBar DesignSong2;
        private VerticalBar DesignSong3;
        private VerticalBar DesignSong4;
        private VerticalBar DesignSong5;
        private VerticalBar DesignSong6;
        private VerticalBar DesignSong7;
    }
}

