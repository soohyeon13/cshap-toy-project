using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace timer1
{
    public partial class Form1 : Form
    {


        int minBefore = 0;
        int minBefore2 = 0;
        int minBefore3 = 0;

        int secBefore = 0;
        int secBefore2 = 0;
        int secBefore3 = 0;

        int delayMinBefore = 0;
        int delayMinBefore2 = 0;
        int delayMinBefore3 = 0;

        int delaySecBefore = 0;
        int delaySecBefore2 = 0;
        int delaySecBefore3 = 0;

        int time = 0;
        int time2 = 0;
        int time3 = 0;

        int delayTime = 0;
        int delayTime2 = 0;
        int delayTime3 = 0;

        int delaySaveTime = 0;
        int delaySaveTime2 = 0;
        int delaySaveTime3 = 0;

        int saveTime = 0;
        int saveTime2 = 0;
        int saveTime3 = 0;

        int addCount = 0;

        int pause = 0;
        int pause2 = 0;
        int pause3 = 0;

        bool endTime = false;
        bool endTime2 = false;
        bool endTime3 = false;

        bool reStart = false;
        bool reStart2 = false;
        bool reStart3 = false;

        string alarmNameVar = "알람이름설정안함";
        string alarmNameVar2 = "알람이름설정안함";
        string alarmNameVar3 = "알람이름설정안함";

        public Form1()
        {
            InitializeComponent();
            
            this.Width = 310;
            secBtn.MaxLength = 5;
            minBtn.MaxLength = 5;
            deMinBtn.MaxLength = 5;
            desecBtn.MaxLength = 5;

            stopBtn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(addCount < 2)
            {
                this.Width += 300;
                addCount++;
            }
            else
            {
                addAlarm.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        

        private void timer1_Tick(object sender, EventArgs e)
        {

            timertick(timeLabel, loopCheack, timer1,ref time,ref delayTime,ref endTime,ref saveTime, ref delaySaveTime, ref reStart);

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timertick(timeLabel2, loopCheack2, timer2, ref time2, ref delayTime2, ref endTime2, ref saveTime2, ref delaySaveTime2, ref reStart2);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            timertick(timeLabel3, loopCheack3, timer3, ref time3, ref delayTime3, ref endTime3, ref saveTime3, ref delaySaveTime3, ref reStart3);
        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {


            stopAlr(timer1, timeLabel, stopBtn, minBtn, secBtn, deMinBtn, desecBtn, minLabel, secLabel, deMinLabel, 
                deSecLabel, delayLabel, loopCheack, startAlarm, ref time, ref delayTime, alarmTimeSetLabel, alarmName, 
                alarmNameSetLabel, alarmNameLabel);
            
        }

        private void stopBtn2_Click(object sender, EventArgs e)
        {
            stopAlr(timer2, timeLabel2, stopBtn2, minBtn2, secBtn2, deMinBtn2, desecBtn2, minLabel2, secLabel2, deMinLabel2,
                deSecLabel2, delayLabel2, loopCheack2, startAlarm2, ref time2, ref delayTime2
                , alarmTimeSetLable2, alarmName2, alarmNameSetLabel2, alarmNameLabel2);
        }

        private void stopBtn3_Click(object sender, EventArgs e)
        {
            stopAlr(timer3, timeLabel3, stopBtn3, minBtn3, secBtn3, deMinBtn3, desecBtn3, minLabel3, secLabel3, deMinLabel3,
                deSecLabel3, delayLabel3, loopCheack3, startAlarm3, ref time3, ref delayTime3,
                alarmTimeSetLabel3, alarmName3, alarmNameSetLabel3, alarmNameLabel3);
        }
        
        private void startAlarm_Click(object sender, EventArgs e)
        {

            startalr(minBtn, secBtn, deMinBtn, desecBtn, minLabel, secLabel, deMinLabel, deSecLabel, delayLabel,timeLabel,
                loopCheack,stopBtn,startAlarm, alarmTimeSetLabel, alarmName, alarmNameSetLabel, alarmNameLabel);

            time = minBefore + secBefore;
            delayTime = delayMinBefore + delaySecBefore;

            saveTime = time;
            delaySaveTime = delayTime;

            alarmNameLabel.Text = alarmNameVar;

            timer1.Start();
            
        }
        private void startAlarm2_Click(object sender, EventArgs e)
        {
            startalr(minBtn2, secBtn2, deMinBtn2, desecBtn2, minLabel2, secLabel2, deMinLabel2, deSecLabel2, delayLabel2, timeLabel2,
                loopCheack2, stopBtn2, startAlarm2, alarmTimeSetLable2, alarmName2, alarmNameSetLabel2, alarmNameLabel2);

            time2 = minBefore2 + secBefore2;
            delayTime2 = delayMinBefore2 + delaySecBefore2;

            saveTime2 = time2;
            
            delaySaveTime2 = delayTime2;

            alarmNameLabel2.Text = alarmNameVar2;

            timer2.Start();
        }

        private void startAlarm3_Click(object sender, EventArgs e)
        {
            startalr(minBtn3, secBtn3, deMinBtn3, desecBtn3, minLabel3, secLabel3, deMinLabel3, deSecLabel3, delayLabel3, timeLabel3,
                loopCheack3, stopBtn3, startAlarm3, alarmTimeSetLabel3, alarmName3, alarmNameSetLabel3, alarmNameLabel3);

            time3 = minBefore3 + secBefore3;
            delayTime3 = delayMinBefore3 + delaySecBefore3;

            saveTime3 = time3;
            delaySaveTime3 = delayTime3;

            alarmNameLabel3.Text = alarmNameVar3;

            timer3.Start();
        }
        private void timeLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void loopCheack_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void minBtn_TextChanged(object sender, EventArgs e)
        {

            minBefore = minTextBox_Changed(minBtn, minBefore);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            secBefore = secTextBox_Changed(secBtn, secBefore);
        }
        private void deMinBtn_TextChanged(object sender, EventArgs e)
        {
           delayMinBefore =  deMinTextBox_Changed(deMinBtn, delayMinBefore);
            
        }

        private void desecBtn_TextChanged(object sender, EventArgs e)
        {
            delaySecBefore =  deSecTextBox_Changed(desecBtn, delaySecBefore);

        }
        private void minBtn2_TextChanged(object sender, EventArgs e)
        {

            minBefore2 = minTextBox_Changed(minBtn2, minBefore2);
        }
        private void secBtn2_TextChanged(object sender, EventArgs e)
        {
            secBefore2 = secTextBox_Changed(secBtn2, secBefore2);
        }
        private void deMinBtn2_TextChanged(object sender, EventArgs e)
        {
            delayMinBefore2 = deMinTextBox_Changed(deMinBtn2, delayMinBefore2);

        }

        private void desecBtn2_TextChanged(object sender, EventArgs e)
        {
            delaySecBefore2 = deSecTextBox_Changed(desecBtn2, delaySecBefore2);

        }
        private void minBtn3_TextChanged(object sender, EventArgs e)
        {

            minBefore3 = minTextBox_Changed(minBtn3, minBefore3);
        }
        private void secBtn3_TextChanged(object sender, EventArgs e)
        {
            secBefore3 = secTextBox_Changed(secBtn3, secBefore3);
        }
        private void deMinBtn3_TextChanged(object sender, EventArgs e)
        {
            delayMinBefore3 = deMinTextBox_Changed(deMinBtn3, delayMinBefore3);

        }

        private void desecBtn3_TextChanged(object sender, EventArgs e)
        {
            delaySecBefore3 = deSecTextBox_Changed(desecBtn3, delaySecBefore3);

        }

        private void timertick(Label label, CheckBox checkBox, Timer timer, ref int times, ref int delayTimes, ref bool endTimes, ref int saveTimes,
            ref int delaySaveTimes, ref bool restarts)
        {
            



            int min = times / 60;
            int sec = times % 60;

            int delayMin = delayTimes / 60;
            int delaySec = delayTimes % 60;


            if (times > 0 && restarts ==false)
            {
                label.ForeColor = Color.Black;
                label.Text = string.Format("{0:00}:{1:00}", min, sec);
                times = times - 1;



                switch (times)
                {
                    case 10:
                        playSound10();
                        break;

                    case 0:
                        playSoundEnd();
                        endTimes = true;
                        break;
                }

            }
            else if(times > 0 && restarts == true)
            {
                label.ForeColor = Color.Black;
                endTime = false;
                restarts = false;
                times = saveTimes;
                delayTimes = delaySaveTimes;
                label.Text = string.Format("{0:00}:{1:00}", min, sec);
                times = times - 1;
            }
            else if (endTimes == true && times == 0 && checkBox.Checked == false)
            {
                label.Text = string.Format("{0:00}:{1:00}", delayMin, delaySec);
                label.ForeColor = Color.Red;

                delayTimes = delayTimes - 1;

                if(delayTimes >=0 && restarts == true )
                {
                    restarts = false;
                    endTimes = false;
                    times = saveTimes;
                    delayTimes = delaySaveTimes;
                    
                    if (times > 0)
                    {
                        label.ForeColor = Color.Black;
                        label.Text = string.Format("{0:00}:{1:00}", min, sec);
                    }

                }

                if (delayTimes < 0 && restarts == false)
                {
             
                    timer.Stop();
                    endTimes = false;
                    label.ForeColor = Color.Black;
                    label.Text = string.Format("{0:00}:{1:00}", delayMin, delaySec);
                }

                   
            
            }
       

            else if (endTimes == true && times == 0 && checkBox.Checked == true )
            {
                label.Text = string.Format("{0:00}:{1:00}", delayMin, delaySec);
                label.ForeColor = Color.Red;

                delayTimes = delayTimes - 1;

                if (delayTimes < 0 && restarts == false)
                {
                    label.ForeColor = Color.Black;
                    endTimes = false;
                    times = saveTimes;
                    delayTimes = delaySaveTimes;


                }
                if(delayTime >= 0 && restarts == true)
                {
                    restarts = false;
                    endTimes = false;      
                    times = saveTimes;
                    delayTimes = delaySaveTimes;
                    if(times > 0)
                    {
                        label.ForeColor = Color.Black;
                        label.Text = string.Format("{0:00}:{1:00}", min, sec);
                    }
                    
                    

                }
            }


            else
            {
                timer.Stop();
                label.Text = "";
            }
        }
        private void startalr(TextBox minButton, TextBox secButton, TextBox deMinButton, TextBox deSecButton, 
            Label minLabe, Label secLabe, Label deMinLabe, Label deSecLabe, Label delayLabe, Label timeLabe, 
            CheckBox loopCheckBox, Button stopButton, Button startButton,Label timeSetLabels ,TextBox alarmNameSets,
            Label alarmNameSetLabels, Label alarmNameLabels)
        {

            minButton.Visible = false;
            secButton.Visible = false;

            deMinButton.Visible = false;
            deSecButton.Visible = false;

            minLabe.Visible = false;
            secLabe.Visible = false;

            deMinLabe.Visible = false;
            deSecLabe.Visible = false;

            delayLabe.Visible = false;


            timeLabe.Visible = true;
            loopCheckBox.Enabled = false;

            stopButton.Enabled = true;

            

            startButton.Enabled = false;

            timeSetLabels.Visible = false;

            alarmNameSets.Visible = false;
            alarmNameSetLabels.Visible = false;
            alarmNameLabels.Visible = true;
        }

        private void stopAlr(Timer timer,Label timeLabe, Button stopButton, TextBox minButton, TextBox secButton, TextBox deMinButton, TextBox deSecButton,
            Label minLabe, Label secLabe, Label deMinLabe, Label deSecLabe, Label delayLabe, CheckBox loopCheck, Button startAlar,
            ref int times, ref int delayTimes, Label timeSetLabels, TextBox alarmNameSets,
            Label alarmNameSetLabels, Label alarmNameLabels)
        {
            timer.Stop();

            times = 0;
            delayTimes = 0;

            timeLabe.Text = "";

            stopButton.Enabled = false;
            minButton.Visible = true;
            secButton.Visible = true;

            deMinButton.Visible = true;
            deSecButton.Visible = true;

            minLabe.Visible = true;
            secLabe.Visible = true;

            deMinLabe.Visible = true;
            deSecLabe.Visible = true;

            delayLabe.Visible = true;


            timeLabe.Visible = false;
            loopCheck.Enabled = true;

            startAlar.Enabled = true;

            timeSetLabels.Visible = true;

            alarmNameSets.Visible = true;
            alarmNameSetLabels.Visible = true;
            alarmNameLabels.Visible = false;
        }
        private void playSound10()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Application.StartupPath + @"\sound\10초전.wav");
            soundPlayer.Play();

        }
        private void playSoundEnd()
        {
            SoundPlayer soundPlayer1 = new SoundPlayer(Application.StartupPath + @"\sound\끝.wav");
            soundPlayer1.Play();
        }

        private int secTextBox_Changed(TextBox secTextBox, int secBefores)
        {
            if (secTextBox.Text != "")
            {
                secBefores = Int32.Parse(secTextBox.Text);
            
            }
            if (secTextBox.Text == "")
            {
                secBefores = 0;
            }
            return secBefores;

        }
        private int minTextBox_Changed(TextBox minTextBox, int minBefores)
        {
            if (minTextBox.Text != "")
            {
                minBefores = Int32.Parse(minTextBox.Text) * 60;
            }
            if (minTextBox.Text == "")
            {
                minBefores = 0;
            }
            return minBefores;

        }
        private int deSecTextBox_Changed(TextBox deSecTextBox, int delaySecBefores)
        {
            if (deSecTextBox.Text != "")
            {
                delaySecBefores = Int32.Parse(deSecTextBox.Text);
            }
            if (deSecTextBox.Text == "")
            {
                delaySecBefores = 0;
            }
            return delaySecBefores;
        }

        private int deMinTextBox_Changed(TextBox deMinTextBox, int delayMinBefores)
        {
            if (deMinTextBox.Text != "")
            {
                delayMinBefores = Int32.Parse(deMinTextBox.Text) * 60;
            }
            if (deMinTextBox.Text == "")
            {
                delayMinBefores = 0;
            }
            return delayMinBefores;

        }

        private string alarmNameTextBox_Changed(TextBox alarmTextBox, string alarmNames)
        {
            if(alarmTextBox.Text != "")
            {
                alarmNames = alarmTextBox.Text;
            }
            if (alarmTextBox.Text == "")
            {
                alarmNames = "알람이름설정안함";
            }

            return alarmNames;
        } 
        
        
        private void deMinPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }



        }

        private void deSecPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }

        }

        private void minPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }

        }

        private void secBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }

        }
        private void minBtn2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void secBtn2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void deMinBtn2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void desecBtn2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void minBtn3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void secBtn3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void deMinBtn3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void desecBtn3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void alarmName_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if ( e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
           */
        }

        private void alarmName2_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
            */
        }

        private void alarmName3_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
            */
        }

        private void alarmName_TextChanged(object sender, EventArgs e)
        {
           alarmNameVar =  alarmNameTextBox_Changed(alarmName, alarmNameVar);
        }

        private void alarmName2_TextChanged(object sender, EventArgs e)
        {
            alarmNameVar2 = alarmNameTextBox_Changed(alarmName2, alarmNameVar2);
        }
        private void alarmName3_TextChanged(object sender, EventArgs e)
        {
            alarmNameVar3 = alarmNameTextBox_Changed(alarmName3, alarmNameVar3);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void 미니모드ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void miniMode(Label alarmTimeSetLabels)
        {
            //alarmTimeSetLabels.Location = 
        }

        private void Alarm_change(int Times)
        {
            Form2 Alarm_changeForm = new Form2();

            Alarm_changeForm.ShowDialog();

            Alarm_changeForm.changeTime = Times;

        }

        private void Alarm_Stop(ref int pauses,Button changeBtns,Timer timer)
        {
            if(changeBtns.Text == "다시시작")
            {
                pauses = 1;
                timer.Start();
                changeBtns.Text = "일시정지";
            }
        }
        // 알람 다시 시작
        private void AlarmStopLogic(ref int pauses, Button changeBtns,Timer timer)
        {
            if (pauses == 0)
            {
                timer.Stop();
                changeBtns.Text = "다시시작";

            }
            else if (changeBtns.Text == "일시정지")
            {
                pauses = 0;
            }
        }
        //알람 일시정지
        private void Alarm_changeBtn_Click(object sender, EventArgs e)
        {
            //Alarm_change(saveTime);

            Alarm_Restart(saveTime, delaySaveTime, ref time, ref delayTime,ref reStart);
            
        }
       
        private void Alarm_changeBtn_Click3(object sender, EventArgs e)
        {
            Alarm_Restart(saveTime3, delaySaveTime3, ref time3, ref delayTime3, ref reStart3);

        }

        private void Alarm_changeBtn2_Click(object sender, EventArgs e)
        {
            Alarm_Restart(saveTime2, delaySaveTime2, ref time2, ref delayTime2, ref reStart2);

        }

        private void Alarm_Restart(int saveTimes, int saveDelayTimes, ref int times, ref int delayTimes, ref bool restarts)
        {
            times = saveTimes;
            delayTimes = saveDelayTimes;
            restarts = true;

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F12)
            {
                Alarm_Restart(saveTime3, delaySaveTime3, ref time3, ref delayTime3, ref reStart3);

            }
            else if (keyData == Keys.F11)
            {
                Alarm_Restart(saveTime2, delaySaveTime2, ref time2, ref delayTime2, ref reStart2);

            }
            else if (keyData == Keys.F10)
            {
                Alarm_Restart(saveTime, delaySaveTime, ref time, ref delayTime, ref reStart);

            }
            else if (keyData == (Keys.Control | Keys.F1))
            {
                return true;
            }
            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}
