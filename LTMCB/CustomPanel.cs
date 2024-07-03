﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace LTMCB
{
    public class CustomPanel : Panel
    {
        public PictureBox pictureBox;
        public PictureBox pictureBoxButton;
        public PictureBox downloadButon;
        public Label label1;
        public Label label2;
        public Label label3;
        private string audiolink;
        private string img;
        private string namesong;
        private string namesinger;
        private string time;
        public CustomPanel()
        {
            InitializeComponents("1", "2", "3", null, "3");
        }

        public CustomPanel(string txt, string txt1, string t, string img = null, string a = null)
        {
            this.img = img;
            this.namesong = txt;
            this.namesinger = txt1;
            this.time = t;
            InitializeComponents(txt, txt1, t, img, a);
        }


        private void InitializeComponents(string t, string txt, string time, string img, string audio)
        {
            this.audiolink = audio;
            if (img != null)
            {
                // Convert img: base64 -> byte[] -> ms -> bitmap
                byte[] b = Convert.FromBase64String(img);

                MemoryStream ms = new MemoryStream();
                ms.Write(b, 0, Convert.ToInt32(b.Length));

                Bitmap bm = new Bitmap(ms, false);
                ms.Dispose();


                // Initialize PictureBox
                pictureBox = new PictureBox
                {
                    Image = bm,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(22, 6),
                    Size = new Size(100, 100)
                };
            }


            // Initialize PictureBoxButton as a Button
            downloadButon = new PictureBox
            {
                Image = Properties.Resources.icons8_download_64,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(230, 29),
                Size = new Size(50, 50),
                Cursor = Cursors.Hand // Change cursor to hand to indicate clickable
            };

            pictureBoxButton = new PictureBox
            {
                Image = Properties.Resources.icons8_circled_play_50,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(164, 32),
                Size = new Size(50, 50),
                Cursor = Cursors.Hand // Change cursor to hand to indicate clickable
            };

            // Initialize Labels
            label1 = new Label
            {
                Text = t,
                Location = new Point(300, 38),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                MaximumSize = new Size(200, 0), // Set maximum width
                AutoEllipsis = true, // Enable ellipsis if text exceeds maximum width
                ForeColor = Color.Silver,
            };

            label2 = new Label
            {
                Text = txt,
                Location = new Point(518, 43), // Maintain your original position
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                AutoSize = true,
                MaximumSize = new Size(150, 0), // Set maximum width
                AutoEllipsis = true, // Enable ellipsis if text exceeds maximum width
                ForeColor = Color.White
            };

            label3 = new Label
            {
                Text = time,
                Location = new Point(685, 43),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.White
            };

            // Add controls to the panel
            Controls.Add(pictureBox);
            Controls.Add(pictureBoxButton);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(downloadButon);

            // Set panel properties
            Size = new Size(800, 100);
        }
        public string AudioLink => audiolink;
        public string IMG => img;
        public string NAMESONG => namesong;
        public string NAMESINGER => namesinger;
        public string TIME => time;
    }
}
