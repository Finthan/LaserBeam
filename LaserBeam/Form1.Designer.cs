namespace LaserBeam
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Up = new System.Windows.Forms.Button();
            this.Button_Left = new System.Windows.Forms.Button();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Button_Down = new System.Windows.Forms.Button();
            this.Button_Right = new System.Windows.Forms.Button();
            this.Label_1 = new System.Windows.Forms.Label();
            this.Label_2 = new System.Windows.Forms.Label();
            this.Text_Condition = new System.Windows.Forms.TextBox();
            this.Button_Reference = new System.Windows.Forms.Button();
            this.Button_Settings = new System.Windows.Forms.Button();
            this.Label_3 = new System.Windows.Forms.Label();
            this.Label_4 = new System.Windows.Forms.Label();
            this.Label_5 = new System.Windows.Forms.Label();
            this.Text_Laser_Power = new System.Windows.Forms.TextBox();
            this.Text_Step = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Up
            // 
            this.Button_Up.Location = new System.Drawing.Point(654, 245);
            this.Button_Up.Name = "Button_Up";
            this.Button_Up.Size = new System.Drawing.Size(55, 55);
            this.Button_Up.TabIndex = 0;
            this.Button_Up.Text = "Вверх";
            this.Button_Up.UseVisualStyleBackColor = true;
            this.Button_Up.Click += new System.EventHandler(this.Button_Up_Click);
            // 
            // Button_Left
            // 
            this.Button_Left.Location = new System.Drawing.Point(593, 306);
            this.Button_Left.Name = "Button_Left";
            this.Button_Left.Size = new System.Drawing.Size(55, 55);
            this.Button_Left.TabIndex = 1;
            this.Button_Left.Text = "Влево";
            this.Button_Left.UseVisualStyleBackColor = true;
            this.Button_Left.Click += new System.EventHandler(this.Button_Left_Click);
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(654, 306);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(55, 55);
            this.Button_Start.TabIndex = 2;
            this.Button_Start.Text = "Пуск";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Button_Down
            // 
            this.Button_Down.Location = new System.Drawing.Point(654, 367);
            this.Button_Down.Name = "Button_Down";
            this.Button_Down.Size = new System.Drawing.Size(55, 55);
            this.Button_Down.TabIndex = 3;
            this.Button_Down.Text = "Вниз";
            this.Button_Down.UseVisualStyleBackColor = true;
            this.Button_Down.Click += new System.EventHandler(this.Button_Down_Click);
            // 
            // Button_Right
            // 
            this.Button_Right.Location = new System.Drawing.Point(715, 310);
            this.Button_Right.Name = "Button_Right";
            this.Button_Right.Size = new System.Drawing.Size(55, 55);
            this.Button_Right.TabIndex = 4;
            this.Button_Right.Text = "Вправо";
            this.Button_Right.UseVisualStyleBackColor = true;
            this.Button_Right.Click += new System.EventHandler(this.Button_Right_Click);
            // 
            // Label_1
            // 
            this.Label_1.AutoSize = true;
            this.Label_1.Location = new System.Drawing.Point(33, 35);
            this.Label_1.Name = "Label_1";
            this.Label_1.Size = new System.Drawing.Size(60, 13);
            this.Label_1.TabIndex = 5;
            this.Label_1.Text = "LaserBeam";
            // 
            // Label_2
            // 
            this.Label_2.AutoSize = true;
            this.Label_2.Location = new System.Drawing.Point(33, 64);
            this.Label_2.Name = "Label_2";
            this.Label_2.Size = new System.Drawing.Size(64, 13);
            this.Label_2.TabIndex = 6;
            this.Label_2.Text = "Состояние:";
            // 
            // Text_Condition
            // 
            this.Text_Condition.Location = new System.Drawing.Point(103, 61);
            this.Text_Condition.Name = "Text_Condition";
            this.Text_Condition.Size = new System.Drawing.Size(100, 20);
            this.Text_Condition.TabIndex = 7;
            // 
            // Button_Reference
            // 
            this.Button_Reference.Location = new System.Drawing.Point(572, 24);
            this.Button_Reference.Name = "Button_Reference";
            this.Button_Reference.Size = new System.Drawing.Size(75, 23);
            this.Button_Reference.TabIndex = 9;
            this.Button_Reference.Text = "Справка";
            this.Button_Reference.UseVisualStyleBackColor = true;
            this.Button_Reference.Click += new System.EventHandler(this.Button_Reference_Click);
            // 
            // Button_Settings
            // 
            this.Button_Settings.Location = new System.Drawing.Point(677, 24);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.Size = new System.Drawing.Size(75, 23);
            this.Button_Settings.TabIndex = 10;
            this.Button_Settings.Text = "Настройки";
            this.Button_Settings.UseVisualStyleBackColor = true;
            this.Button_Settings.Click += new System.EventHandler(this.Button_Settings_Click);
            // 
            // Label_3
            // 
            this.Label_3.AutoSize = true;
            this.Label_3.Location = new System.Drawing.Point(33, 306);
            this.Label_3.Name = "Label_3";
            this.Label_3.Size = new System.Drawing.Size(101, 13);
            this.Label_3.TabIndex = 11;
            this.Label_3.Text = "Мощность Лазера";
            // 
            // Label_4
            // 
            this.Label_4.AutoSize = true;
            this.Label_4.Location = new System.Drawing.Point(33, 348);
            this.Label_4.Name = "Label_4";
            this.Label_4.Size = new System.Drawing.Size(27, 13);
            this.Label_4.TabIndex = 12;
            this.Label_4.Text = "Шаг";
            // 
            // Label_5
            // 
            this.Label_5.AutoSize = true;
            this.Label_5.Location = new System.Drawing.Point(172, 348);
            this.Label_5.Name = "Label_5";
            this.Label_5.Size = new System.Drawing.Size(26, 13);
            this.Label_5.TabIndex = 13;
            this.Label_5.Text = "мм.";
            // 
            // Text_Laser_Power
            // 
            this.Text_Laser_Power.Location = new System.Drawing.Point(140, 303);
            this.Text_Laser_Power.Name = "Text_Laser_Power";
            this.Text_Laser_Power.Size = new System.Drawing.Size(100, 20);
            this.Text_Laser_Power.TabIndex = 14;
            // 
            // Text_Step
            // 
            this.Text_Step.Location = new System.Drawing.Point(66, 345);
            this.Text_Step.Name = "Text_Step";
            this.Text_Step.Size = new System.Drawing.Size(100, 20);
            this.Text_Step.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Text_Step);
            this.Controls.Add(this.Text_Laser_Power);
            this.Controls.Add(this.Label_5);
            this.Controls.Add(this.Label_4);
            this.Controls.Add(this.Label_3);
            this.Controls.Add(this.Button_Settings);
            this.Controls.Add(this.Button_Reference);
            this.Controls.Add(this.Text_Condition);
            this.Controls.Add(this.Label_2);
            this.Controls.Add(this.Label_1);
            this.Controls.Add(this.Button_Right);
            this.Controls.Add(this.Button_Down);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.Button_Left);
            this.Controls.Add(this.Button_Up);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Up;
        private System.Windows.Forms.Button Button_Left;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button Button_Down;
        private System.Windows.Forms.Button Button_Right;
        private System.Windows.Forms.Label Label_1;
        private System.Windows.Forms.Label Label_2;
        private System.Windows.Forms.TextBox Text_Condition;
        private System.Windows.Forms.Button Button_Reference;
        private System.Windows.Forms.Button Button_Settings;
        private System.Windows.Forms.Label Label_3;
        private System.Windows.Forms.Label Label_4;
        private System.Windows.Forms.Label Label_5;
        private System.Windows.Forms.TextBox Text_Laser_Power;
        private System.Windows.Forms.TextBox Text_Step;
    }
}

