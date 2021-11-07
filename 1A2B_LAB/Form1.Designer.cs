
namespace _1A2B_LAB
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Startbt = new System.Windows.Forms.Button();
            this.ComNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OutputCourse = new System.Windows.Forms.Label();
            this.InputNumberCourse = new System.Windows.Forms.Label();
            this.InputNumberA = new System.Windows.Forms.TextBox();
            this.InputNumberB = new System.Windows.Forms.TextBox();
            this.InputNumberC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Resbt = new System.Windows.Forms.Button();
            this.Lockbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Startbt
            // 
            this.Startbt.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbt.Location = new System.Drawing.Point(620, 25);
            this.Startbt.Name = "Startbt";
            this.Startbt.Size = new System.Drawing.Size(120, 55);
            this.Startbt.TabIndex = 0;
            this.Startbt.Text = "START";
            this.Startbt.UseVisualStyleBackColor = true;
            this.Startbt.Click += new System.EventHandler(this.Startbt_Click);
            // 
            // ComNumber
            // 
            this.ComNumber.AutoSize = true;
            this.ComNumber.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComNumber.Location = new System.Drawing.Point(30, 25);
            this.ComNumber.Name = "ComNumber";
            this.ComNumber.Size = new System.Drawing.Size(85, 33);
            this.ComNumber.TabIndex = 2;
            this.ComNumber.Text = "1A2B";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InputNumberCourse);
            this.groupBox1.Controls.Add(this.OutputCourse);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 279);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "0A0B";
            // 
            // OutputCourse
            // 
            this.OutputCourse.AutoSize = true;
            this.OutputCourse.Location = new System.Drawing.Point(425, 60);
            this.OutputCourse.Name = "OutputCourse";
            this.OutputCourse.Size = new System.Drawing.Size(0, 40);
            this.OutputCourse.TabIndex = 1;
            // 
            // InputNumberCourse
            // 
            this.InputNumberCourse.AutoSize = true;
            this.InputNumberCourse.Location = new System.Drawing.Point(45, 60);
            this.InputNumberCourse.Name = "InputNumberCourse";
            this.InputNumberCourse.Size = new System.Drawing.Size(0, 40);
            this.InputNumberCourse.TabIndex = 0;
            // 
            // InputNumberA
            // 
            this.InputNumberA.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNumberA.Location = new System.Drawing.Point(40, 70);
            this.InputNumberA.MaxLength = 1;
            this.InputNumberA.Name = "textBox1";
            this.InputNumberA.Size = new System.Drawing.Size(40, 35);
            this.InputNumberA.TabIndex = 4;
            // 
            // InputNumberB
            // 
            this.InputNumberB.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNumberB.Location = new System.Drawing.Point(115, 70);
            this.InputNumberB.MaxLength = 1;
            this.InputNumberB.Name = "textBox2";
            this.InputNumberB.Size = new System.Drawing.Size(40, 35);
            this.InputNumberB.TabIndex = 5;
            // 
            // InputNumberC
            // 
            this.InputNumberC.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNumberC.Location = new System.Drawing.Point(190, 70);
            this.InputNumberC.MaxLength = 1;
            this.InputNumberC.Name = "textBox3";
            this.InputNumberC.Size = new System.Drawing.Size(40, 35);
            this.InputNumberC.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            // 
            // Resbt
            // 
            this.Resbt.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resbt.Location = new System.Drawing.Point(620, 85);
            this.Resbt.Name = "Resbt";
            this.Resbt.Size = new System.Drawing.Size(120, 55);
            this.Resbt.TabIndex = 1;
            this.Resbt.Text = "RES";
            this.Resbt.UseVisualStyleBackColor = true;
            this.Resbt.Click += new System.EventHandler(this.Resetbt_Click);
            // 
            // Lockbt
            // 
            this.Lockbt.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lockbt.Location = new System.Drawing.Point(460, 85);
            this.Lockbt.Name = "Lockbt";
            this.Lockbt.Size = new System.Drawing.Size(120, 55);
            this.Lockbt.TabIndex = 7;
            this.Lockbt.Text = "Lock";
            this.Lockbt.UseVisualStyleBackColor = true;
            this.Lockbt.Click += new System.EventHandler(this.Lockbt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lockbt);
            this.Controls.Add(this.Resbt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputNumberC);
            this.Controls.Add(this.InputNumberB);
            this.Controls.Add(this.InputNumberA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComNumber);
            this.Controls.Add(this.Startbt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Startbt;
        private System.Windows.Forms.Label ComNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox InputNumberA;
        private System.Windows.Forms.TextBox InputNumberB;
        private System.Windows.Forms.TextBox InputNumberC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Resbt;
        private System.Windows.Forms.Button Lockbt;
        private System.Windows.Forms.Label OutputCourse;
        private System.Windows.Forms.Label InputNumberCourse;
    }
}

