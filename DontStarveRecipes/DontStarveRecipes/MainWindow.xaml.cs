using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DontStarveRecipes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Label[] RecipeListItems { get; set; }
        public string[] Recipes { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            RecipeListItems = new Label[31];
            CreateRecipeArray();
        }



        public void CreateRecipeArray()
        {
            Recipes = new string[]{ "BACON AND EGGS - (1.5 Meat, 2 Eggs) NO veg <Health:20 Hunger:75 Sanity:5>",
             "BUTTER MUFFIN - (1 Butterfly, 0.5 Veg) NO meat<Health:20 Hunger:37.5 Sanity:5>",
             "DRAGON PIE - (1 Dragonfruit) NO meat <Health:40 Hunger:75 Sanity:5>",
             "FISH TACOS - (0.5 Fish, 1 Corn) <Health:20 Hunger:37.5 Sanity:5>",
             "FISHSTICKS - (0.5 Fish, 1 Stick) MAX 1 stick <Health:40 Hunger:37,5 Sanity:5>",
             "FIST FULL OF JAM - (0.5 Fruit) NO meat, veg, stick <Health:3 Hunger:37.5 Sanity:5>",
             "FLOWER SALAD - (1 Flower, 2 Veg) NO berry, meat, egg, honey, stick <Health:40 Hunger:12.5 Sanity:5>",
             "FROGGIE BUNWICH - (1 Frog, 0.5 Veg) <Health:20 Hunger:37.5 Sanity:5>",
             "FRUIT MEDLY - (3 Fruit) NO meat, veg <Health:20 Hunger:25 Sanity:5>",
             "GUACAMOLE - (1 Cactus, 1 Mole) NO fruit <Health:20 Hunger:37.5 Sanity:0>",
             "HONEY HAM - (2 Meat, 1 Honey) NO stick <Health:30 Hunger:75 Sanity:5>",
             "HONEY NUGGETS - (0.5 Meat, 1 Honey) NO stick <Health:20 Hunger:37.5 Sanity:5>",
             "ICE CREAM - (1 Dairy, 1 Ice, 1 Honey) NO meat, egg, veg, stick <Health:0 Hunger:25 Sanity:50>",
             "KABOBS - (0.5 Meat, 1 Stick) MAX 1 stick <Health:3 Hunger:37.5 Sanity:5>",
             "MANDRAKE SOUP - (1 Mandrake) <Health:100 Hunger:150 Sanity:5>",
             "MEATBALLS - (0.5 Meat) NO stick <Health:3 Hunger:62.5 Sanity:5>",
             "MEATY STEW - (3.0 Meat) NO stick <Health:12 Hunger:150 Sanity:5>",
             "MELONSICLE - (1 Watermelon, 1 Ice, 1 Stick) NO meat, egg, veg <Health:3 Hunger:12.5 Sanity:20>",
             "MONSTER LASAGNA - (2 Monster Meat or Durian) NO stick <Health:-20 Hunger:37.5 Sanity:-20>",
             "PIEROGI - (1 Egg, 0.5 Meat, 0.5 Veg) NO stick <Health:40 Hunger:37.5 Sanity:5>",
             "POWDERCAKE - (1 Corn, 1 Honey, 1 Stick) <Health:-3 Hunger:0 Sanity:0>",
             "PUMPKIN COOKIES - (1 Pumpkin, 2 Honey) <Health:0 Hunger:37.5 Sanity:15>",
             "RATATOUILLE - (0.5 Veg) NO meat, stick <Health:3 Hunger:25 Sanity:5>",
             "SPICY CHILI - (1.5 Veg, 1.5 Meat) <Health:20 Hunger:37.5 Sanity:0>",
             "STUFFED EGGPLANT - (1 Eggplant, 0.5 Veg) <Health:3 Hunger:37.5 Sanity:5>",
             "TAFFY - (3 Honey) NO meat <Health:-3 Hunger:25 Sanity:15>",
             "TRAIL MIX - (1 Birchnut, 1 Berry, 0.5 Fruit) <Health:30 Hunger:12.5 Sanity:5>",
             "Turkey Dinner - (2 Drumsick, 0.5 Meat, 0.5 Veg OR Fruit) <Health:20 Hunger:75 Sanity:5>",
             "UNAGI - (1 Eel, 1 Lichen) <Health:20 Hunger:18.8 Sanity:5>",
             "WAFFLES - (1 Butter, 1 Egg, 1 Berry) <Health:60 Hunger:37.5 Sanity:5>",
             "WET GOOP - YOU DONE GOOF'D"};

            for (int i = 0; i < RecipeListItems.Length; i++)
            {
                RecipeListItems[i] = new Label();
                RecipeListItems[i].Content = Recipes[i];
                lstbxRecipes.Items.Add(RecipeListItems[i]);

            }
        }

        private void btnSort_click(object sender, RoutedEventArgs e)
        {
            FillRecipeListBox(cmbxIngredients);

            switch (cmbxIngredients.Text)
            {
                case "All":
                    lstbxRecipes.Items.Clear();

                    for (int i = 0; i < RecipeListItems.Length; i++)
                    {
                        lstbxRecipes.Items.Add(RecipeListItems[i]);
                    }
                    break;

                case "Dairy":
                    lstbxRecipes.Items.Clear();

                    for (int i = 0; i < RecipeListItems.Length; i++)
                    {
                        if (RecipeListItems[i].Content.ToString().Contains("Dairy") ||
                            RecipeListItems[i].Content.ToString().Contains("Butter"))
                        {
                            if (!RecipeListItems[i].Content.ToString().Contains("Butterfly"))
                            { lstbxRecipes.Items.Add(RecipeListItems[i]); }
                        }
                    }
                    break;

                case "Egg":
                    lstbxRecipes.Items.Clear();

                    for (int i = 0; i < RecipeListItems.Length; i++)
                    {
                        if (RecipeListItems[i].Content.ToString().Contains("Egg"))
                        {
                            if (!RecipeListItems[i].Content.ToString().Contains("Eggplant"))
                            { lstbxRecipes.Items.Add(RecipeListItems[i]); }
                        }
                    }
                    break;

                case "Fish":
                    lstbxRecipes.Items.Clear();

                    for (int i = 0; i < RecipeListItems.Length; i++)
                    {
                        if (RecipeListItems[i].Content.ToString().Contains("Fish") ||
                            RecipeListItems[i].Content.ToString().Contains("Eel"))
                        {
                            lstbxRecipes.Items.Add(RecipeListItems[i]);
                        }
                    }
                    break;

                case "Meat":
                    lstbxRecipes.Items.Clear();

                    for (int i = 0; i < RecipeListItems.Length; i++)
                    {
                        if (RecipeListItems[i].Content.ToString().Contains("Meat") ||
                            RecipeListItems[i].Content.ToString().Contains("Frog") ||
                            RecipeListItems[i].Content.ToString().Contains("Mole"))
                        {
                            if (!RecipeListItems[i].Content.ToString().Contains("Monster Meat"))
                            { lstbxRecipes.Items.Add(RecipeListItems[i]); }
                        }
                    }
                    break;

                case "Fruit":
                    lstbxRecipes.Items.Clear();

                    for (int i = 0; i < RecipeListItems.Length; i++)
                    {
                        if (RecipeListItems[i].Content.ToString().Contains("Fruit") ||
                            RecipeListItems[i].Content.ToString().Contains("Berry") ||
                            RecipeListItems[i].Content.ToString().Contains("Cactus") ||
                            RecipeListItems[i].Content.ToString().Contains("Dragonfruit") ||
                            RecipeListItems[i].Content.ToString().Contains("Durian") ||
                            RecipeListItems[i].Content.ToString().Contains("Watermelon"))
                        {
                            lstbxRecipes.Items.Add(RecipeListItems[i]);
                        }
                    }
                    break;
                case "Veg":
                    lstbxRecipes.Items.Clear();

                    for (int i = 0; i < RecipeListItems.Length; i++)
                    {
                        if (RecipeListItems[i].Content.ToString().Contains("Veg") ||
                            RecipeListItems[i].Content.ToString().Contains("Corn") ||
                            RecipeListItems[i].Content.ToString().Contains("Eggplant") ||
                            RecipeListItems[i].Content.ToString().Contains("Lichen") ||
                            RecipeListItems[i].Content.ToString().Contains("Pumpkin"))
                        {
                            lstbxRecipes.Items.Add(RecipeListItems[i]);
                        }
                    }
                    break;
            }
        }

        private void btnSpecSort_Click(object sender, RoutedEventArgs e)
        {
            FillRecipeListBox(cmbxSpecIngredients);
        }

        private void btnMeatDairySort_Click(object sender, RoutedEventArgs e)
        {
            FillRecipeListBox(cmbxMeatDairyIngredients);
        }

        private void btnVegFruitSort_Click(object sender, RoutedEventArgs e)
        {
            FillRecipeListBox(cmbxVegFruitIngredients);
        }

        private void FillRecipeListBox(ComboBox aComboBox)
        {
            if (aComboBox.SelectedIndex != 0)
            {
                string ingredient = aComboBox.Text;

                lstbxRecipes.Items.Clear();

                for (int i = 0; i < RecipeListItems.Length; i++)
                {
                    if (RecipeListItems[i].Content.ToString().Contains(ingredient))
                    {
                        lstbxRecipes.Items.Add(RecipeListItems[i]);
                    }
                }
            }
            else
            {
                lstbxRecipes.Items.Clear();

                for (int i = 0; i < RecipeListItems.Length; i++)
                {
                    lstbxRecipes.Items.Add(RecipeListItems[i]);
                }
            }
        }

    }
}