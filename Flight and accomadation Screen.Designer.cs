
namespace WindowsFormsApp1
{
    partial class frmflights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmflights));
            this.label1 = new System.Windows.Forms.Label();
            this.radroundtrip = new System.Windows.Forms.RadioButton();
            this.radOneway = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFindingflights = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.btnback = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.grpCountry = new System.Windows.Forms.GroupBox();
            this.cmbDestinatiom = new System.Windows.Forms.ComboBox();
            this.cmbArrivaldestination = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpTypeofClass = new System.Windows.Forms.GroupBox();
            this.radEconomy = new System.Windows.Forms.RadioButton();
            this.radFirstclass = new System.Windows.Forms.RadioButton();
            this.radBussiness = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radInternational = new System.Windows.Forms.RadioButton();
            this.radLocal = new System.Windows.Forms.RadioButton();
            this.comboxDepartCity = new System.Windows.Forms.ComboBox();
            this.comboxArrivalCity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTotalParcipants = new System.Windows.Forms.Label();
            this.txtTotalParticipants = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.grpCountry.SuspendLayout();
            this.grpTypeofClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flights and Accomodation";
            // 
            // radroundtrip
            // 
            this.radroundtrip.AutoSize = true;
            this.radroundtrip.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radroundtrip.Location = new System.Drawing.Point(127, 45);
            this.radroundtrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radroundtrip.Name = "radroundtrip";
            this.radroundtrip.Size = new System.Drawing.Size(229, 27);
            this.radroundtrip.TabIndex = 1;
            this.radroundtrip.TabStop = true;
            this.radroundtrip.Text = "Round trip = R5 116,94";
            this.radroundtrip.UseVisualStyleBackColor = true;
            this.radroundtrip.CheckedChanged += new System.EventHandler(this.radroundtrip_CheckedChanged);
            // 
            // radOneway
            // 
            this.radOneway.AutoSize = true;
            this.radOneway.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOneway.Location = new System.Drawing.Point(617, 45);
            this.radOneway.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radOneway.Name = "radOneway";
            this.radOneway.Size = new System.Drawing.Size(255, 27);
            this.radOneway.TabIndex = 2;
            this.radOneway.TabStop = true;
            this.radOneway.Text = "One-way trip = R3495,95";
            this.radOneway.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Depart:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(530, 323);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Return:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Number of Adults:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 442);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Number of Children:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 497);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Number of Infants:";
            // 
            // btnFindingflights
            // 
            this.btnFindingflights.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindingflights.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFindingflights.Location = new System.Drawing.Point(665, 497);
            this.btnFindingflights.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindingflights.Name = "btnFindingflights";
            this.btnFindingflights.Size = new System.Drawing.Size(233, 105);
            this.btnFindingflights.TabIndex = 20;
            this.btnFindingflights.Text = "Now lets Find Some Flights! ";
            this.btnFindingflights.UseVisualStyleBackColor = true;
            this.btnFindingflights.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(665, 315);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 31);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(136, 315);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(312, 31);
            this.dateTimePicker2.TabIndex = 22;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(225, 388);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(103, 31);
            this.numericUpDown1.TabIndex = 23;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(225, 441);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(103, 26);
            this.numericUpDown2.TabIndex = 24;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(124, 778);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(103, 26);
            this.numericUpDown3.TabIndex = 25;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(105, 886);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(172, 92);
            this.btnback.TabIndex = 27;
            this.btnback.Text = "back";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(225, 497);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(103, 26);
            this.numericUpDown4.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 40);
            this.button1.TabIndex = 30;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grpCountry
            // 
            this.grpCountry.Controls.Add(this.label10);
            this.grpCountry.Controls.Add(this.label7);
            this.grpCountry.Controls.Add(this.comboxArrivalCity);
            this.grpCountry.Controls.Add(this.comboxDepartCity);
            this.grpCountry.Controls.Add(this.radLocal);
            this.grpCountry.Controls.Add(this.radInternational);
            this.grpCountry.Controls.Add(this.cmbDestinatiom);
            this.grpCountry.Controls.Add(this.cmbArrivaldestination);
            this.grpCountry.Controls.Add(this.label3);
            this.grpCountry.Controls.Add(this.label2);
            this.grpCountry.Location = new System.Drawing.Point(52, 91);
            this.grpCountry.Name = "grpCountry";
            this.grpCountry.Size = new System.Drawing.Size(846, 194);
            this.grpCountry.TabIndex = 32;
            this.grpCountry.TabStop = false;
            this.grpCountry.Text = "Please select the Type of flight and destination:";
            // 
            // cmbDestinatiom
            // 
            this.cmbDestinatiom.AllowDrop = true;
            this.cmbDestinatiom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbDestinatiom.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestinatiom.FormattingEnabled = true;
            this.cmbDestinatiom.Items.AddRange(new object[] {
            "Afghanistan",
            "Argentina",
            "Austlia",
            "Brazil",
            "China",
            "India",
            "Japan",
            "Korea",
            "Nigeria",
            "Portugal",
            "Span",
            "Thailand",
            "UK",
            "United States of America"});
            this.cmbDestinatiom.Location = new System.Drawing.Point(99, 78);
            this.cmbDestinatiom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDestinatiom.MaxDropDownItems = 4;
            this.cmbDestinatiom.Name = "cmbDestinatiom";
            this.cmbDestinatiom.Size = new System.Drawing.Size(230, 31);
            this.cmbDestinatiom.Sorted = true;
            this.cmbDestinatiom.TabIndex = 39;
            // 
            // cmbArrivaldestination
            // 
            this.cmbArrivaldestination.AllowDrop = true;
            this.cmbArrivaldestination.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbArrivaldestination.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArrivaldestination.FormattingEnabled = true;
            this.cmbArrivaldestination.Items.AddRange(new object[] {
            "Afghanistan",
            "Argentina",
            "Austlia",
            "Brazil",
            "China",
            "India",
            "Japan",
            "Korea",
            "Nigeria",
            "Portugal",
            "Span",
            "Thailand",
            "UK",
            "United States of America"});
            this.cmbArrivaldestination.Location = new System.Drawing.Point(99, 119);
            this.cmbArrivaldestination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbArrivaldestination.MaxDropDownItems = 4;
            this.cmbArrivaldestination.Name = "cmbArrivaldestination";
            this.cmbArrivaldestination.Size = new System.Drawing.Size(230, 31);
            this.cmbArrivaldestination.Sorted = true;
            this.cmbArrivaldestination.TabIndex = 38;
            this.cmbArrivaldestination.SelectedIndexChanged += new System.EventHandler(this.cmbArrivaldestination_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "From:";
            // 
            // grpTypeofClass
            // 
            this.grpTypeofClass.Controls.Add(this.radioButton2);
            this.grpTypeofClass.Controls.Add(this.radBussiness);
            this.grpTypeofClass.Controls.Add(this.radFirstclass);
            this.grpTypeofClass.Controls.Add(this.radEconomy);
            this.grpTypeofClass.Location = new System.Drawing.Point(665, 362);
            this.grpTypeofClass.Name = "grpTypeofClass";
            this.grpTypeofClass.Size = new System.Drawing.Size(278, 127);
            this.grpTypeofClass.TabIndex = 33;
            this.grpTypeofClass.TabStop = false;
            this.grpTypeofClass.Text = "type of classs";
            // 
            // radEconomy
            // 
            this.radEconomy.AutoSize = true;
            this.radEconomy.Location = new System.Drawing.Point(18, 26);
            this.radEconomy.Name = "radEconomy";
            this.radEconomy.Size = new System.Drawing.Size(86, 24);
            this.radEconomy.TabIndex = 0;
            this.radEconomy.TabStop = true;
            this.radEconomy.Text = "Economy";
            this.radEconomy.UseVisualStyleBackColor = true;
            // 
            // radFirstclass
            // 
            this.radFirstclass.AutoSize = true;
            this.radFirstclass.Location = new System.Drawing.Point(18, 57);
            this.radFirstclass.Name = "radFirstclass";
            this.radFirstclass.Size = new System.Drawing.Size(93, 24);
            this.radFirstclass.TabIndex = 1;
            this.radFirstclass.TabStop = true;
            this.radFirstclass.Text = "First Class";
            this.radFirstclass.UseVisualStyleBackColor = true;
            // 
            // radBussiness
            // 
            this.radBussiness.AutoSize = true;
            this.radBussiness.Location = new System.Drawing.Point(18, 87);
            this.radBussiness.Name = "radBussiness";
            this.radBussiness.Size = new System.Drawing.Size(91, 24);
            this.radBussiness.TabIndex = 2;
            this.radBussiness.TabStop = true;
            this.radBussiness.Text = "Bussiness";
            this.radBussiness.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(126, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(147, 24);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Premium Economy";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radInternational
            // 
            this.radInternational.AutoSize = true;
            this.radInternational.Location = new System.Drawing.Point(162, 37);
            this.radInternational.Name = "radInternational";
            this.radInternational.Size = new System.Drawing.Size(145, 24);
            this.radInternational.TabIndex = 40;
            this.radInternational.TabStop = true;
            this.radInternational.Text = "International Flight";
            this.radInternational.UseVisualStyleBackColor = true;
            this.radInternational.CheckedChanged += new System.EventHandler(this.radInternational_CheckedChanged_1);
            // 
            // radLocal
            // 
            this.radLocal.AutoSize = true;
            this.radLocal.Location = new System.Drawing.Point(592, 37);
            this.radLocal.Name = "radLocal";
            this.radLocal.Size = new System.Drawing.Size(101, 24);
            this.radLocal.TabIndex = 41;
            this.radLocal.TabStop = true;
            this.radLocal.Text = "Local Flight";
            this.radLocal.UseVisualStyleBackColor = true;
            this.radLocal.CheckedChanged += new System.EventHandler(this.radLocal_CheckedChanged);
            // 
            // comboxDepartCity
            // 
            this.comboxDepartCity.FormattingEnabled = true;
            this.comboxDepartCity.Items.AddRange(new object[] {
            "Free - State-",
            "Free - State",
            "Gauteng-Johanus burg",
            "KwaZulu-Natal-Durban OR Tambo AirPort",
            "North-West-",
            "Northern -Cape-Cape Town",
            "Eastern-Cape",
            "Limpompo",
            "Mpumalanga",
            "Western Cape"});
            this.comboxDepartCity.Location = new System.Drawing.Point(565, 78);
            this.comboxDepartCity.Name = "comboxDepartCity";
            this.comboxDepartCity.Size = new System.Drawing.Size(228, 28);
            this.comboxDepartCity.TabIndex = 42;
            // 
            // comboxArrivalCity
            // 
            this.comboxArrivalCity.FormattingEnabled = true;
            this.comboxArrivalCity.Items.AddRange(new object[] {
            "Free - State",
            "Gauteng",
            "KwaZulu-Natal",
            "North-West",
            "Northern -Cape",
            "Eastern-Cape",
            "Limpompo",
            "Mpumalanga",
            "Western Cape"});
            this.comboxArrivalCity.Location = new System.Drawing.Point(565, 122);
            this.comboxArrivalCity.Name = "comboxArrivalCity";
            this.comboxArrivalCity.Size = new System.Drawing.Size(228, 28);
            this.comboxArrivalCity.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(467, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "From:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(492, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 23);
            this.label10.TabIndex = 45;
            this.label10.Text = "To:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(446, 556);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 40);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTotalParcipants
            // 
            this.lblTotalParcipants.AutoSize = true;
            this.lblTotalParcipants.Location = new System.Drawing.Point(52, 684);
            this.lblTotalParcipants.Name = "lblTotalParcipants";
            this.lblTotalParcipants.Size = new System.Drawing.Size(122, 20);
            this.lblTotalParcipants.TabIndex = 35;
            this.lblTotalParcipants.Text = "Total Participants:";
            // 
            // txtTotalParticipants
            // 
            this.txtTotalParticipants.Location = new System.Drawing.Point(225, 678);
            this.txtTotalParticipants.Name = "txtTotalParticipants";
            this.txtTotalParticipants.Size = new System.Drawing.Size(103, 26);
            this.txtTotalParticipants.TabIndex = 36;
            this.txtTotalParticipants.TextChanged += new System.EventHandler(this.txtTotalParticipants_TextChanged);
            // 
            // frmflights
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1047, 749);
            this.Controls.Add(this.txtTotalParticipants);
            this.Controls.Add(this.lblTotalParcipants);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpTypeofClass);
            this.Controls.Add(this.grpCountry);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnFindingflights);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radOneway);
            this.Controls.Add(this.radroundtrip);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmflights";
            this.Text = "*";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.grpCountry.ResumeLayout(false);
            this.grpCountry.PerformLayout();
            this.grpTypeofClass.ResumeLayout(false);
            this.grpTypeofClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radroundtrip;
        private System.Windows.Forms.RadioButton radOneway;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFindingflights;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpCountry;
        private System.Windows.Forms.ComboBox cmbDestinatiom;
        private System.Windows.Forms.ComboBox cmbArrivaldestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radLocal;
        private System.Windows.Forms.RadioButton radInternational;
        private System.Windows.Forms.GroupBox grpTypeofClass;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radBussiness;
        private System.Windows.Forms.RadioButton radFirstclass;
        private System.Windows.Forms.RadioButton radEconomy;
        private System.Windows.Forms.ComboBox comboxArrivalCity;
        private System.Windows.Forms.ComboBox comboxDepartCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTotalParcipants;
        private System.Windows.Forms.TextBox txtTotalParticipants;
    }
}

