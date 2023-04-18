namespace SağlıkOtomasyonu
{
    partial class kullanici_girisi
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
            this.kullanicitxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.sifretxt = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // kullanicitxt
            // 
            this.kullanicitxt.AllowPromptAsInput = true;
            this.kullanicitxt.AnimateReadOnly = false;
            this.kullanicitxt.AsciiOnly = false;
            this.kullanicitxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kullanicitxt.BeepOnError = false;
            this.kullanicitxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.kullanicitxt.Depth = 0;
            this.kullanicitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.kullanicitxt.HidePromptOnLeave = false;
            this.kullanicitxt.HideSelection = true;
            this.kullanicitxt.Hint = "kullanıcı adı";
            this.kullanicitxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.kullanicitxt.LeadingIcon = null;
            this.kullanicitxt.Location = new System.Drawing.Point(92, 126);
            this.kullanicitxt.Mask = "";
            this.kullanicitxt.MaxLength = 32767;
            this.kullanicitxt.MouseState = MaterialSkin.MouseState.OUT;
            this.kullanicitxt.Name = "kullanicitxt";
            this.kullanicitxt.PasswordChar = '\0';
            this.kullanicitxt.PrefixSuffixText = null;
            this.kullanicitxt.PromptChar = '_';
            this.kullanicitxt.ReadOnly = false;
            this.kullanicitxt.RejectInputOnFirstFailure = false;
            this.kullanicitxt.ResetOnPrompt = true;
            this.kullanicitxt.ResetOnSpace = true;
            this.kullanicitxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kullanicitxt.SelectedText = "";
            this.kullanicitxt.SelectionLength = 0;
            this.kullanicitxt.SelectionStart = 0;
            this.kullanicitxt.ShortcutsEnabled = true;
            this.kullanicitxt.Size = new System.Drawing.Size(196, 48);
            this.kullanicitxt.SkipLiterals = true;
            this.kullanicitxt.TabIndex = 1;
            this.kullanicitxt.TabStop = false;
            this.kullanicitxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kullanicitxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.kullanicitxt.TrailingIcon = null;
            this.kullanicitxt.UseSystemPasswordChar = false;
            this.kullanicitxt.ValidatingType = null;
            // 
            // sifretxt
            // 
            this.sifretxt.AllowPromptAsInput = true;
            this.sifretxt.AnimateReadOnly = false;
            this.sifretxt.AsciiOnly = false;
            this.sifretxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sifretxt.BeepOnError = false;
            this.sifretxt.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.sifretxt.Depth = 0;
            this.sifretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sifretxt.HidePromptOnLeave = false;
            this.sifretxt.HideSelection = true;
            this.sifretxt.Hint = "şifre";
            this.sifretxt.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.sifretxt.LeadingIcon = null;
            this.sifretxt.Location = new System.Drawing.Point(92, 180);
            this.sifretxt.Mask = "";
            this.sifretxt.MaxLength = 32767;
            this.sifretxt.MouseState = MaterialSkin.MouseState.OUT;
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.PasswordChar = '\0';
            this.sifretxt.PrefixSuffixText = null;
            this.sifretxt.PromptChar = '_';
            this.sifretxt.ReadOnly = false;
            this.sifretxt.RejectInputOnFirstFailure = false;
            this.sifretxt.ResetOnPrompt = true;
            this.sifretxt.ResetOnSpace = true;
            this.sifretxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sifretxt.SelectedText = "";
            this.sifretxt.SelectionLength = 0;
            this.sifretxt.SelectionStart = 0;
            this.sifretxt.ShortcutsEnabled = true;
            this.sifretxt.Size = new System.Drawing.Size(196, 48);
            this.sifretxt.SkipLiterals = true;
            this.sifretxt.TabIndex = 2;
            this.sifretxt.TabStop = false;
            this.sifretxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sifretxt.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.sifretxt.TrailingIcon = null;
            this.sifretxt.UseSystemPasswordChar = false;
            this.sifretxt.ValidatingType = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(224, 237);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "Giriş";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // kullanici_girisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.kullanicitxt);
            this.Name = "kullanici_girisi";
            this.Load += new System.EventHandler(this.kullanici_girisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox kullanicitxt;
        private MaterialSkin.Controls.MaterialMaskedTextBox sifretxt;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}