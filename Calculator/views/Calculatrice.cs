﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_grafiques.views {
    public partial class Calculatrice : Form {
        private String optext;

        public Calculatrice() {
            InitializeComponent();
            optext = "";
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox_TextChanged(object sender, EventArgs e) {
        }

        private void button12_Click(object sender, EventArgs e) {
            bnt_click(btn6);       
        }

        private void bnt_click(Button btn) {
            textBox.Text += btn.Text;
            optext += btn.Text;
        }

        private void plusbtn_Click(object sender, EventArgs e) {

        }

        private void btn1_Click(object sender, EventArgs e){
            bnt_click(btn1);
        }

        private void btn2_Click(object sender, EventArgs e) {
            bnt_click(btn2);       
        }

        private void btn3_Click(object sender, EventArgs e) {
            bnt_click(btn3);       
        }

        private void btn4_Click(object sender, EventArgs e) {
            bnt_click(btn4);       
        }

        private void btn5_Click(object sender, EventArgs e) {
            bnt_click(btn5);       
        }

        private void btn7_Click(object sender, EventArgs e) {
            bnt_click(btn7);       
        }

        private void btn8_Click(object sender, EventArgs e) {
            bnt_click(btn8);       
        }

        private void btn9_Click(object sender, EventArgs e) {
            bnt_click(btn9);
        }

        private void btn0_Click(object sender, EventArgs e) {
            bnt_click(btn0);       
        }


    }
}