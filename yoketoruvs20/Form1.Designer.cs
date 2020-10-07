namespace yoketoruvs20
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.daimei = new System.Windows.Forms.Label();
            this.START = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Highscore = new System.Windows.Forms.Label();
            this.zanki = new System.Windows.Forms.Label();
            this.gameover = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.END = new System.Windows.Forms.Button();
            this.clearlabel = new System.Windows.Forms.Label();
            this.tenplabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // daimei
            // 
            this.daimei.AutoSize = true;
            this.daimei.Font = new System.Drawing.Font("HG行書体", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.daimei.ForeColor = System.Drawing.Color.DarkBlue;
            this.daimei.Location = new System.Drawing.Point(105, 119);
            this.daimei.Name = "daimei";
            this.daimei.Size = new System.Drawing.Size(573, 67);
            this.daimei.TabIndex = 0;
            this.daimei.Text = "よけとる２０２０";
            // 
            // START
            // 
            this.START.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.START.Location = new System.Drawing.Point(276, 276);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(208, 84);
            this.START.TabIndex = 1;
            this.START.Text = "スタート";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.name.Location = new System.Drawing.Point(244, 408);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(253, 20);
            this.name.TabIndex = 2;
            this.name.Text = "Copyright @ 2020 佐藤　神威";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Time.Location = new System.Drawing.Point(30, 26);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(119, 27);
            this.Time.TabIndex = 3;
            this.Time.Text = "TIme 100";
            // 
            // Highscore
            // 
            this.Highscore.AutoSize = true;
            this.Highscore.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Highscore.Location = new System.Drawing.Point(314, 216);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(127, 20);
            this.Highscore.TabIndex = 4;
            this.Highscore.Text = "ハイスコア　100";
            // 
            // zanki
            // 
            this.zanki.AutoSize = true;
            this.zanki.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.zanki.Location = new System.Drawing.Point(637, 26);
            this.zanki.Name = "zanki";
            this.zanki.Size = new System.Drawing.Size(80, 27);
            this.zanki.TabIndex = 5;
            this.zanki.Text = "☆:１０";
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gameover.Location = new System.Drawing.Point(267, 94);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(252, 54);
            this.gameover.TabIndex = 6;
            this.gameover.Text = "Gameover";
            this.gameover.Click += new System.EventHandler(this.gameover_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // END
            // 
            this.END.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.END.Location = new System.Drawing.Point(276, 276);
            this.END.Name = "END";
            this.END.Size = new System.Drawing.Size(208, 84);
            this.END.TabIndex = 7;
            this.END.Text = "タイトルへ";
            this.END.UseVisualStyleBackColor = true;
            this.END.Click += new System.EventHandler(this.END_Click);
            // 
            // clearlabel
            // 
            this.clearlabel.AutoSize = true;
            this.clearlabel.Font = new System.Drawing.Font("HG行書体", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearlabel.Location = new System.Drawing.Point(209, 149);
            this.clearlabel.Name = "clearlabel";
            this.clearlabel.Size = new System.Drawing.Size(369, 67);
            this.clearlabel.TabIndex = 8;
            this.clearlabel.Text = "ＣＬＥＡＲ";
            // 
            // tenplabel
            // 
            this.tenplabel.AutoSize = true;
            this.tenplabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tenplabel.Location = new System.Drawing.Point(46, 128);
            this.tenplabel.Name = "tenplabel";
            this.tenplabel.Size = new System.Drawing.Size(47, 33);
            this.tenplabel.TabIndex = 9;
            this.tenplabel.Text = "★";
            this.tenplabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tenplabel);
            this.Controls.Add(this.clearlabel);
            this.Controls.Add(this.END);
            this.Controls.Add(this.gameover);
            this.Controls.Add(this.zanki);
            this.Controls.Add(this.Highscore);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.name);
            this.Controls.Add(this.START);
            this.Controls.Add(this.daimei);
            this.Name = "Form1";
            this.Text = "よけとる2020";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daimei;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Highscore;
        private System.Windows.Forms.Label zanki;
        private System.Windows.Forms.Label gameover;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button END;
        private System.Windows.Forms.Label clearlabel;
        private System.Windows.Forms.Label tenplabel;
        private System.Windows.Forms.Timer timer2;
    }
}

