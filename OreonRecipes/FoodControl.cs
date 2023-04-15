using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OreonRecipes
{
    public partial class FoodControl : UserControl
    {
        public FoodControl()
        {
            InitializeComponent();
        }
        private categories _category;
        private string _namefood, _timefood, _recipeinfo, _recipeyt;
        public enum categories { Pizza, Meat, Vegan, Cakes, Salads }
        public categories Category 
        {
            get { return _category; }
            set { _category = value;}
        }
        public Image Food_Image
        { 
            get => FoodPic.Image; 
            set => FoodPic.Image = value;
        }
        public string Name_Food
        {
            get { return _namefood; }
            set { _namefood = value; FoodName.Text = value; }
        }
        public string Time_Food
        {
            get { return _timefood; }
            set { _timefood = value; FoodTime.Text = value; }
        }
        public string Recipe_Food
        {
            get { return _recipeinfo; }
            set { _recipeinfo = value;}
        }
        public string RecipeYT_Food
        {
            get { return _recipeyt; }
            set { _recipeyt = value;}
        }
        private void FoodControl_Load(object sender, EventArgs e)
        {
            FPanel.Click += new EventHandler((object senders, EventArgs ps) => this.OnClick(ps));
            FoodPic.Click += new EventHandler((object senders, EventArgs ps) => this.OnClick(ps));
            FoodName.Click += new EventHandler((object senders, EventArgs ps) => this.OnClick(ps));
            FoodTime.Click += new EventHandler((object senders, EventArgs ps) => this.OnClick(ps));
            ClickRecipe.Click += new EventHandler((object senders, EventArgs ps) => this.OnClick(ps));
        }
    }
}
