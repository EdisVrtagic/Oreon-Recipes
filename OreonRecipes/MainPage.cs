using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static OreonRecipes.FoodControl;

namespace OreonRecipes
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            ShowComponents();
            bannerPic.Image = Image.FromFile(@"..\..\Banners\" + ImgNum + ".png");
            AllFood();
        }
        //Show components main form
        private void ShowComponents()
        {
            panel2.Location = new Point(-6, 85);
            label5.Location = new Point(60, 295);
            CateFlowLayoutPanel.Location = new Point(59, 320);
            panel3.Location = new Point(55, 387);
            label6.Location = new Point(60, 412);
            flowLayoutPanel1.Location = new Point(59, 446);
            ReplacePanel.Location = new Point(238, 91);
            ReplacePanel.Hide();
            panel2.Show();
            label5.Show();
            CateFlowLayoutPanel.Show();
            panel3.Show();
            label6.Show();
            flowLayoutPanel1.Show();
        }
        //Hide components main form
        private void HideComponents()
        {
            panel2.Location = new Point(-6, 85);
            label5.Location = new Point(60, 295);
            CateFlowLayoutPanel.Location = new Point(59, 320);
            panel3.Location = new Point(55, 387);
            label6.Location = new Point(60, 412);
            flowLayoutPanel1.Location = new Point(59, 446);
            ReplacePanel.Location = new Point(238, 91);
            panel2.Hide();
            label5.Hide();
            CateFlowLayoutPanel.Hide();
            panel3.Hide();
            label6.Hide();
            flowLayoutPanel1.Hide();
            ReplacePanel.Show();
        }
        //Next banner
        private int ImgNum = 1;
        private void LoadNextImg()
        {
            timer1.Start();
            ImgNum++;
            if (ImgNum > 4)
            {
                ImgNum = 1;
            }
            bannerPic.Image = Image.FromFile(@"..\..\Banners\" + ImgNum + ".png");
        }
        //Timer banner
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImg();
        }
        //Dynamic food control list
        public void AddFoodItem(string fname, string ftime, categories category, string frecipe, string frecipeytv, string foimg)
        {
            var addfood = new FoodControl()
            {
                Name_Food = fname,
                Time_Food = ftime,
                Recipe_Food = frecipe,
                RecipeYT_Food = frecipeytv,
                Category = category,
                Food_Image = Image.FromFile(@"..\..\FoodImages\" + foimg)
        };
            flowLayoutPanel1.Controls.Add(addfood);
            addfood.Click += new EventHandler(this.RecipeControl_Click);
        }
        //Control click recipes
        void RecipeControl_Click(object sender, EventArgs es)
        {
            HideComponents();
            FoodControl fobj = (FoodControl)sender;
            ReplaceFName.Text = fobj.Name_Food;
            ReplaceFoodPic.Image = fobj.Food_Image;
            ReplaceFTime.Text = fobj.Time_Food;
            ReplaceFRecipe.Text = fobj.Recipe_Food;
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src='https://www.youtube.com/embed/{0}'width='620' height='330' frameborder='0'></iframe>";
            html += "</head></html>";
            this.YTVideo.DocumentText = string.Format(html, fobj.RecipeYT_Food.Split('=')[1]);

        }
        //All Food
        private void AllFood()
        {
            flowLayoutPanel1.Controls.Clear();
            AddFoodItem("Burger 1", "10 min", categories.Meat, "1 tbs peanut oil\n1 kg chicken thigh fillets\n3 tbs curry powder\n1 brown onion diced large\n3 garlic cloves crushed\n2 tbs tomato paste\n2 tbs sugar\n400g coconut cream\n2 cups rice * to serve", "https://www.youtube.com/watch?v=L6yX6Oxy_J8", "burger1.jpg");
            AddFoodItem("Crispy", "30 min", categories.Meat, "Chicken 400 gm\nSalt To Taste\nPaprika Powder 1 tsp\nBlack Pepper powder 1 / 2 tsp\nGarlic Powder 1 / 2\nGinger 1 / 2 tsp\nLemon Juice 1 tsp\nEgg 2 no\nRefind flour 200 gm\nCorn Flour 50 gm\nCorn Flakes 10 gm\noil For frying", "https://www.youtube.com/watch?v=YsvCkbSnEcU", "crispy.jpg");
            AddFoodItem("Steaks", "30 min", categories.Meat, "2 beef steaks, at least 1-inch thick\n2 teaspoons olive oil\n1 teaspoon salt\n1 / 2 teaspoon black pepper\n1 / 2 teaspoon white pepper\n2 tablespoons softened butter\n1 - 2 cloves garlic, minced", "https://www.youtube.com/watch?v=nsw0Px-Pho8", "steaks.jpg");
            AddFoodItem("Capricciosa", "40 min", categories.Pizza, "Artichoke\nSlices of Ham\n2 sliced Mushrooms\nBlack Olives\n1 x Buffalo Mozzarella shredded or diced\n1 glass of Italian tomato sauce for pizza\nBasil\nA handful of flour", "https://www.youtube.com/watch?v=rfxrHk_Vqjs", "capricciosa.jpeg");
            AddFoodItem("Margherita", "30 min", categories.Pizza, "1kg/4.25 cups Le 5 Stagioni Pizza Napoletana Flour \n600ml / 2.5 cups water(room temperature)\n2g / 0.03oz fresh yeast\n30g / 2 tablespoons sea salt\n1 x tin(400 grams - 14 oz) San Marzano Tomatoes\nFresh Basil\nHandful pecorino romano cheese\n100g / 3.53oz Fior di latte Mozzarella\nSalt\nExtra virgin olive oil", "https://www.youtube.com/watch?v=xKDnD8sJsuY", "margherita.jpg");
            AddFoodItem("Funghi", "18-20 min", categories.Pizza, "1 cup of warm water \n1 tsp active dry yeast\n1 tsp sugar\n5 tbsp olive oil\n1 / 2 tsp salt\n2 cups all - purpose flour\n3 tbsp minced garlic\nSalt & pepper to taste\n200g mushrooms\n200g mozzarella cheese\nPizza sauce ", "https://www.youtube.com/watch?v=xKDnD8sJsuY", "funghi.jpg");
            AddFoodItem("Toast", "7-8 min", categories.Vegan, "Hummus : (grind smooth)\n1 cup boiled chickpea\n2 tbsp sesame paste / tahini\n2 - 3 garlic cloves\n1 tsp lemon juice\n2 tbsp olive oil\n1 / 2 tsp cumin powder\nSalt as per taste\nOther ingredients:\n2 slices of toasted bread\n2 tbsp grated carrot\n2 tbsp sprouts\nBell pepper slices\nCucumber slices\nOnion slices\nLettuce leaves\nCherry Tomato slices\nSalt and pepper as per taste", "https://www.youtube.com/watch?v=0DeJ30_QVBo", "toast.jpg");
            AddFoodItem("Enchiladas", "20 min", categories.Vegan, "2 cups enchilada sauc\n2 tbsp olive oil\n1 cup red onions chopped\n1 red bell pepper chopped\n1 tsp ground cumin\n4 cups baby spinach approx. 4 heaping handfuls\n1 15 oz can black beans rinsed, drained\n1 cup Monterey Jack cheese shredded\n½ cup corn I used frozen\nsalt and pepper to taste\n6 - 8 whole wheat tortillas 8” diameter\nchopped cilantro for garnish", "https://www.youtube.com/watch?v=a23Kyzxogg8", "enchiladas.png");
            AddFoodItem("Zucchini Pasta", "12 min", categories.Vegan, "3 Tablespoon Olive Oil\n130g / 1 + 1 / 4 cup approx.Onion - Thinly Sliced\n3 to 4 garlic cloves / 1 Tablespoon approx.Garlic - finely chopped\n1 / 4 to 1 / 2 Teaspoon Chili Flakes or to taste\n2 + 1 / 2 Tablespoon Tomato Paste\n(If you like your pasta more zesty, slightly increase the quantity of the tomato paste)\n350g / 3 Cups approx.Zucchini - Cut in 1 / 2 inch semi circle pieces\n3 / 4 Cup Pasta Cooking Water OR AS REQUIRED\n200g / 1 + 1 / 4 Cup approx.Cherry or Grape Tomatoes\nSalt to taste(I have added total 1 / 4 + 1 / 2 Teaspoon of pink himalayan salt)\nDrizzle of Olive Oil(I added 1 tablespoon of organic cold pressed Olive Oil)\n1 / 2 Teaspoon Freshly Ground Black Pepper or to taste\n12g / 1 / 2 Cup Fresh Basil or to taste", "https://www.youtube.com/watch?v=BFP1s1ASBuE", "zucchini.jpg");
            AddFoodItem("Ube Cheesecake", "1 hour", categories.Cakes, "Graham Cracker Crust:\n2 cups graham cracker crumbs[225 g]\n5 tbsp unsalted butter[71 g]\n2 tbsp granulated sugar[24 g]\n1 tsp vanilla extract[5 mL]\nUbe Cheesecake Filling:\n3 bars of full - fat cream cheese, 8 oz each(total of 24 oz)[680 g]\n1 cup granulated sugar[200 g]\n1 / 4 cup ube halaya[60 mL]\n2 cups full - fat sour cream(16 oz)[453 g]\n1 tbsp ube extract[15 mL]\n2 tbsp all - purpose flour[15.6 g]\n3 large eggs[150 g without shell]\nCoconut Whipped Cream:\n2 cups heavy cream[480 mL]\n1 / 2 cup cold coconut cream(separated from 13.5 oz can)[120 mL]\n1 / 4 cup granulated sugar[50 g]\n1 tsp vanilla extract[5 mL]", "https://www.youtube.com/watch?v=i4WsL2X61D4", "ubecheesecake.jpg");
            AddFoodItem("Funfetti Cake", "1 hour", categories.Cakes, "120 grams (4 ounces) Canola Oil\n200 grams(7 ounces) Buttermilk\n1 teaspoon Butter Extract\n5 teaspoons Clear Vanilla Extract\n200 grams(7 ounces) Egg Whites\n2 large Eggs\n600 grams(21 ounces) Sugar\n520 grams(18 ounces) Cake Flour\n5 teaspoons Baking Powder\n1 / 2 teaspoon Xanthan Gum\n1 / 2 teaspoon Soy Lecithin\n1 teaspoon Salt\n120 grams(4 ounces) Shortening\n120 grams(4 ounces) Unsalted Butter(room temperature)", "https://www.youtube.com/watch?v=aRW1fo-cMhY", "funfetti.jpg");
            AddFoodItem("Pistachio Cake", "1 hour", categories.Cakes, "Crust 9 inch Baking Pan\n300g Digestive biscuits\n1 / 4 Cup melted butter\nFilling\n1 / 2 Heavy cream\n500g Cream cheese\n1 / 2 Cup icing sugar\n1tsp Vanilla extract\n2 tbsp Lemon\n1 / 2 Cup ground pistachio(to mix with cake batter)\n1tsp gelatin\n1 / 8 Cup hot water(to mix with gelatin)\n1 / 4 Cup Ground pistachio sprinkled(centre of cake)\n1 / 3 cup chopped unshelled pistachio(circumference of cake)\n2 Mint leaves for centre piece", "https://www.youtube.com/watch?v=Xki4ezoKOJY", "pistachio.jpg");
            AddFoodItem("Loaded Brocoli", "7 min", categories.Salads, "The other ingredients that I used to make this easy dish:\n- Craisins(I used the 50 % less sugar variety because they are sweet enough without all the sugar)\n - Kroger walnuts\n - Kroger Fully - cooked bacon(you could cook your own, but this just saves you additional work and time)\n - Kroger sharp cheddar cheese\n - Gala apple\n - Red onion", "https://www.youtube.com/watch?v=gsfFEjQL8iU", "brocolisalad.jpg");
            AddFoodItem("Cucumber", "5 min", categories.Salads, "4 cucumbers\n1 onion\n1 cup vinegar\n1 cup water\n1 teaspoon dill weed\n1 teaspoon Sugar\n1 / 2 fresh squeezed lemon juice\n1 / 2 teaspoon salt\n1 / 2 teaspoon pepper", "https://www.youtube.com/watch?v=AEHSUoHiBwA", "cucumber.jpg");
            AddFoodItem("White Bean", "10 min", categories.Salads, "2 cans white beans (cannellini), drained and rinsed well\n1 English cucumber, diced\n10 oz grape or cherry tomatoes, halved\n4 green onions, chopped\n1 cup chopped fresh parsley\n15 to 20 mint leaves, chopped\n1 lemon, zested and juiced\nSalt and pepper\n1 tsp za’atar, more if you like\n½ tsp each sumac and Aleppo pepper\nExtra virgin olive oil(Early Harvest)\nFeta cheese, optional", "https://www.youtube.com/watch?v=bl17M-aMNuo", "veggiesal.jpg");
        }
        //Pizza
        private void PizzaFood()
        {
            flowLayoutPanel1.Controls.Clear();
            AddFoodItem("Capricciosa", "40 min", categories.Pizza, "Artichoke\nSlices of Ham\n2 sliced Mushrooms\nBlack Olives\n1 x Buffalo Mozzarella shredded or diced\n1 glass of Italian tomato sauce for pizza\nBasil\nA handful of flour", "https://www.youtube.com/watch?v=rfxrHk_Vqjs", "capricciosa.jpeg");
            AddFoodItem("Margherita", "30 min", categories.Pizza, "1kg/4.25 cups Le 5 Stagioni Pizza Napoletana Flour \n600ml / 2.5 cups water(room temperature)\n2g / 0.03oz fresh yeast\n30g / 2 tablespoons sea salt\n1 x tin(400 grams - 14 oz) San Marzano Tomatoes\nFresh Basil\nHandful pecorino romano cheese\n100g / 3.53oz Fior di latte Mozzarella\nSalt\nExtra virgin olive oil", "https://www.youtube.com/watch?v=xKDnD8sJsuY", "margherita.jpg");
            AddFoodItem("Funghi", "18-20 min", categories.Pizza, "1 cup of warm water \n1 tsp active dry yeast\n1 tsp sugar\n5 tbsp olive oil\n1 / 2 tsp salt\n2 cups all - purpose flour\n3 tbsp minced garlic\nSalt & pepper to taste\n200g mushrooms\n200g mozzarella cheese\nPizza sauce ", "https://www.youtube.com/watch?v=xKDnD8sJsuY", "funghi.jpg");
        }
        //Meat
        private void MeatFood()
        {
            flowLayoutPanel1.Controls.Clear();
            AddFoodItem("Burger 1", "10 min", categories.Meat, "1 tbs peanut oil\n1 kg chicken thigh fillets\n3 tbs curry powder\n1 brown onion diced large\n3 garlic cloves crushed\n2 tbs tomato paste\n2 tbs sugar\n400g coconut cream\n2 cups rice * to serve", "https://www.youtube.com/watch?v=L6yX6Oxy_J8", "burger1.jpg");
            AddFoodItem("Crispy", "30 min", categories.Meat, "Chicken 400 gm\nSalt To Taste\nPaprika Powder 1 tsp\nBlack Pepper powder 1 / 2 tsp\nGarlic Powder 1 / 2\nGinger 1 / 2 tsp\nLemon Juice 1 tsp\nEgg 2 no\nRefind flour 200 gm\nCorn Flour 50 gm\nCorn Flakes 10 gm\noil For frying", "https://www.youtube.com/watch?v=YsvCkbSnEcU", "crispy.jpg");
            AddFoodItem("Steaks", "30 min", categories.Meat, "2 beef steaks, at least 1-inch thick\n2 teaspoons olive oil\n1 teaspoon salt\n1 / 2 teaspoon black pepper\n1 / 2 teaspoon white pepper\n2 tablespoons softened butter\n1 - 2 cloves garlic, minced", "https://www.youtube.com/watch?v=nsw0Px-Pho8", "steaks.jpg");
        }
        //Vegetarian
        private void VeganFood()
        {
            flowLayoutPanel1.Controls.Clear();
            AddFoodItem("Toast", "7-8 min", categories.Vegan, "Hummus : (grind smooth)\n1 cup boiled chickpea\n2 tbsp sesame paste / tahini\n2 - 3 garlic cloves\n1 tsp lemon juice\n2 tbsp olive oil\n1 / 2 tsp cumin powder\nSalt as per taste\nOther ingredients:\n2 slices of toasted bread\n2 tbsp grated carrot\n2 tbsp sprouts\nBell pepper slices\nCucumber slices\nOnion slices\nLettuce leaves\nCherry Tomato slices\nSalt and pepper as per taste", "https://www.youtube.com/watch?v=0DeJ30_QVBo", "toast.jpg");
            AddFoodItem("Enchiladas", "20 min", categories.Vegan, "2 cups enchilada sauc\n2 tbsp olive oil\n1 cup red onions chopped\n1 red bell pepper chopped\n1 tsp ground cumin\n4 cups baby spinach approx. 4 heaping handfuls\n1 15 oz can black beans rinsed, drained\n1 cup Monterey Jack cheese shredded\n½ cup corn I used frozen\nsalt and pepper to taste\n6 - 8 whole wheat tortillas 8” diameter\nchopped cilantro for garnish", "https://www.youtube.com/watch?v=a23Kyzxogg8", "enchiladas.png");
            AddFoodItem("Zucchini Pasta", "12 min", categories.Vegan, "3 Tablespoon Olive Oil\n130g / 1 + 1 / 4 cup approx.Onion - Thinly Sliced\n3 to 4 garlic cloves / 1 Tablespoon approx.Garlic - finely chopped\n1 / 4 to 1 / 2 Teaspoon Chili Flakes or to taste\n2 + 1 / 2 Tablespoon Tomato Paste\n(If you like your pasta more zesty, slightly increase the quantity of the tomato paste)\n350g / 3 Cups approx.Zucchini - Cut in 1 / 2 inch semi circle pieces\n3 / 4 Cup Pasta Cooking Water OR AS REQUIRED\n200g / 1 + 1 / 4 Cup approx.Cherry or Grape Tomatoes\nSalt to taste(I have added total 1 / 4 + 1 / 2 Teaspoon of pink himalayan salt)\nDrizzle of Olive Oil(I added 1 tablespoon of organic cold pressed Olive Oil)\n1 / 2 Teaspoon Freshly Ground Black Pepper or to taste\n12g / 1 / 2 Cup Fresh Basil or to taste", "https://www.youtube.com/watch?v=BFP1s1ASBuE", "zucchini.jpg");
        }
        //Cakes
        private void CakesFood()
        {
            flowLayoutPanel1.Controls.Clear();
            AddFoodItem("Ube Cheesecake", "1 hour", categories.Cakes, "Graham Cracker Crust:\n2 cups graham cracker crumbs[225 g]\n5 tbsp unsalted butter[71 g]\n2 tbsp granulated sugar[24 g]\n1 tsp vanilla extract[5 mL]\nUbe Cheesecake Filling:\n3 bars of full - fat cream cheese, 8 oz each(total of 24 oz)[680 g]\n1 cup granulated sugar[200 g]\n1 / 4 cup ube halaya[60 mL]\n2 cups full - fat sour cream(16 oz)[453 g]\n1 tbsp ube extract[15 mL]\n2 tbsp all - purpose flour[15.6 g]\n3 large eggs[150 g without shell]\nCoconut Whipped Cream:\n2 cups heavy cream[480 mL]\n1 / 2 cup cold coconut cream(separated from 13.5 oz can)[120 mL]\n1 / 4 cup granulated sugar[50 g]\n1 tsp vanilla extract[5 mL]", "https://www.youtube.com/watch?v=i4WsL2X61D4", "ubecheesecake.jpg");
            AddFoodItem("Funfetti Cake", "1 hour", categories.Cakes, "120 grams (4 ounces) Canola Oil\n200 grams(7 ounces) Buttermilk\n1 teaspoon Butter Extract\n5 teaspoons Clear Vanilla Extract\n200 grams(7 ounces) Egg Whites\n2 large Eggs\n600 grams(21 ounces) Sugar\n520 grams(18 ounces) Cake Flour\n5 teaspoons Baking Powder\n1 / 2 teaspoon Xanthan Gum\n1 / 2 teaspoon Soy Lecithin\n1 teaspoon Salt\n120 grams(4 ounces) Shortening\n120 grams(4 ounces) Unsalted Butter(room temperature)", "https://www.youtube.com/watch?v=aRW1fo-cMhY", "funfetti.jpg");
            AddFoodItem("Pistachio Cake", "1 hour", categories.Cakes, "Crust 9 inch Baking Pan\n300g Digestive biscuits\n1 / 4 Cup melted butter\nFilling\n1 / 2 Heavy cream\n500g Cream cheese\n1 / 2 Cup icing sugar\n1tsp Vanilla extract\n2 tbsp Lemon\n1 / 2 Cup ground pistachio(to mix with cake batter)\n1tsp gelatin\n1 / 8 Cup hot water(to mix with gelatin)\n1 / 4 Cup Ground pistachio sprinkled(centre of cake)\n1 / 3 cup chopped unshelled pistachio(circumference of cake)\n2 Mint leaves for centre piece", "https://www.youtube.com/watch?v=Xki4ezoKOJY", "pistachio.jpg");
        }
        //Salads
        private void SaladsFood()
        {
            flowLayoutPanel1.Controls.Clear();
            AddFoodItem("Loaded Brocoli", "7 min", categories.Salads, "The other ingredients that I used to make this easy dish:\n- Craisins(I used the 50 % less sugar variety because they are sweet enough without all the sugar)\n - Kroger walnuts\n - Kroger Fully - cooked bacon(you could cook your own, but this just saves you additional work and time)\n - Kroger sharp cheddar cheese\n - Gala apple\n - Red onion", "https://www.youtube.com/watch?v=gsfFEjQL8iU", "brocolisalad.jpg");
            AddFoodItem("Cucumber", "5 min", categories.Salads, "4 cucumbers\n1 onion\n1 cup vinegar\n1 cup water\n1 teaspoon dill weed\n1 teaspoon Sugar\n1 / 2 fresh squeezed lemon juice\n1 / 2 teaspoon salt\n1 / 2 teaspoon pepper", "https://www.youtube.com/watch?v=AEHSUoHiBwA", "cucumber.jpg");
            AddFoodItem("White Bean", "10 min", categories.Salads, "2 cans white beans (cannellini), drained and rinsed well\n1 English cucumber, diced\n10 oz grape or cherry tomatoes, halved\n4 green onions, chopped\n1 cup chopped fresh parsley\n15 to 20 mint leaves, chopped\n1 lemon, zested and juiced\nSalt and pepper\n1 tsp za’atar, more if you like\n½ tsp each sumac and Aleppo pepper\nExtra virgin olive oil(Early Harvest)\nFeta cheese, optional", "https://www.youtube.com/watch?v=bl17M-aMNuo", "veggiesal.jpg");
        }
        //Close button recipes
        private void closeBtn_Click(object sender, EventArgs e)
        {
            ReplaceFName.Text = "";
            ReplaceFoodPic.Image = null;
            ReplaceFTime.Text = "";
            ReplaceFRecipe.Text = "";
            ShowComponents();
        }
        //Application exit button
        private void closeapp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Category pizza button
        private void catP_Click(object sender, EventArgs e)
        {
            PizzaFood();
        }
        //Category meat button
        private void catM_Click(object sender, EventArgs e)
        {
            MeatFood();
        }
        //Category vegetarian button
        private void catV_Click(object sender, EventArgs e)
        {
            VeganFood();
        }
        //Category cakes button
        private void catC_Click(object sender, EventArgs e)
        {
            CakesFood();
        }
        //Category salads button
        private void catS_Click(object sender, EventArgs e)
        {
            SaladsFood();
        }
    }
}
