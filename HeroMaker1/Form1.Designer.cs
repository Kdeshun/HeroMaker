using System;

namespace HeroMaker1
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeroName = new System.Windows.Forms.Label();
            this.txtHeroName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkbxSuperStrength = new System.Windows.Forms.CheckBox();
            this.chkbxFly = new System.Windows.Forms.CheckBox();
            this.chkbxShapeShift = new System.Windows.Forms.CheckBox();
            this.chkbxInvisibility = new System.Windows.Forms.CheckBox();
            this.chkbxSuperRich = new System.Windows.Forms.CheckBox();
            this.chkbxSuperSpeed = new System.Windows.Forms.CheckBox();
            this.chkbxSuperSmart = new System.Windows.Forms.CheckBox();
            this.chkbxMindControl = new System.Windows.Forms.CheckBox();
            this.btnCreateHero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Cities = new System.Windows.Forms.ListBox();
            this.gbSideKick = new System.Windows.Forms.GroupBox();
            this.rbRobot = new System.Windows.Forms.RadioButton();
            this.rbTeen = new System.Windows.Forms.RadioButton();
            this.rbSuperAnimal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStamina = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scrlStamina = new System.Windows.Forms.HScrollBar();
            this.scrlStrength = new System.Windows.Forms.HScrollBar();
            this.scrlSpeed = new System.Windows.Forms.HScrollBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtReveal = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtDiscovery = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.numExperience = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.pbCapeColor = new System.Windows.Forms.PictureBox();
            this.trckbrEvil = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.lblEvil = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnViewList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbSideKick.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExperience)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrEvil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeroName
            // 
            this.lblHeroName.AutoSize = true;
            this.lblHeroName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroName.Location = new System.Drawing.Point(144, 9);
            this.lblHeroName.Name = "lblHeroName";
            this.lblHeroName.Size = new System.Drawing.Size(126, 23);
            this.lblHeroName.TabIndex = 0;
            this.lblHeroName.Text = "Hero\'s Name";
            // 
            // txtHeroName
            // 
            this.txtHeroName.Location = new System.Drawing.Point(291, 12);
            this.txtHeroName.Name = "txtHeroName";
            this.txtHeroName.Size = new System.Drawing.Size(184, 20);
            this.txtHeroName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.chkbxSuperStrength);
            this.groupBox1.Controls.Add(this.chkbxFly);
            this.groupBox1.Controls.Add(this.chkbxShapeShift);
            this.groupBox1.Controls.Add(this.chkbxInvisibility);
            this.groupBox1.Controls.Add(this.chkbxSuperRich);
            this.groupBox1.Controls.Add(this.chkbxSuperSpeed);
            this.groupBox1.Controls.Add(this.chkbxSuperSmart);
            this.groupBox1.Controls.Add(this.chkbxMindControl);
            this.groupBox1.Location = new System.Drawing.Point(16, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 183);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Abilities";
            // 
            // chkbxSuperStrength
            // 
            this.chkbxSuperStrength.AutoSize = true;
            this.chkbxSuperStrength.Location = new System.Drawing.Point(120, 20);
            this.chkbxSuperStrength.Name = "chkbxSuperStrength";
            this.chkbxSuperStrength.Size = new System.Drawing.Size(97, 17);
            this.chkbxSuperStrength.TabIndex = 13;
            this.chkbxSuperStrength.Text = "Super Strength";
            this.chkbxSuperStrength.UseVisualStyleBackColor = true;
            // 
            // chkbxFly
            // 
            this.chkbxFly.AutoSize = true;
            this.chkbxFly.Location = new System.Drawing.Point(7, 22);
            this.chkbxFly.Name = "chkbxFly";
            this.chkbxFly.Size = new System.Drawing.Size(39, 17);
            this.chkbxFly.TabIndex = 12;
            this.chkbxFly.Text = "Fly";
            this.chkbxFly.UseVisualStyleBackColor = true;
            // 
            // chkbxShapeShift
            // 
            this.chkbxShapeShift.AutoSize = true;
            this.chkbxShapeShift.Location = new System.Drawing.Point(120, 160);
            this.chkbxShapeShift.Name = "chkbxShapeShift";
            this.chkbxShapeShift.Size = new System.Drawing.Size(81, 17);
            this.chkbxShapeShift.TabIndex = 9;
            this.chkbxShapeShift.Text = "Shape Shift";
            this.chkbxShapeShift.UseVisualStyleBackColor = true;
            // 
            // chkbxInvisibility
            // 
            this.chkbxInvisibility.AutoSize = true;
            this.chkbxInvisibility.Location = new System.Drawing.Point(120, 114);
            this.chkbxInvisibility.Name = "chkbxInvisibility";
            this.chkbxInvisibility.Size = new System.Drawing.Size(70, 17);
            this.chkbxInvisibility.TabIndex = 7;
            this.chkbxInvisibility.Text = "Invisibility";
            this.chkbxInvisibility.UseVisualStyleBackColor = true;
            // 
            // chkbxSuperRich
            // 
            this.chkbxSuperRich.AutoSize = true;
            this.chkbxSuperRich.Location = new System.Drawing.Point(120, 68);
            this.chkbxSuperRich.Name = "chkbxSuperRich";
            this.chkbxSuperRich.Size = new System.Drawing.Size(79, 17);
            this.chkbxSuperRich.TabIndex = 5;
            this.chkbxSuperRich.Text = "Super Rich";
            this.chkbxSuperRich.UseVisualStyleBackColor = true;
            // 
            // chkbxSuperSpeed
            // 
            this.chkbxSuperSpeed.AutoSize = true;
            this.chkbxSuperSpeed.Location = new System.Drawing.Point(6, 160);
            this.chkbxSuperSpeed.Name = "chkbxSuperSpeed";
            this.chkbxSuperSpeed.Size = new System.Drawing.Size(88, 17);
            this.chkbxSuperSpeed.TabIndex = 4;
            this.chkbxSuperSpeed.Text = "Super Speed";
            this.chkbxSuperSpeed.UseVisualStyleBackColor = true;
            // 
            // chkbxSuperSmart
            // 
            this.chkbxSuperSmart.AutoSize = true;
            this.chkbxSuperSmart.Location = new System.Drawing.Point(6, 114);
            this.chkbxSuperSmart.Name = "chkbxSuperSmart";
            this.chkbxSuperSmart.Size = new System.Drawing.Size(84, 17);
            this.chkbxSuperSmart.TabIndex = 2;
            this.chkbxSuperSmart.Text = "Super Smart";
            this.chkbxSuperSmart.UseVisualStyleBackColor = true;
            // 
            // chkbxMindControl
            // 
            this.chkbxMindControl.AutoSize = true;
            this.chkbxMindControl.Location = new System.Drawing.Point(6, 68);
            this.chkbxMindControl.Name = "chkbxMindControl";
            this.chkbxMindControl.Size = new System.Drawing.Size(85, 17);
            this.chkbxMindControl.TabIndex = 0;
            this.chkbxMindControl.Text = "Mind Control";
            this.chkbxMindControl.UseVisualStyleBackColor = true;
            // 
            // btnCreateHero
            // 
            this.btnCreateHero.Location = new System.Drawing.Point(532, 370);
            this.btnCreateHero.Name = "btnCreateHero";
            this.btnCreateHero.Size = new System.Drawing.Size(75, 23);
            this.btnCreateHero.TabIndex = 3;
            this.btnCreateHero.Text = "Create!";
            this.btnCreateHero.UseVisualStyleBackColor = true;
            this.btnCreateHero.Click += new System.EventHandler(this.btnCreateHero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cities:";
            // 
            // lst_Cities
            // 
            this.lst_Cities.FormattingEnabled = true;
            this.lst_Cities.Items.AddRange(new object[] {
            "Phoenix",
            "Xanadu",
            "Oxnard",
            "Sioux Falls",
            "Alexandria"});
            this.lst_Cities.Location = new System.Drawing.Point(16, 248);
            this.lst_Cities.Name = "lst_Cities";
            this.lst_Cities.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_Cities.Size = new System.Drawing.Size(245, 69);
            this.lst_Cities.TabIndex = 5;
            // 
            // gbSideKick
            // 
            this.gbSideKick.Controls.Add(this.rbRobot);
            this.gbSideKick.Controls.Add(this.rbTeen);
            this.gbSideKick.Controls.Add(this.rbSuperAnimal);
            this.gbSideKick.Location = new System.Drawing.Point(292, 231);
            this.gbSideKick.Name = "gbSideKick";
            this.gbSideKick.Size = new System.Drawing.Size(200, 87);
            this.gbSideKick.TabIndex = 6;
            this.gbSideKick.TabStop = false;
            this.gbSideKick.Text = "Favorite Sidekick";
            // 
            // rbRobot
            // 
            this.rbRobot.AutoSize = true;
            this.rbRobot.Location = new System.Drawing.Point(7, 68);
            this.rbRobot.Name = "rbRobot";
            this.rbRobot.Size = new System.Drawing.Size(98, 17);
            this.rbRobot.TabIndex = 2;
            this.rbRobot.Text = "Oblvious Robot";
            this.rbRobot.UseVisualStyleBackColor = true;
            // 
            // rbTeen
            // 
            this.rbTeen.AutoSize = true;
            this.rbTeen.Location = new System.Drawing.Point(7, 44);
            this.rbTeen.Name = "rbTeen";
            this.rbTeen.Size = new System.Drawing.Size(118, 17);
            this.rbTeen.TabIndex = 1;
            this.rbTeen.Text = "Wisecracking Teen";
            this.rbTeen.UseVisualStyleBackColor = true;
            // 
            // rbSuperAnimal
            // 
            this.rbSuperAnimal.AutoSize = true;
            this.rbSuperAnimal.Checked = true;
            this.rbSuperAnimal.Location = new System.Drawing.Point(7, 20);
            this.rbSuperAnimal.Name = "rbSuperAnimal";
            this.rbSuperAnimal.Size = new System.Drawing.Size(87, 17);
            this.rbSuperAnimal.TabIndex = 0;
            this.rbSuperAnimal.TabStop = true;
            this.rbSuperAnimal.Text = "Super Animal";
            this.rbSuperAnimal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStamina);
            this.groupBox2.Controls.Add(this.lblSpeed);
            this.groupBox2.Controls.Add(this.lblStrength);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.scrlStamina);
            this.groupBox2.Controls.Add(this.scrlStrength);
            this.groupBox2.Controls.Add(this.scrlSpeed);
            this.groupBox2.Location = new System.Drawing.Point(16, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 135);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Strength, Speed, and Stamina";
            // 
            // lblStamina
            // 
            this.lblStamina.AutoSize = true;
            this.lblStamina.Location = new System.Drawing.Point(59, 91);
            this.lblStamina.Name = "lblStamina";
            this.lblStamina.Size = new System.Drawing.Size(19, 13);
            this.lblStamina.TabIndex = 9;
            this.lblStamina.Text = "33";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(59, 56);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(19, 13);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "33";
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Location = new System.Drawing.Point(59, 16);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(19, 13);
            this.lblStrength.TabIndex = 7;
            this.lblStrength.Text = "33";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stamina:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speed:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Strength:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // scrlStamina
            // 
            this.scrlStamina.Location = new System.Drawing.Point(9, 106);
            this.scrlStamina.Name = "scrlStamina";
            this.scrlStamina.Size = new System.Drawing.Size(464, 23);
            this.scrlStamina.TabIndex = 3;
            this.scrlStamina.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlStamina_Scroll);
            // 
            // scrlStrength
            // 
            this.scrlStrength.Location = new System.Drawing.Point(9, 29);
            this.scrlStrength.Name = "scrlStrength";
            this.scrlStrength.Size = new System.Drawing.Size(464, 23);
            this.scrlStrength.TabIndex = 2;
            this.scrlStrength.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlStrength_Scroll);
            // 
            // scrlSpeed
            // 
            this.scrlSpeed.Location = new System.Drawing.Point(9, 69);
            this.scrlSpeed.Name = "scrlSpeed";
            this.scrlSpeed.Size = new System.Drawing.Size(464, 23);
            this.scrlSpeed.TabIndex = 1;
            this.scrlSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrlSpeed_Scroll);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtReveal);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtDiscovery);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtBirth);
            this.groupBox3.Location = new System.Drawing.Point(268, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 177);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dtReveal
            // 
            this.dtReveal.Location = new System.Drawing.Point(7, 129);
            this.dtReveal.Name = "dtReveal";
            this.dtReveal.Size = new System.Drawing.Size(200, 20);
            this.dtReveal.TabIndex = 5;
            this.dtReveal.ValueChanged += new System.EventHandler(this.dtReveal_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Public Reveal:";
            // 
            // dtDiscovery
            // 
            this.dtDiscovery.Location = new System.Drawing.Point(7, 85);
            this.dtDiscovery.Name = "dtDiscovery";
            this.dtDiscovery.Size = new System.Drawing.Size(200, 20);
            this.dtDiscovery.TabIndex = 3;
            this.dtDiscovery.ValueChanged += new System.EventHandler(this.dtDiscovery_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Abilities Discovery:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Birth:";
            // 
            // dtBirth
            // 
            this.dtBirth.Location = new System.Drawing.Point(7, 41);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(200, 20);
            this.dtBirth.TabIndex = 0;
            this.dtBirth.ValueChanged += new System.EventHandler(this.dtBirth_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(524, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Years Experience";
            // 
            // numExperience
            // 
            this.numExperience.Location = new System.Drawing.Point(509, 60);
            this.numExperience.Name = "numExperience";
            this.numExperience.Size = new System.Drawing.Size(120, 20);
            this.numExperience.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(540, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cape Color";
            // 
            // pbCapeColor
            // 
            this.pbCapeColor.BackColor = System.Drawing.Color.IndianRed;
            this.pbCapeColor.Location = new System.Drawing.Point(509, 103);
            this.pbCapeColor.Name = "pbCapeColor";
            this.pbCapeColor.Size = new System.Drawing.Size(120, 50);
            this.pbCapeColor.TabIndex = 12;
            this.pbCapeColor.TabStop = false;
            this.pbCapeColor.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // trckbrEvil
            // 
            this.trckbrEvil.LargeChange = 3;
            this.trckbrEvil.Location = new System.Drawing.Point(517, 199);
            this.trckbrEvil.Minimum = -10;
            this.trckbrEvil.Name = "trckbrEvil";
            this.trckbrEvil.Size = new System.Drawing.Size(104, 45);
            this.trckbrEvil.TabIndex = 13;
            this.trckbrEvil.Scroll += new System.EventHandler(this.trckbrEvil_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(524, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Evil capacity:";
            // 
            // lblEvil
            // 
            this.lblEvil.AutoSize = true;
            this.lblEvil.Location = new System.Drawing.Point(604, 176);
            this.lblEvil.Name = "lblEvil";
            this.lblEvil.Size = new System.Drawing.Size(13, 13);
            this.lblEvil.TabIndex = 15;
            this.lblEvil.Text = "0";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(6, 27);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 50);
            this.pbLogo.TabIndex = 16;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbLogo);
            this.groupBox4.Location = new System.Drawing.Point(511, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(117, 100);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logo/Symbol:";
            // 
            // btnViewList
            // 
            this.btnViewList.Location = new System.Drawing.Point(517, 415);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(106, 23);
            this.btnViewList.TabIndex = 19;
            this.btnViewList.Text = "View List Of Heros";
            this.btnViewList.UseVisualStyleBackColor = true;
            this.btnViewList.Click += new System.EventHandler(this.btnViewList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 471);
            this.Controls.Add(this.btnViewList);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblEvil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trckbrEvil);
            this.Controls.Add(this.pbCapeColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numExperience);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbSideKick);
            this.Controls.Add(this.lst_Cities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateHero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHeroName);
            this.Controls.Add(this.lblHeroName);
            this.MaximumSize = new System.Drawing.Size(657, 510);
            this.MinimumSize = new System.Drawing.Size(657, 510);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSideKick.ResumeLayout(false);
            this.gbSideKick.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExperience)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckbrEvil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeroName;
        private System.Windows.Forms.TextBox txtHeroName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkbxSuperStrength;
        private System.Windows.Forms.CheckBox chkbxFly;
        private System.Windows.Forms.CheckBox chkbxShapeShift;
        private System.Windows.Forms.CheckBox chkbxInvisibility;
        private System.Windows.Forms.CheckBox chkbxSuperRich;
        private System.Windows.Forms.CheckBox chkbxSuperSpeed;
        private System.Windows.Forms.CheckBox chkbxSuperSmart;
        private System.Windows.Forms.CheckBox chkbxMindControl;
        private System.Windows.Forms.Button btnCreateHero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_Cities;
        private System.Windows.Forms.GroupBox gbSideKick;
        private System.Windows.Forms.RadioButton rbRobot;
        private System.Windows.Forms.RadioButton rbTeen;
        private System.Windows.Forms.RadioButton rbSuperAnimal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStamina;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar scrlStamina;
        private System.Windows.Forms.HScrollBar scrlStrength;
        private System.Windows.Forms.HScrollBar scrlSpeed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtReveal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtDiscovery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numExperience;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbCapeColor;
        private System.Windows.Forms.TrackBar trckbrEvil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblEvil;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnViewList;
    }
}
