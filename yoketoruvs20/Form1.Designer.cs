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
            this.SuspendLayout();
            // 
            // daimei
            // 
            this.daimei.AutoSize = true;
            this.daimei.Font = new System.Drawing.Font("HG行書体", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.daimei.ForeColor = System.Drawing.Color.DarkBlue;
            this.daimei.Location = new System.Drawing.Point(105, 111);
            this.daimei.Name = "daimei";
            this.daimei.Size = new System.Drawing.Size(573, 67);
            this.daimei.TabIndex = 0;
            this.daimei.Text = "よけとる２０２０";
            // 
            // START
            // 
            this.START.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.START.Location = new System.Drawing.Point(265, 276);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(208, 84);
            this.START.TabIndex = 1;
            this.START.Text = "スタート";
            this.START.UseVisualStyleBackColor = true;
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
            this.Time.Location = new System.Drawing.Point(34, 26);
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
            this.zanki.Location = new System.Drawing.Point(640, 26);
            this.zanki.Name = "zanki";
            this.zanki.Size = new System.Drawing.Size(134, 27);
            this.zanki.TabIndex = 5;
            this.zanki.Text = "残機☆:１０";
            // 
            // gameover
            // 
            this.gameover.AutoSize = true;
            this.gameover.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gameover.Location = new System.Drawing.Point(245, 26);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(252, 54);
            this.gameover.TabIndex = 6;
            this.gameover.Text = "Gameover";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

