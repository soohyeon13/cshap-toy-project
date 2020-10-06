namespace timer1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.addAlarm = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.TextBox();
            this.alarmTimeSetLabel = new System.Windows.Forms.Label();
            this.secBtn = new System.Windows.Forms.TextBox();
            this.loopCheack = new System.Windows.Forms.CheckBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.startAlarm = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.delayLabel = new System.Windows.Forms.Label();
            this.deSecLabel = new System.Windows.Forms.Label();
            this.deMinLabel = new System.Windows.Forms.Label();
            this.desecBtn = new System.Windows.Forms.TextBox();
            this.deMinBtn = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.deSecLabel2 = new System.Windows.Forms.Label();
            this.deMinLabel2 = new System.Windows.Forms.Label();
            this.desecBtn2 = new System.Windows.Forms.TextBox();
            this.deMinBtn2 = new System.Windows.Forms.TextBox();
            this.delayLabel2 = new System.Windows.Forms.Label();
            this.timeLabel2 = new System.Windows.Forms.Label();
            this.stopBtn2 = new System.Windows.Forms.Button();
            this.startAlarm2 = new System.Windows.Forms.Button();
            this.secLabel2 = new System.Windows.Forms.Label();
            this.minLabel2 = new System.Windows.Forms.Label();
            this.loopCheack2 = new System.Windows.Forms.CheckBox();
            this.secBtn2 = new System.Windows.Forms.TextBox();
            this.alarmTimeSetLable2 = new System.Windows.Forms.Label();
            this.minBtn2 = new System.Windows.Forms.TextBox();
            this.deSecLabel3 = new System.Windows.Forms.Label();
            this.deMinLabel3 = new System.Windows.Forms.Label();
            this.desecBtn3 = new System.Windows.Forms.TextBox();
            this.deMinBtn3 = new System.Windows.Forms.TextBox();
            this.delayLabel3 = new System.Windows.Forms.Label();
            this.timeLabel3 = new System.Windows.Forms.Label();
            this.stopBtn3 = new System.Windows.Forms.Button();
            this.startAlarm3 = new System.Windows.Forms.Button();
            this.secLabel3 = new System.Windows.Forms.Label();
            this.minLabel3 = new System.Windows.Forms.Label();
            this.loopCheack3 = new System.Windows.Forms.CheckBox();
            this.secBtn3 = new System.Windows.Forms.TextBox();
            this.alarmTimeSetLabel3 = new System.Windows.Forms.Label();
            this.minBtn3 = new System.Windows.Forms.TextBox();
            this.alarmName = new System.Windows.Forms.TextBox();
            this.alarmName2 = new System.Windows.Forms.TextBox();
            this.alarmName3 = new System.Windows.Forms.TextBox();
            this.alarmNameSetLabel = new System.Windows.Forms.Label();
            this.alarmNameSetLabel2 = new System.Windows.Forms.Label();
            this.alarmNameSetLabel3 = new System.Windows.Forms.Label();
            this.alarmNameLabel = new System.Windows.Forms.Label();
            this.alarmNameLabel2 = new System.Windows.Forms.Label();
            this.alarmNameLabel3 = new System.Windows.Forms.Label();
            this.Alarm_changeBtn = new System.Windows.Forms.Button();
            this.Alarm_changeBtn2 = new System.Windows.Forms.Button();
            this.Alarm_changeBtn3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.미니모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // addAlarm
            // 
            this.addAlarm.Location = new System.Drawing.Point(97, 330);
            this.addAlarm.Name = "addAlarm";
            this.addAlarm.Size = new System.Drawing.Size(78, 22);
            this.addAlarm.TabIndex = 0;
            this.addAlarm.TabStop = false;
            this.addAlarm.Text = "알람추가";
            this.addAlarm.UseVisualStyleBackColor = true;
            this.addAlarm.Click += new System.EventHandler(this.button1_Click);
            // 
            // minBtn
            // 
            this.minBtn.Location = new System.Drawing.Point(74, 134);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(44, 21);
            this.minBtn.TabIndex = 1;
            this.minBtn.TabStop = false;
            this.minBtn.TextChanged += new System.EventHandler(this.minBtn_TextChanged);
            this.minBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minPress);
            // 
            // alarmTimeSetLabel
            // 
            this.alarmTimeSetLabel.AutoSize = true;
            this.alarmTimeSetLabel.Font = new System.Drawing.Font("굴림", 12F);
            this.alarmTimeSetLabel.Location = new System.Drawing.Point(71, 97);
            this.alarmTimeSetLabel.Name = "alarmTimeSetLabel";
            this.alarmTimeSetLabel.Size = new System.Drawing.Size(104, 16);
            this.alarmTimeSetLabel.TabIndex = 2;
            this.alarmTimeSetLabel.Text = "알람시간설정";
            this.alarmTimeSetLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // secBtn
            // 
            this.secBtn.Location = new System.Drawing.Point(147, 134);
            this.secBtn.Name = "secBtn";
            this.secBtn.Size = new System.Drawing.Size(49, 21);
            this.secBtn.TabIndex = 3;
            this.secBtn.TabStop = false;
            this.secBtn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.secBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secBtn_KeyPress);
            // 
            // loopCheack
            // 
            this.loopCheack.AutoSize = true;
            this.loopCheack.Location = new System.Drawing.Point(187, 223);
            this.loopCheack.Name = "loopCheack";
            this.loopCheack.Size = new System.Drawing.Size(48, 16);
            this.loopCheack.TabIndex = 5;
            this.loopCheack.TabStop = false;
            this.loopCheack.Text = "반복";
            this.loopCheack.UseVisualStyleBackColor = true;
            this.loopCheack.CheckedChanged += new System.EventHandler(this.loopCheack_CheckedChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(124, 137);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(17, 12);
            this.minLabel.TabIndex = 6;
            this.minLabel.Text = "분";
            this.minLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Location = new System.Drawing.Point(202, 137);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(17, 12);
            this.secLabel.TabIndex = 7;
            this.secLabel.Text = "초";
            this.secLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // startAlarm
            // 
            this.startAlarm.Location = new System.Drawing.Point(63, 268);
            this.startAlarm.Name = "startAlarm";
            this.startAlarm.Size = new System.Drawing.Size(78, 22);
            this.startAlarm.TabIndex = 8;
            this.startAlarm.TabStop = false;
            this.startAlarm.Text = "알람시작";
            this.startAlarm.UseVisualStyleBackColor = true;
            this.startAlarm.Click += new System.EventHandler(this.startAlarm_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.CausesValidation = false;
            this.stopBtn.Location = new System.Drawing.Point(157, 268);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(78, 22);
            this.stopBtn.TabIndex = 9;
            this.stopBtn.TabStop = false;
            this.stopBtn.Text = "알람정지";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.timeLabel.Location = new System.Drawing.Point(70, 134);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(150, 86);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeLabel.Visible = false;
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Font = new System.Drawing.Font("굴림", 12F);
            this.delayLabel.Location = new System.Drawing.Point(71, 171);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(120, 16);
            this.delayLabel.TabIndex = 11;
            this.delayLabel.Text = "딜레이시간설정";
            this.delayLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // deSecLabel
            // 
            this.deSecLabel.AutoSize = true;
            this.deSecLabel.Location = new System.Drawing.Point(202, 199);
            this.deSecLabel.Name = "deSecLabel";
            this.deSecLabel.Size = new System.Drawing.Size(17, 12);
            this.deSecLabel.TabIndex = 15;
            this.deSecLabel.Text = "초";
            // 
            // deMinLabel
            // 
            this.deMinLabel.AutoSize = true;
            this.deMinLabel.Location = new System.Drawing.Point(124, 199);
            this.deMinLabel.Name = "deMinLabel";
            this.deMinLabel.Size = new System.Drawing.Size(17, 12);
            this.deMinLabel.TabIndex = 14;
            this.deMinLabel.Text = "분";
            // 
            // desecBtn
            // 
            this.desecBtn.Location = new System.Drawing.Point(147, 196);
            this.desecBtn.Name = "desecBtn";
            this.desecBtn.Size = new System.Drawing.Size(49, 21);
            this.desecBtn.TabIndex = 13;
            this.desecBtn.TabStop = false;
            this.desecBtn.TextChanged += new System.EventHandler(this.desecBtn_TextChanged);
            this.desecBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deSecPress);
            // 
            // deMinBtn
            // 
            this.deMinBtn.Location = new System.Drawing.Point(74, 196);
            this.deMinBtn.Name = "deMinBtn";
            this.deMinBtn.Size = new System.Drawing.Size(44, 21);
            this.deMinBtn.TabIndex = 12;
            this.deMinBtn.TabStop = false;
            this.deMinBtn.TextChanged += new System.EventHandler(this.deMinBtn_TextChanged);
            this.deMinBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deMinPress);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // deSecLabel2
            // 
            this.deSecLabel2.AutoSize = true;
            this.deSecLabel2.Location = new System.Drawing.Point(517, 199);
            this.deSecLabel2.Name = "deSecLabel2";
            this.deSecLabel2.Size = new System.Drawing.Size(17, 12);
            this.deSecLabel2.TabIndex = 30;
            this.deSecLabel2.Text = "초";
            // 
            // deMinLabel2
            // 
            this.deMinLabel2.AutoSize = true;
            this.deMinLabel2.Location = new System.Drawing.Point(439, 199);
            this.deMinLabel2.Name = "deMinLabel2";
            this.deMinLabel2.Size = new System.Drawing.Size(17, 12);
            this.deMinLabel2.TabIndex = 29;
            this.deMinLabel2.Text = "분";
            // 
            // desecBtn2
            // 
            this.desecBtn2.Location = new System.Drawing.Point(462, 196);
            this.desecBtn2.Name = "desecBtn2";
            this.desecBtn2.Size = new System.Drawing.Size(49, 21);
            this.desecBtn2.TabIndex = 28;
            this.desecBtn2.TabStop = false;
            this.desecBtn2.TextChanged += new System.EventHandler(this.desecBtn2_TextChanged);
            this.desecBtn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.desecBtn2_KeyPress);
            // 
            // deMinBtn2
            // 
            this.deMinBtn2.Location = new System.Drawing.Point(389, 196);
            this.deMinBtn2.Name = "deMinBtn2";
            this.deMinBtn2.Size = new System.Drawing.Size(44, 21);
            this.deMinBtn2.TabIndex = 27;
            this.deMinBtn2.TabStop = false;
            this.deMinBtn2.TextChanged += new System.EventHandler(this.deMinBtn2_TextChanged);
            this.deMinBtn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deMinBtn2_KeyPress);
            // 
            // delayLabel2
            // 
            this.delayLabel2.AutoSize = true;
            this.delayLabel2.Font = new System.Drawing.Font("굴림", 12F);
            this.delayLabel2.Location = new System.Drawing.Point(386, 171);
            this.delayLabel2.Name = "delayLabel2";
            this.delayLabel2.Size = new System.Drawing.Size(120, 16);
            this.delayLabel2.TabIndex = 26;
            this.delayLabel2.Text = "딜레이시간설정";
            // 
            // timeLabel2
            // 
            this.timeLabel2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.timeLabel2.Location = new System.Drawing.Point(385, 130);
            this.timeLabel2.Name = "timeLabel2";
            this.timeLabel2.Size = new System.Drawing.Size(150, 86);
            this.timeLabel2.TabIndex = 25;
            this.timeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeLabel2.Visible = false;
            // 
            // stopBtn2
            // 
            this.stopBtn2.Location = new System.Drawing.Point(472, 268);
            this.stopBtn2.Name = "stopBtn2";
            this.stopBtn2.Size = new System.Drawing.Size(78, 22);
            this.stopBtn2.TabIndex = 24;
            this.stopBtn2.TabStop = false;
            this.stopBtn2.Text = "알람정지";
            this.stopBtn2.UseVisualStyleBackColor = true;
            this.stopBtn2.Click += new System.EventHandler(this.stopBtn2_Click);
            // 
            // startAlarm2
            // 
            this.startAlarm2.Location = new System.Drawing.Point(378, 268);
            this.startAlarm2.Name = "startAlarm2";
            this.startAlarm2.Size = new System.Drawing.Size(78, 22);
            this.startAlarm2.TabIndex = 23;
            this.startAlarm2.TabStop = false;
            this.startAlarm2.Text = "알람시작";
            this.startAlarm2.UseVisualStyleBackColor = true;
            this.startAlarm2.Click += new System.EventHandler(this.startAlarm2_Click);
            // 
            // secLabel2
            // 
            this.secLabel2.AutoSize = true;
            this.secLabel2.Location = new System.Drawing.Point(517, 137);
            this.secLabel2.Name = "secLabel2";
            this.secLabel2.Size = new System.Drawing.Size(17, 12);
            this.secLabel2.TabIndex = 22;
            this.secLabel2.Text = "초";
            // 
            // minLabel2
            // 
            this.minLabel2.AutoSize = true;
            this.minLabel2.Location = new System.Drawing.Point(439, 137);
            this.minLabel2.Name = "minLabel2";
            this.minLabel2.Size = new System.Drawing.Size(17, 12);
            this.minLabel2.TabIndex = 21;
            this.minLabel2.Text = "분";
            // 
            // loopCheack2
            // 
            this.loopCheack2.AutoSize = true;
            this.loopCheack2.Location = new System.Drawing.Point(502, 223);
            this.loopCheack2.Name = "loopCheack2";
            this.loopCheack2.Size = new System.Drawing.Size(48, 16);
            this.loopCheack2.TabIndex = 20;
            this.loopCheack2.TabStop = false;
            this.loopCheack2.Text = "반복";
            this.loopCheack2.UseVisualStyleBackColor = true;
            // 
            // secBtn2
            // 
            this.secBtn2.Location = new System.Drawing.Point(462, 134);
            this.secBtn2.Name = "secBtn2";
            this.secBtn2.Size = new System.Drawing.Size(49, 21);
            this.secBtn2.TabIndex = 19;
            this.secBtn2.TabStop = false;
            this.secBtn2.TextChanged += new System.EventHandler(this.secBtn2_TextChanged);
            this.secBtn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secBtn2_KeyPress);
            // 
            // alarmTimeSetLable2
            // 
            this.alarmTimeSetLable2.AutoSize = true;
            this.alarmTimeSetLable2.Font = new System.Drawing.Font("굴림", 12F);
            this.alarmTimeSetLable2.Location = new System.Drawing.Point(386, 97);
            this.alarmTimeSetLable2.Name = "alarmTimeSetLable2";
            this.alarmTimeSetLable2.Size = new System.Drawing.Size(104, 16);
            this.alarmTimeSetLable2.TabIndex = 18;
            this.alarmTimeSetLable2.Text = "알람시간설정";
            // 
            // minBtn2
            // 
            this.minBtn2.Location = new System.Drawing.Point(389, 134);
            this.minBtn2.Name = "minBtn2";
            this.minBtn2.Size = new System.Drawing.Size(44, 21);
            this.minBtn2.TabIndex = 17;
            this.minBtn2.TabStop = false;
            this.minBtn2.TextChanged += new System.EventHandler(this.minBtn2_TextChanged);
            this.minBtn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minBtn2_KeyPress);
            // 
            // deSecLabel3
            // 
            this.deSecLabel3.AutoSize = true;
            this.deSecLabel3.Location = new System.Drawing.Point(810, 199);
            this.deSecLabel3.Name = "deSecLabel3";
            this.deSecLabel3.Size = new System.Drawing.Size(17, 12);
            this.deSecLabel3.TabIndex = 45;
            this.deSecLabel3.Text = "초";
            // 
            // deMinLabel3
            // 
            this.deMinLabel3.AutoSize = true;
            this.deMinLabel3.Location = new System.Drawing.Point(732, 199);
            this.deMinLabel3.Name = "deMinLabel3";
            this.deMinLabel3.Size = new System.Drawing.Size(17, 12);
            this.deMinLabel3.TabIndex = 44;
            this.deMinLabel3.Text = "분";
            // 
            // desecBtn3
            // 
            this.desecBtn3.Location = new System.Drawing.Point(755, 196);
            this.desecBtn3.Name = "desecBtn3";
            this.desecBtn3.Size = new System.Drawing.Size(49, 21);
            this.desecBtn3.TabIndex = 43;
            this.desecBtn3.TabStop = false;
            this.desecBtn3.TextChanged += new System.EventHandler(this.desecBtn3_TextChanged);
            this.desecBtn3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.desecBtn3_KeyPress);
            // 
            // deMinBtn3
            // 
            this.deMinBtn3.Location = new System.Drawing.Point(682, 196);
            this.deMinBtn3.Name = "deMinBtn3";
            this.deMinBtn3.Size = new System.Drawing.Size(44, 21);
            this.deMinBtn3.TabIndex = 42;
            this.deMinBtn3.TabStop = false;
            this.deMinBtn3.TextChanged += new System.EventHandler(this.deMinBtn3_TextChanged);
            this.deMinBtn3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deMinBtn3_KeyPress);
            // 
            // delayLabel3
            // 
            this.delayLabel3.AutoSize = true;
            this.delayLabel3.Font = new System.Drawing.Font("굴림", 12F);
            this.delayLabel3.Location = new System.Drawing.Point(679, 171);
            this.delayLabel3.Name = "delayLabel3";
            this.delayLabel3.Size = new System.Drawing.Size(120, 16);
            this.delayLabel3.TabIndex = 41;
            this.delayLabel3.Text = "딜레이시간설정";
            // 
            // timeLabel3
            // 
            this.timeLabel3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.timeLabel3.Location = new System.Drawing.Point(678, 130);
            this.timeLabel3.Name = "timeLabel3";
            this.timeLabel3.Size = new System.Drawing.Size(150, 86);
            this.timeLabel3.TabIndex = 40;
            this.timeLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeLabel3.Visible = false;
            // 
            // stopBtn3
            // 
            this.stopBtn3.Location = new System.Drawing.Point(766, 268);
            this.stopBtn3.Name = "stopBtn3";
            this.stopBtn3.Size = new System.Drawing.Size(78, 22);
            this.stopBtn3.TabIndex = 39;
            this.stopBtn3.TabStop = false;
            this.stopBtn3.Text = "알람정지";
            this.stopBtn3.UseVisualStyleBackColor = true;
            this.stopBtn3.Click += new System.EventHandler(this.stopBtn3_Click);
            // 
            // startAlarm3
            // 
            this.startAlarm3.Location = new System.Drawing.Point(682, 268);
            this.startAlarm3.Name = "startAlarm3";
            this.startAlarm3.Size = new System.Drawing.Size(78, 22);
            this.startAlarm3.TabIndex = 38;
            this.startAlarm3.TabStop = false;
            this.startAlarm3.Text = "알람시작";
            this.startAlarm3.UseVisualStyleBackColor = true;
            this.startAlarm3.Click += new System.EventHandler(this.startAlarm3_Click);
            // 
            // secLabel3
            // 
            this.secLabel3.AutoSize = true;
            this.secLabel3.Location = new System.Drawing.Point(810, 137);
            this.secLabel3.Name = "secLabel3";
            this.secLabel3.Size = new System.Drawing.Size(17, 12);
            this.secLabel3.TabIndex = 37;
            this.secLabel3.Text = "초";
            // 
            // minLabel3
            // 
            this.minLabel3.AutoSize = true;
            this.minLabel3.Location = new System.Drawing.Point(732, 137);
            this.minLabel3.Name = "minLabel3";
            this.minLabel3.Size = new System.Drawing.Size(17, 12);
            this.minLabel3.TabIndex = 36;
            this.minLabel3.Text = "분";
            // 
            // loopCheack3
            // 
            this.loopCheack3.AutoSize = true;
            this.loopCheack3.Location = new System.Drawing.Point(795, 223);
            this.loopCheack3.Name = "loopCheack3";
            this.loopCheack3.Size = new System.Drawing.Size(48, 16);
            this.loopCheack3.TabIndex = 35;
            this.loopCheack3.TabStop = false;
            this.loopCheack3.Text = "반복";
            this.loopCheack3.UseVisualStyleBackColor = true;
            // 
            // secBtn3
            // 
            this.secBtn3.Location = new System.Drawing.Point(755, 134);
            this.secBtn3.Name = "secBtn3";
            this.secBtn3.Size = new System.Drawing.Size(49, 21);
            this.secBtn3.TabIndex = 34;
            this.secBtn3.TabStop = false;
            this.secBtn3.TextChanged += new System.EventHandler(this.secBtn3_TextChanged);
            this.secBtn3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secBtn3_KeyPress);
            // 
            // alarmTimeSetLabel3
            // 
            this.alarmTimeSetLabel3.AutoSize = true;
            this.alarmTimeSetLabel3.Font = new System.Drawing.Font("굴림", 12F);
            this.alarmTimeSetLabel3.Location = new System.Drawing.Point(679, 97);
            this.alarmTimeSetLabel3.Name = "alarmTimeSetLabel3";
            this.alarmTimeSetLabel3.Size = new System.Drawing.Size(104, 16);
            this.alarmTimeSetLabel3.TabIndex = 33;
            this.alarmTimeSetLabel3.Text = "알람시간설정";
            // 
            // minBtn3
            // 
            this.minBtn3.Location = new System.Drawing.Point(682, 134);
            this.minBtn3.Name = "minBtn3";
            this.minBtn3.Size = new System.Drawing.Size(44, 21);
            this.minBtn3.TabIndex = 32;
            this.minBtn3.TabStop = false;
            this.minBtn3.TextChanged += new System.EventHandler(this.minBtn3_TextChanged);
            this.minBtn3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minBtn3_KeyPress);
            // 
            // alarmName
            // 
            this.alarmName.Location = new System.Drawing.Point(74, 55);
            this.alarmName.Name = "alarmName";
            this.alarmName.Size = new System.Drawing.Size(101, 21);
            this.alarmName.TabIndex = 46;
            this.alarmName.TabStop = false;
            this.alarmName.TextChanged += new System.EventHandler(this.alarmName_TextChanged);
            this.alarmName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alarmName_KeyPress);
            // 
            // alarmName2
            // 
            this.alarmName2.Location = new System.Drawing.Point(383, 55);
            this.alarmName2.Name = "alarmName2";
            this.alarmName2.Size = new System.Drawing.Size(101, 21);
            this.alarmName2.TabIndex = 47;
            this.alarmName2.TabStop = false;
            this.alarmName2.TextChanged += new System.EventHandler(this.alarmName2_TextChanged);
            this.alarmName2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alarmName2_KeyPress);
            // 
            // alarmName3
            // 
            this.alarmName3.Location = new System.Drawing.Point(682, 55);
            this.alarmName3.Name = "alarmName3";
            this.alarmName3.Size = new System.Drawing.Size(101, 21);
            this.alarmName3.TabIndex = 48;
            this.alarmName3.TabStop = false;
            this.alarmName3.TextChanged += new System.EventHandler(this.alarmName3_TextChanged);
            this.alarmName3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alarmName3_KeyPress);
            // 
            // alarmNameSetLabel
            // 
            this.alarmNameSetLabel.AutoSize = true;
            this.alarmNameSetLabel.Font = new System.Drawing.Font("굴림", 12F);
            this.alarmNameSetLabel.Location = new System.Drawing.Point(71, 24);
            this.alarmNameSetLabel.Name = "alarmNameSetLabel";
            this.alarmNameSetLabel.Size = new System.Drawing.Size(104, 16);
            this.alarmNameSetLabel.TabIndex = 49;
            this.alarmNameSetLabel.Text = "알람이름설정";
            // 
            // alarmNameSetLabel2
            // 
            this.alarmNameSetLabel2.AutoSize = true;
            this.alarmNameSetLabel2.Font = new System.Drawing.Font("굴림", 12F);
            this.alarmNameSetLabel2.Location = new System.Drawing.Point(380, 24);
            this.alarmNameSetLabel2.Name = "alarmNameSetLabel2";
            this.alarmNameSetLabel2.Size = new System.Drawing.Size(104, 16);
            this.alarmNameSetLabel2.TabIndex = 50;
            this.alarmNameSetLabel2.Text = "알람이름설정";
            // 
            // alarmNameSetLabel3
            // 
            this.alarmNameSetLabel3.AutoSize = true;
            this.alarmNameSetLabel3.Font = new System.Drawing.Font("굴림", 12F);
            this.alarmNameSetLabel3.Location = new System.Drawing.Point(679, 24);
            this.alarmNameSetLabel3.Name = "alarmNameSetLabel3";
            this.alarmNameSetLabel3.Size = new System.Drawing.Size(104, 16);
            this.alarmNameSetLabel3.TabIndex = 51;
            this.alarmNameSetLabel3.Text = "알람이름설정";
            // 
            // alarmNameLabel
            // 
            this.alarmNameLabel.AutoSize = true;
            this.alarmNameLabel.Font = new System.Drawing.Font("굴림", 18F);
            this.alarmNameLabel.Location = new System.Drawing.Point(59, 55);
            this.alarmNameLabel.Name = "alarmNameLabel";
            this.alarmNameLabel.Size = new System.Drawing.Size(154, 24);
            this.alarmNameLabel.TabIndex = 52;
            this.alarmNameLabel.Text = "알람시간설정";
            this.alarmNameLabel.Visible = false;
            // 
            // alarmNameLabel2
            // 
            this.alarmNameLabel2.AutoSize = true;
            this.alarmNameLabel2.Font = new System.Drawing.Font("굴림", 18F);
            this.alarmNameLabel2.Location = new System.Drawing.Point(379, 55);
            this.alarmNameLabel2.Name = "alarmNameLabel2";
            this.alarmNameLabel2.Size = new System.Drawing.Size(154, 24);
            this.alarmNameLabel2.TabIndex = 53;
            this.alarmNameLabel2.Text = "알람시간설정";
            this.alarmNameLabel2.Visible = false;
            // 
            // alarmNameLabel3
            // 
            this.alarmNameLabel3.AutoSize = true;
            this.alarmNameLabel3.Font = new System.Drawing.Font("굴림", 18F);
            this.alarmNameLabel3.Location = new System.Drawing.Point(678, 55);
            this.alarmNameLabel3.Name = "alarmNameLabel3";
            this.alarmNameLabel3.Size = new System.Drawing.Size(154, 24);
            this.alarmNameLabel3.TabIndex = 54;
            this.alarmNameLabel3.Text = "알람시간설정";
            this.alarmNameLabel3.Visible = false;
            // 
            // Alarm_changeBtn
            // 
            this.Alarm_changeBtn.Location = new System.Drawing.Point(63, 223);
            this.Alarm_changeBtn.Name = "Alarm_changeBtn";
            this.Alarm_changeBtn.Size = new System.Drawing.Size(112, 22);
            this.Alarm_changeBtn.TabIndex = 55;
            this.Alarm_changeBtn.TabStop = false;
            this.Alarm_changeBtn.Text = "재시작(&F10)";
            this.Alarm_changeBtn.UseVisualStyleBackColor = true;
            this.Alarm_changeBtn.Click += new System.EventHandler(this.Alarm_changeBtn_Click);
            // 
            // Alarm_changeBtn2
            // 
            this.Alarm_changeBtn2.Location = new System.Drawing.Point(378, 223);
            this.Alarm_changeBtn2.Name = "Alarm_changeBtn2";
            this.Alarm_changeBtn2.Size = new System.Drawing.Size(106, 22);
            this.Alarm_changeBtn2.TabIndex = 56;
            this.Alarm_changeBtn2.TabStop = false;
            this.Alarm_changeBtn2.Text = "재시작(&F11)";
            this.Alarm_changeBtn2.UseVisualStyleBackColor = true;
            this.Alarm_changeBtn2.Click += new System.EventHandler(this.Alarm_changeBtn2_Click);
            // 
            // Alarm_changeBtn3
            // 
            this.Alarm_changeBtn3.Location = new System.Drawing.Point(682, 226);
            this.Alarm_changeBtn3.Name = "Alarm_changeBtn3";
            this.Alarm_changeBtn3.Size = new System.Drawing.Size(101, 22);
            this.Alarm_changeBtn3.TabIndex = 57;
            this.Alarm_changeBtn3.TabStop = false;
            this.Alarm_changeBtn3.Text = "재시작(&F12)";
            this.Alarm_changeBtn3.UseVisualStyleBackColor = true;
            this.Alarm_changeBtn3.Click += new System.EventHandler(this.Alarm_changeBtn_Click3);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.미니모드ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 미니모드ToolStripMenuItem
            // 
            this.미니모드ToolStripMenuItem.Name = "미니모드ToolStripMenuItem";
            this.미니모드ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + F1";
            this.미니모드ToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.미니모드ToolStripMenuItem.Text = "미니모드";
            this.미니모드ToolStripMenuItem.Click += new System.EventHandler(this.미니모드ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 358);
            this.Controls.Add(this.Alarm_changeBtn3);
            this.Controls.Add(this.Alarm_changeBtn2);
            this.Controls.Add(this.Alarm_changeBtn);
            this.Controls.Add(this.alarmNameLabel3);
            this.Controls.Add(this.alarmNameLabel2);
            this.Controls.Add(this.alarmNameLabel);
            this.Controls.Add(this.alarmNameSetLabel3);
            this.Controls.Add(this.alarmNameSetLabel2);
            this.Controls.Add(this.alarmNameSetLabel);
            this.Controls.Add(this.alarmName3);
            this.Controls.Add(this.alarmName2);
            this.Controls.Add(this.alarmName);
            this.Controls.Add(this.deSecLabel3);
            this.Controls.Add(this.deMinLabel3);
            this.Controls.Add(this.desecBtn3);
            this.Controls.Add(this.deMinBtn3);
            this.Controls.Add(this.delayLabel3);
            this.Controls.Add(this.timeLabel3);
            this.Controls.Add(this.stopBtn3);
            this.Controls.Add(this.startAlarm3);
            this.Controls.Add(this.secLabel3);
            this.Controls.Add(this.minLabel3);
            this.Controls.Add(this.loopCheack3);
            this.Controls.Add(this.secBtn3);
            this.Controls.Add(this.alarmTimeSetLabel3);
            this.Controls.Add(this.minBtn3);
            this.Controls.Add(this.deSecLabel2);
            this.Controls.Add(this.deMinLabel2);
            this.Controls.Add(this.desecBtn2);
            this.Controls.Add(this.deMinBtn2);
            this.Controls.Add(this.delayLabel2);
            this.Controls.Add(this.timeLabel2);
            this.Controls.Add(this.stopBtn2);
            this.Controls.Add(this.startAlarm2);
            this.Controls.Add(this.secLabel2);
            this.Controls.Add(this.minLabel2);
            this.Controls.Add(this.loopCheack2);
            this.Controls.Add(this.secBtn2);
            this.Controls.Add(this.alarmTimeSetLable2);
            this.Controls.Add(this.minBtn2);
            this.Controls.Add(this.deSecLabel);
            this.Controls.Add(this.deMinLabel);
            this.Controls.Add(this.desecBtn);
            this.Controls.Add(this.deMinBtn);
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startAlarm);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.loopCheack);
            this.Controls.Add(this.secBtn);
            this.Controls.Add(this.alarmTimeSetLabel);
            this.Controls.Add(this.minBtn);
            this.Controls.Add(this.addAlarm);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button addAlarm;
        private System.Windows.Forms.TextBox minBtn;
        private System.Windows.Forms.Label alarmTimeSetLabel;
        private System.Windows.Forms.TextBox secBtn;
        private System.Windows.Forms.CheckBox loopCheack;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.Button startAlarm;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.Label deSecLabel;
        private System.Windows.Forms.Label deMinLabel;
        private System.Windows.Forms.TextBox desecBtn;
        private System.Windows.Forms.TextBox deMinBtn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label deSecLabel2;
        private System.Windows.Forms.Label deMinLabel2;
        private System.Windows.Forms.TextBox desecBtn2;
        private System.Windows.Forms.TextBox deMinBtn2;
        private System.Windows.Forms.Label delayLabel2;
        private System.Windows.Forms.Label timeLabel2;
        private System.Windows.Forms.Button stopBtn2;
        private System.Windows.Forms.Button startAlarm2;
        private System.Windows.Forms.Label secLabel2;
        private System.Windows.Forms.Label minLabel2;
        private System.Windows.Forms.CheckBox loopCheack2;
        private System.Windows.Forms.TextBox secBtn2;
        private System.Windows.Forms.Label alarmTimeSetLable2;
        private System.Windows.Forms.TextBox minBtn2;
        private System.Windows.Forms.Label deSecLabel3;
        private System.Windows.Forms.Label deMinLabel3;
        private System.Windows.Forms.TextBox desecBtn3;
        private System.Windows.Forms.TextBox deMinBtn3;
        private System.Windows.Forms.Label delayLabel3;
        private System.Windows.Forms.Label timeLabel3;
        private System.Windows.Forms.Button stopBtn3;
        private System.Windows.Forms.Button startAlarm3;
        private System.Windows.Forms.Label secLabel3;
        private System.Windows.Forms.Label minLabel3;
        private System.Windows.Forms.CheckBox loopCheack3;
        private System.Windows.Forms.TextBox secBtn3;
        private System.Windows.Forms.Label alarmTimeSetLabel3;
        private System.Windows.Forms.TextBox minBtn3;
        private System.Windows.Forms.TextBox alarmName;
        private System.Windows.Forms.TextBox alarmName2;
        private System.Windows.Forms.TextBox alarmName3;
        private System.Windows.Forms.Label alarmNameSetLabel;
        private System.Windows.Forms.Label alarmNameSetLabel2;
        private System.Windows.Forms.Label alarmNameSetLabel3;
        private System.Windows.Forms.Label alarmNameLabel;
        private System.Windows.Forms.Label alarmNameLabel2;
        private System.Windows.Forms.Label alarmNameLabel3;
        private System.Windows.Forms.Button Alarm_changeBtn;
        private System.Windows.Forms.Button Alarm_changeBtn2;
        private System.Windows.Forms.Button Alarm_changeBtn3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 미니모드ToolStripMenuItem;
    }
}

