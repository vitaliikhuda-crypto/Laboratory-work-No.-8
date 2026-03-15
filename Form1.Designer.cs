private System.Windows.Forms.Label label1;
this.label1 = new System.Windows.Forms.Label();
this.SuspendLayout();

this.label1.AutoSize = true;
this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
this.label1.Location = new System.Drawing.Point(200, 150);
this.label1.Name = "label1";
this.label1.Size = new System.Drawing.Size(150, 24);
this.label1.Text = "Перетягни мене";

this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);

this.Controls.Add(this.label1);
