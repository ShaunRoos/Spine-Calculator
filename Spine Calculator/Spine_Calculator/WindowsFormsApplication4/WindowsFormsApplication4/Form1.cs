using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class Spine_Calculator : Form
    {
        public Spine_Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void bindingComboBox_TextChanged(object sender, EventArgs e)
        {
            bool saddle = true;
            bool perfect = true;
            bool sew_1 = true;
            bool sew_2 = true;
            bool sew_3 = true;
            bool sew_4 = true;

            saddle = (bindingComboBox.Text == "Saddle Stich");
            perfect = (bindingComboBox.Text == "Perfect Bind");
            sew_1 = (bindingComboBox.Text == "Sew Soft Cover");
            sew_2 = (bindingComboBox.Text == "Sew Case Bound 1200");
            sew_3 = (bindingComboBox.Text == "Sew Case Bound 1800");
            sew_4 = (bindingComboBox.Text == "Sew Case Bound 2300");

            if (saddle)
            {
                glueTextBox.Text = "0";
                button1.Enabled = true;
                button2.Enabled = false;
            } 
            else if (perfect)
            {
                glueTextBox.Text = "1";
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else if (sew_1)
            {
                glueTextBox.Text = "2,5";
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else if (sew_2)
            {
                glueTextBox.Text = "3,8";
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else if (sew_3)
            {
                glueTextBox.Text = "5";
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else if (sew_4)
            {
                glueTextBox.Text = "6";
                button1.Enabled = false;
                button2.Enabled = true;
            }
               
        }
       

        private void gsmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gsmComboBox_TextChanged(object sender, EventArgs e)
        {
            bool A = true;
            bool B = true;
            bool C = true;
            bool D = true;
            bool E = true;
            bool F = true;
            bool G = true;
            bool H = true;
            bool AA = true;
            bool BB = true;
            bool CC = true;
            bool DD = true;
            bool EE = true;
            bool FF = true;
            bool GG = true;
            bool HH = true;
            bool II = true;
            bool JJ = true;
            bool KK = true;
            bool LL = true;
            bool MM = true;
            bool NN = true;
            bool OO = true;
            bool PP = true;
            bool QQ = true;
            bool AAA = true;
            bool BBB = true;
            bool CCC = true;
            bool DDD = true;
            bool EEE = true;
            bool FFF = true;
            bool GGG = true;
            bool HHH = true;
            bool III = true;
            bool JJJ = true;
            bool KKK = true;
            bool LLL = true;
            bool MMM = true;
            bool NNN = true;
            bool OOO = true;
            bool PPP = true;
            bool QQQ = true;
            

            A = (coatingBox.Text == "Uncoated" && gsmBox.Text == "060");
            B = (coatingBox.Text == "Uncoated" && gsmBox.Text == "070");
            C = (coatingBox.Text == "Uncoated" && gsmBox.Text == "080");
            D = (coatingBox.Text == "Uncoated" && gsmBox.Text == "090");
            E = (coatingBox.Text == "Uncoated" && gsmBox.Text == "100");
            F = (coatingBox.Text == "Uncoated" && gsmBox.Text == "120");
            G = (coatingBox.Text == "Uncoated" && gsmBox.Text == "140");
            H = (coatingBox.Text == "Uncoated" && gsmBox.Text == "180");
            AA = (coatingBox.Text == "Gloss" && gsmBox.Text == "080");
            BB = (coatingBox.Text == "Gloss" && gsmBox.Text == "085");
            CC = (coatingBox.Text == "Gloss" && gsmBox.Text == "090");
            DD = (coatingBox.Text == "Gloss" && gsmBox.Text == "095");
            EE = (coatingBox.Text == "Gloss" && gsmBox.Text == "100");
            FF = (coatingBox.Text == "Gloss" && gsmBox.Text == "105");
            GG = (coatingBox.Text == "Gloss" && gsmBox.Text == "113");
            HH = (coatingBox.Text == "Gloss" && gsmBox.Text == "115");
            II = (coatingBox.Text == "Gloss" && gsmBox.Text == "128");
            JJ = (coatingBox.Text == "Gloss" && gsmBox.Text == "135");
            KK = (coatingBox.Text == "Gloss" && gsmBox.Text == "140");
            LL = (coatingBox.Text == "Gloss" && gsmBox.Text == "148");
            MM = (coatingBox.Text == "Gloss" && gsmBox.Text == "150");
            NN = (coatingBox.Text == "Gloss" && gsmBox.Text == "157");
            OO = (coatingBox.Text == "Gloss" && gsmBox.Text == "170");
            PP = (coatingBox.Text == "Gloss" && gsmBox.Text == "180");
            QQ = (coatingBox.Text == "Gloss" && gsmBox.Text == "200");
            AAA = (coatingBox.Text == "Matt" && gsmBox.Text == "080");
            BBB = (coatingBox.Text == "Matt" && gsmBox.Text == "085");
            CCC = (coatingBox.Text == "Matt" && gsmBox.Text == "090");
            DDD = (coatingBox.Text == "Matt" && gsmBox.Text == "095");
            EEE = (coatingBox.Text == "Matt" && gsmBox.Text == "100");
            FFF = (coatingBox.Text == "Matt" && gsmBox.Text == "105");
            GGG = (coatingBox.Text == "Matt" && gsmBox.Text == "113");
            HHH = (coatingBox.Text == "Matt" && gsmBox.Text == "115");
            III = (coatingBox.Text == "Matt" && gsmBox.Text == "128");
            JJJ = (coatingBox.Text == "Matt" && gsmBox.Text == "135");
            KKK = (coatingBox.Text == "Matt" && gsmBox.Text == "140");
            LLL = (coatingBox.Text == "Matt" && gsmBox.Text == "148");
            MMM = (coatingBox.Text == "Matt" && gsmBox.Text == "150");
            NNN = (coatingBox.Text == "Matt" && gsmBox.Text == "157");
            OOO = (coatingBox.Text == "Matt" && gsmBox.Text == "170");
            PPP = (coatingBox.Text == "Matt" && gsmBox.Text == "180");
            QQQ = (coatingBox.Text == "Matt" && gsmBox.Text == "200");

            

            if (A)
            {
                calliperTextBox.Text = "0,0800";
            }
            else if (B)
            {
                calliperTextBox.Text = "0,0900";
            }
            else if (C)
            {
                calliperTextBox.Text = "0,1000";
            }
            else if (D)
            {
                calliperTextBox.Text = "0,1100";
            }
            else if (E)
            {
                calliperTextBox.Text = "0,1200";
            }
            else if (F)
            {
                calliperTextBox.Text = "0,1350";
            }
            else if (G)
            {
                calliperTextBox.Text = "0,1600";
            }
            else if (H)
            {
                calliperTextBox.Text = "0,1900";
            }
            else if (AA)
            {
                calliperTextBox.Text = "0,0650";
            }
            else if (BB)
            {
                calliperTextBox.Text = "0,0670";
            }
            else if (CC)
            {
                calliperTextBox.Text = "0,0720";
            }
            else if (DD)
            {
                calliperTextBox.Text = "0,0780";
            }
            else if (EE)
            {
                calliperTextBox.Text = "0,0780";
            }
            else if (FF)
            {
                calliperTextBox.Text = "0,0850";
            }
            else if (GG)
            {
                calliperTextBox.Text = "0,0930";
            }
            else if (HH)
            {
                calliperTextBox.Text = "0,0930";
            }
            else if (II)
            {
                calliperTextBox.Text = "0,1050";
            }
            else if (JJ)
            {
                calliperTextBox.Text = "0,1130";
            }
            else if (KK)
            {
                calliperTextBox.Text = "0,1150";
            }
            else if (LL)
            {
                calliperTextBox.Text = "0,1150";
            }
            else if (MM)
            {
                calliperTextBox.Text = "0,1180";
            }
            else if (NN)
            {
                calliperTextBox.Text = "0,1350";
            }
            else if (OO)
            {
                calliperTextBox.Text = "0,1400";
            }
            else if (PP)
            {
                calliperTextBox.Text = "0.1440";
            }
            else if (QQ)
            {
                calliperTextBox.Text = "0,1700";
            }
            else if (AAA)
            {
                calliperTextBox.Text = "0,0730";
            }
            else if (BBB)
            {
                calliperTextBox.Text = "0,0730";
            }
            else if (CCC)
            {
                calliperTextBox.Text = "0,0780";
            }
            else if (DDD)
            {
                calliperTextBox.Text = "0,0890";
            }
            else if (EEE)
            {
                calliperTextBox.Text = "0,0900";
            }
            else if (FFF)
            {
                calliperTextBox.Text = "0,0900";
            }
            else if (GGG)
            {
                calliperTextBox.Text = "0,0990";
            }
            else if (HHH)
            {
                calliperTextBox.Text = "0,0990";
            }
            else if (III)
            {
                calliperTextBox.Text = "0,1200";
            }
            else if (JJJ)
            {
                calliperTextBox.Text = "0,1250";
            }
            else if (KKK)
            {
                calliperTextBox.Text = "0,1320";
            }
            else if (LLL)
            {
                calliperTextBox.Text = "0,1320";
            }
            else if (MMM)
            {
                calliperTextBox.Text = "0,1320";
            }
            else if (NNN)
            {
                calliperTextBox.Text = "0,1600";
            }
            else if (OOO)
            {
                calliperTextBox.Text = "0,1700";
            }
            else if (PPP)
            {
                calliperTextBox.Text = "0,1750";
            }
            else if (QQQ)
            {
                calliperTextBox.Text = "0,1900";

            }
            else
            {
                calliperTextBox.Text = "ERROR";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double pages, calliper, answer;

            pages = double.Parse(pageNumberTextBox.Text);
            calliper = double.Parse(calliperTextBox.Text);

            answer = pages * 0.25 * calliper;
            answerLabel.Text = "Shingling = " + answer.ToString() + " mm";
        }

        private void bindingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float pages, calliper, glue, answer;

            pages = float.Parse(pageNumberTextBox.Text);
            calliper = float.Parse(calliperTextBox.Text);
            glue = float.Parse(glueTextBox.Text);
            answer = pages / 2 * calliper + glue;
            answerLabel.Text = "Spine = " + answer.ToString() + " mm";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paperComboBox.Text = "Bond White";
            coatingBox.Text = "Uncoated";
            calliperTextBox.Text = "1";
            bindingComboBox.Text = "Perfect Bind";
            pageNumberTextBox.Text = "1";
            glueTextBox.Text = "1";
            gsmBox.Text = "0";
            calliperTextBox.Text = "0";
            answerLabel.Text = "Answer";
        }

        private void answerLabel_Click(object sender, EventArgs e)
        {

        }

        private void pageNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calliperTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void glueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void coatingBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void paperComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }