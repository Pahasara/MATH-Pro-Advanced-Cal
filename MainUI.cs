/*
 *
 * Copyright(c) 2019, 2020, M.P.Dewnith Fernando and/or its affiliates.All rights reserved.
 * M.P.Dewnith Fernando PROPRIETARY/CONFIDENTIAL.Use is subject to license terms.
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using DvNET.MATH.Core;

namespace DvNET_Math_Pro
{
    public partial class MainUI : Form
    {

        private bool drag = false; private Point startPoint = new Point(0, 0);

        DvNET.MATH.Core.Main Main = new DvNET.MATH.Core.Main();
        DvNET.MATH.Core.Area Area = new DvNET.MATH.Core.Area();
        DvNET.MATH.Core.Volume Vol = new DvNET.MATH.Core.Volume();
        DvNET.MATH.Core.Scientific Sci = new DvNET.MATH.Core.Scientific();

        public MainUI() { InitializeComponent(); }

        public string operation = ""; Double num1, num2, num3, num4, result;



        /*                              PUBLIC EVENTS                            */

        private void MainUI_Load(object sender, EventArgs e)
        {
            Title.Text = "             MATH PRO  " + Main.GetVersion() + "        ";
            Copyright.Text = "Copyright © " + Main.GetYear() + " Dewnith Fernando. All rights reserved.";
            VersionLabel.Text = "MATH PRO " + Main.GetVersion(); ;
            BuildLabel.Text = "Build " + Main.GetBuild();
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location; this.drag = true;
        }
        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag) { Point p1 = new Point(e.X, e.Y); Point p2 = this.PointToScreen(p1); Point p3 = new Point(p2.X - this.startPoint.X, p2.Y - this.startPoint.Y); this.Location = p3; }
        }
        private void Title_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void LOGO_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.github.com/pahasara");
        }
        private void CompanyLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.github.com/pahasara");
        }
        private void InputTextField1_Enter(object sender, EventArgs e)
        {
            TextFieldBack1.BackColor = Color.FromArgb(12, 108, 190);
        }

        private void InputTextField1_Leave(object sender, EventArgs e)
        {
            TextFieldBack1.BackColor = Color.FromArgb(24, 24, 36);
        }

        private void InputTextField2_Enter(object sender, EventArgs e)
        {
            TextFieldBack2.BackColor = Color.FromArgb(12, 108, 190);
        }

        private void InputTextField3_Enter(object sender, EventArgs e)
        {
            TextFieldBack3.BackColor = Color.FromArgb(12, 108, 190);
        }

        private void InputTextField4_Enter(object sender, EventArgs e)
        {
            TextFieldBack4.BackColor = Color.FromArgb(12, 108, 190);
        }

        private void InputTextField2_Leave(object sender, EventArgs e)
        {
            TextFieldBack2.BackColor = Color.FromArgb(24,24,36);
        }

        private void InputTextField3_Leave(object sender, EventArgs e)
        {
            TextFieldBack3.BackColor = Color.FromArgb(24, 24, 36);
        }

        private void InputTextField4_Leave(object sender, EventArgs e)
        {
            TextFieldBack4.BackColor = Color.FromArgb(24, 24, 36);
        }
        private void InputTextField1_Click(object sender, EventArgs e)
        {
            InputTextField1.Clear(); num1 = 0;
        }
        private void InputTextField2_Click(object sender, EventArgs e)
        {
            InputTextField2.Clear(); num2 = 0;
        }
        private void InputTextField3_Click(object sender, EventArgs e)
        {
            InputTextField3.Clear(); num3 = 0;
        }
        private void InputTextField4_Click(object sender, EventArgs e)
        {
            InputTextField4.Clear(); num4 = 0;
        }
        private void InputTextField1_KeyUp(object sender, KeyEventArgs e)
        {
            try { num1 = Double.Parse(InputTextField1.Text); } catch (FormatException) { InputTextField1.Text = ""; num1 = 0; Printerr(Main.InputTextError()); }
        }
        private void InputTextField2_KeyUp(object sender, KeyEventArgs e)
        {
            try { num2 = Double.Parse(InputTextField2.Text); } catch (FormatException) { InputTextField2.Text = ""; num2 = 0; Printerr(Main.InputTextError()); }
        }
        private void InputTextField3_KeyUp(object sender, KeyEventArgs e)
        {
            try { num3 = Double.Parse(InputTextField3.Text); } catch (FormatException) { InputTextField3.Text = ""; num3 = 0;  Printerr(Main.InputTextError()); }
        }
        private void InputTextField4_KeyUp(object sender, KeyEventArgs e)
        {
            try { num4 = Double.Parse(InputTextField4.Text); } catch (FormatException) { InputTextField4.Text = ""; num4 = 0; Printerr(Main.InputTextError()); }
        }
        private void OutputTextClearBtn_Click(object sender, EventArgs e)
        {
            OutputTextField.Clear();
        }
        private void OutputTextCopyBtn_Click(object sender, EventArgs e)
        {
            Memory.Text = result.ToString();
        }
        private void AboutBtn_Click(object sender, EventArgs e) { About about = new About(); about.Show(); }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// ****************************************        & MAINUI.* AREA.# EVENTS           ******************************************* ///
        private void Asquare_Click(object sender, EventArgs e)
        {
            operation = "Asquare";
            InputTextLabel1.Text = "Height :";
            InputTextLabel2.Text = "------ :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }
        private void Arectangle_Click(object sender, EventArgs e)
        {
            operation = "Arectangle";
            InputTextLabel1.Text = "Length :";
            InputTextLabel2.Text = "Width  :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void Atriangle_Click(object sender, EventArgs e)
        {
            operation = "Atriangle";
            InputTextLabel1.Text = "Height :";
            InputTextLabel2.Text = "Aid    :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void Atrapezoid_Click(object sender, EventArgs e)
        {
            operation = "Atrapezoid";
            InputTextLabel1.Text = "Length 1 :";
            InputTextLabel2.Text = "Length 2 :";
            InputTextLabel3.Text = "Height   :";
            InputTextLabel4.Text = "-------- :";
            Submit();
        }

        private void Acircle_Click(object sender, EventArgs e)
        {
            operation = "Acircle";
            InputTextLabel1.Text = "Radius :";
            InputTextLabel2.Text = "------ :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void Aparellelogram_Click(object sender, EventArgs e)
        {
            operation = "Arectangle";
            InputTextLabel1.Text = "Length :";
            InputTextLabel2.Text = "Width  :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }
        private void AcircularCone_Click(object sender, EventArgs e)
        {
            operation = "AcircularCone";
            InputTextLabel1.Text = "Radius :";
            InputTextLabel2.Text = "Height :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void Acylinder_Click(object sender, EventArgs e)
        {
            operation = "Acylinder";
            InputTextLabel1.Text = "Radius :";
            InputTextLabel2.Text = "Height :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void ARectangleBox_Click(object sender, EventArgs e)
        {
            operation = "ArectangleBox";
            InputTextLabel1.Text = "Length :";
            InputTextLabel2.Text = "Width  :";
            InputTextLabel3.Text = "Height :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void Acube_Click(object sender, EventArgs e)
        {
            operation = "Acube";
            InputTextLabel1.Text = "Length :";
            InputTextLabel2.Text = "------ :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void Vcube_Click(object sender, EventArgs e)
        {
            operation = "Vcube";
            InputTextLabel1.Text = "Height :";
            InputTextLabel2.Text = "------ :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void VrectBoc_Click(object sender, EventArgs e)
        {
            operation = "VrectangleBox";
            InputTextLabel1.Text = "Length :";
            InputTextLabel2.Text = "Width  :";
            InputTextLabel3.Text = "Height :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void Vsphere_Click(object sender, EventArgs e)
        {
            operation = "Vsphere";
            InputTextLabel1.Text = "Radius :";
            InputTextLabel2.Text = "------ :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void VcircularCone_Click(object sender, EventArgs e)
        {
            operation = "VcircularCone";
            InputTextLabel1.Text = "Radius :";
            InputTextLabel2.Text = "Height :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void Vcylinder_Click(object sender, EventArgs e)
        {
            operation = "Vcylinder";
            InputTextLabel1.Text = "Radius :";
            InputTextLabel2.Text = "Height :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void Vpyramid_Click(object sender, EventArgs e)
        {
            operation = "Vpyramid";
            InputTextLabel1.Text = "Length :";
            InputTextLabel2.Text = "Width  :";
            InputTextLabel3.Text = "Height :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            OutputTextFieldBack.BackColor = Color.FromArgb(62, 209, 24);
            try
            {
                OutputTextField.Text = "";

                if (operation == "Asquare")
                {
                    result = Area.Square(num1);
                    Print(">>> Area of the Square : " + result.ToString());
                }
                else if (operation == "Arectangle")
                {
                    result = Area.Rectangle(num1, num2);
                    Print(">>> Area of the Rectangle : " + result.ToString());
                }
                else if (operation == "Acircle")
                {
                    result = Area.Circle(num1);
                    Print(">>> Area of the Circle : " + result.ToString());
                }
                else if (operation == "Atriangle")
                {
                    result = Area.Triangle(num1, num2);
                    Print(">>> Area of the Triangle : " + result.ToString());
                }
                else if (operation == "Atrapezoid")
                {
                    result = Area.Trapezoid(num1, num2, num3);
                    Print(">>> Area of the trapezoid : " + result.ToString());
                }
                else if (operation == "Aellipse")
                {
                    result = Area.Ellipse(num1, num2);
                    Print(">>> Area of the Ellipse : " + result.ToString());
                }
                else if (operation == "ArectangleBox")
                {
                    result = Area.RectangleCube(num1, num2, num3);
                    Print(">>> Area of the Rectangle Box : " + result.ToString());
                }
                else if (operation == "AcircularCone")
                {
                    result = Area.CircularCone(num1, num2);
                    Print(">>> Area of the Circular Cone : " + result.ToString());
                }
                else if (operation == "Acylinder")
                {
                    result = Area.Cylinder(num1, num2);
                    Print(">>> Area of the Cylinder : " + result.ToString());
                }
                else if (operation == "Acube")
                {
                    result = Area.Cube(num1);
                    Print(">>> Area of the Cube : " + result.ToString());
                }
                else if (operation == "Vcube")
                {
                    result = Vol.Cube(num1);
                    Print(">>> Volume of the Cube : " + result.ToString());
                }
                else if (operation == "VrectangleBox")
                {
                    result = Vol.RectangleCube(num1, num2, num3);
                    Print(">>> Volume of the Rectangle Cube : " + result.ToString());
                }
                else if (operation == "Vcylinder")
                {
                    result = Vol.Cylinder(num1, num2);
                    Print(">>> Volume of the Cylinder : " + result.ToString());
                }
                else if (operation == "VcircularCone")
                {
                    result = Vol.CircularCone(num1, num2);
                    Print(">>> Volume of the Circular Cone : " + result.ToString());
                }
                else if (operation == "Vsphere")
                {
                    result = Vol.Sphere(num1);
                    Print(">>> Volume of the Sphere : " + result.ToString());
                }
                else if (operation == "Vpyramid")
                {
                    result = Vol.Pyramid(num1,num2,num3);
                    Print(">>> Volume of the Pyramid : " + result.ToString());
                }
                else if (operation == "Sspeed")
                {
                    result = Sci.Speed(num1, num2);
                    Print(">>> Speed  : " + result.ToString());
                }
                else if (operation == "Svelocity")
                {
                    result = Sci.Velocity(num1, num2);
                    Print(">>> Velocity : " + result.ToString());
                }
                else if (operation == "Sacceleration")
                {
                    result = Sci.Acceleration(num1, num2,num3);
                    Print(">>> Acceleration : " + result.ToString());
                }
                else if (operation == "Senergy")
                {
                    result = Sci.Energy(num1,num2);
                    Print(">>> Energy : " + result.ToString());
                }
                else if (operation == "Smass")
                {
                    result = Sci.Mass(num1, num2);
                    Print(">>> Mass : " + result.ToString());
                }
                else if (operation == "Spower")
                {
                    result = Sci.Power(num1, num2);
                    Print(">>> Power : " + result.ToString());
                }
                else if (operation == "Sdistance")
                {
                    result = Sci.Distance(num1,num2);
                    Print(">>> Distance : " + result.ToString());
                }
                else if (operation == "Sforce")
                {
                    result = Sci.Force(num1,num2);
                    Print(">>> Force : " + result.ToString());
                }
                else if (operation == "Rforce")
                {
                    result = Sci.RForce(num1, num2,num3);
                    Print(">>> Resultant Force : " + result.ToString());
                }
                else if (operation == "GPenergy")
                {
                    result = Sci.GravPotentialEnergy(num1, num2, num3);
                    Print(">>> Gravitational Potential Energy : " + result.ToString());
                }
                else if (operation == "LKenergy")
                {
                    result = Sci.LinearKineticEnergy(num1, num2);
                    Print(">>> Linear Kinetic Energy : " + result.ToString());
                }
                else if (operation == "AngV")
                {
                    result = Sci.AngularV(num1);
                    Print(">>> Angular Velocity : " + result.ToString());
                }
                else if (operation == "Sfreq")
                {
                    result = Sci.Frequency(num1, num2);
                    Print(">>> Frequency : " + result.ToString());
                }
                else if (operation == "Pythagorean")
                {
                    result = Area.Pythagorean(num1, num2);
                    Print(">>> Hypotenuse : " + result.ToString());
                }
                xSubmit();
            }
            catch (Exception) { Print(Main.InputSubmitError()); }
        }


        private void Sspeed_Click(object sender, EventArgs e)
        {
            operation = "Sspeed";
            InputTextLabel1.Text = "Distance :";
            InputTextLabel2.Text = "Time     :";
            InputTextLabel3.Text = "-------- :";
            InputTextLabel4.Text = "-------- :";
            Submit();
        }

        private void Svelocity_Click(object sender, EventArgs e)
        {
            operation = "Svelocity";
            InputTextLabel1.Text = "Extended :";
            InputTextLabel2.Text = "Time     :";
            InputTextLabel3.Text = "-------- :";
            InputTextLabel4.Text = "-------- :";
            Submit();
        }

        private void Sacceleration_Click(object sender, EventArgs e)
        {
            operation = "Sacceleration";
            InputTextLabel1.Text = "Start V. :";
            InputTextLabel2.Text = "End V.   :";
            InputTextLabel3.Text = "Time     :";
            InputTextLabel4.Text = "-------- :";
            Submit();
        }

        private void Senergy_Click(object sender, EventArgs e)
        {
            operation = "Senergy";
            InputTextLabel1.Text = "Force    :";
            InputTextLabel2.Text = "Distance :";
            InputTextLabel3.Text = "-------- :";
            InputTextLabel4.Text = "-------- :";
            Submit();
        }

        private void Sdistance_Click(object sender, EventArgs e)
        {
            operation = "Sdistance";
            InputTextLabel1.Text = "Speed  :";
            InputTextLabel2.Text = "Time   :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void Vpower_Click(object sender, EventArgs e)
        {
            operation = "Spower";
            InputTextLabel1.Text = "Energy :";
            InputTextLabel2.Text = "Time   :";
            InputTextLabel3.Text = "------ :";
            InputTextLabel4.Text = "------ :";
            Submit();
        }

        private void Smass_Click(object sender, EventArgs e)
        {
            operation = "Smass";
            InputTextLabel1.Text = "Force   :";
            InputTextLabel2.Text = "Gravity :";
            InputTextField2.Text = "9.8"; num2 = 9.8; //SET GRAVITATION VALUE
            InputTextLabel3.Text = "------- :";
            InputTextLabel4.Text = "------- :";
            Submit();
        }

        private void Sforce_Click(object sender, EventArgs e)
        {
            operation = "Sforce";
            InputTextLabel1.Text = "Mass    :";
            InputTextLabel2.Text = "Gravity :";
            InputTextField2.Text = "9.8"; num2 = 9.8; //SET GRAVITATION VALUE
            InputTextLabel3.Text = "------- :";
            InputTextLabel4.Text = "------- :";
            Submit();
        }

        private void RForce_Click(object sender, EventArgs e)
        {
            operation = "Rforce";
            InputTextLabel1.Text = "Force 1 :";
            InputTextLabel2.Text = "Force 2 :";
            InputTextLabel3.Text = "Theeta  :";
            InputTextLabel4.Text = "------- :";
            Submit();
        }

        private void LKEnergy_Click(object sender, EventArgs e)
        {
            operation = "LKenergy";
            InputTextLabel1.Text = "Mass     :";
            InputTextLabel2.Text = "Velocity :";
            InputTextLabel3.Text = "-------- :";
            InputTextLabel4.Text = "-------- :";            
            Submit();
        }

        private void GPEnergy_Click(object sender, EventArgs e)
        {
            operation = "GPenergy";
            InputTextLabel1.Text = "Mass    :";
            InputTextLabel2.Text = "Gravity :"; InputTextField2.Text = "9.8"; num2 = 9.8; //SET GRAVITATION VALUE
            InputTextLabel3.Text = "Height  :";
            InputTextLabel4.Text = "------- :";
            Submit();
        }

        private void SangularV_Click(object sender, EventArgs e)
        {
            operation = "AngV";
            InputTextLabel1.Text = "Frequency :";
            InputTextLabel2.Text = "--------- :";
            InputTextLabel3.Text = "--------- :";
            InputTextLabel4.Text = "--------- :";
            Submit();
        }

        private void Sfrequency_Click(object sender, EventArgs e)
        {
            operation = "Sfreq";
            InputTextLabel1.Text = "Rounds (n) :";
            InputTextLabel2.Text = "Time       :";
            InputTextLabel3.Text = "---------- :";
            InputTextLabel4.Text = "---------- :";
            Submit();
        }

        private void Spythgr_Click(object sender, EventArgs e)
        {
            operation = "Pythagorean";
            InputTextLabel1.Text = "Height     :";
            InputTextLabel2.Text = "Aid        :";
            InputTextLabel3.Text = "---------- :";
            InputTextLabel4.Text = "---------- :";
            Submit();
        }

        private void OutputTextField_TextChanged(object sender, EventArgs e)
        {

        }

        /***************************                         *  PUBLIC FUNCTIONS  *                            *************************/
        public void Print(string Text) { OutputTextFieldBack.BackColor = Color.FromArgb(12, 100, 198); OutputTextField.ForeColor = Color.FromArgb(62, 209, 24); OutputTextField.Text += Text; OutputTextFieldBack.BackColor = Color.FromArgb(20,24,50); }
        public void Printerr(string Text) { OutputTextField.ForeColor = Color.FromArgb(241, 0, 0); OutputTextField.Text = Text; }
        public void Submit() { SubmitBtn.Enabled = true; OutputTextCopyBtn.Enabled = false; OutputTextClearBtn.Enabled = false; }
        public void xSubmit() { SubmitBtn.Enabled = false; OutputTextCopyBtn.Enabled = true; OutputTextClearBtn.Enabled = true; }
        /*******************************************************************************************************************************/
    }
}