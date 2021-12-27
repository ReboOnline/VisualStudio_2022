using FontAwesome.Sharp;


namespace Flat_UI_V1
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBTN;

        //construtor
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBTN = new Panel();
            leftBorderBTN.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBoderBtn);

        }

        //Method
        private viod ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //Button 
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBTN.BackColor = color;
                leftBorderBTN.Location = new Point(0,currentBtn.Location Y);
                leftBorderBTN.Visible = true;
                leftBorderBTN.BringToFront();
                
            }
        }
    }
}