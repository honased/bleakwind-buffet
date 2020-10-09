/*
 * Author: Eric Honas
 * Class name: MenuSelectionScreen.xaml.cs
 * Purpose: A component used for displaying the menu of available options.
 */

using BleakwindBuffet.Data.Classes;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Interfaces;
using PointOfSale.Screens.Menus.Buttons;
using PointOfSale.Screens.Menus.Drinks;
using PointOfSale.Screens.Menus.Entrees;
using PointOfSale.Screens.Menus.Sides;
using System;
using System.Windows;
using System.Windows.Controls;

namespace PointOfSale.Screens.Menus
{
    /// <summary>
    /// A class used for allowing a user to view all of the menu items and choose one to add to the order.
    /// </summary>
    public partial class MenuSelectionScreen : UserControl, IMenuScreen
    {
        /// <summary>
        /// Creates a new MenuSelectionScreen component.
        /// </summary>
        public MenuSelectionScreen()
        {
            InitializeComponent();
        }

        public MenuSelectionScreen(bool showEntree, bool showDrinks, bool showSides)
        {
            InitializeComponent();

            foreach (Button button in gridButtons.Children)
            {
                if (!showEntree && button is EntreeButton) button.Visibility = Visibility.Hidden;
                if (!showDrinks && button is DrinkButton)  button.Visibility = Visibility.Hidden;
                if (!showSides  && button is SideButton)   button.Visibility = Visibility.Hidden;
            }

            comboButton.Visibility = Visibility.Hidden;
            cancelButton.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// The parent that is holding and displaying this component.
        /// </summary>
        public OrderComponent OrderComponent { get; set; }

        public UserControl ReturnScreen { get; set; }

        /// <summary>
        /// Swaps the screen to allow for the item chosen to be customized and added to the order.
        /// </summary>
        /// <param name="sender">The menu button that was pressed.</param>
        /// <param name="e">The event arguments associated with the press.</param>
        /// <exception cref="System.NotImplementedException">Thrown if the tag for the button has not been implemented.</exception>
        private void CustomizeItem(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                switch(button.Tag)
                {
                    // Entrees
                    case "0": ChangeToItem<BriarheartBurger, BriarheartBurgerCustomization>("Briarheart Burger"); break;
                    case "1": ChangeToItem<DoubleDraugr, DoubleDraugrCustomization>("Double Draugr"); break;
                    case "2": ChangeToItem<ThalmorTriple, ThalmorTripleCustomization>("Thalmor Triple"); break;
                    case "3": ChangeToItem<SmokehouseSkeleton, SmokehouseSkeletonCustomization>("Smokehouse Skeleton"); break;
                    case "4": ChangeToItem<GardenOrcOmelette, GardenOrcOmeletteCustomization>("Garden Orc Omelette"); break;
                    case "5": ChangeToItem<ThugsTBone, ThugsTBoneCustomization>("Thugs T-Bone"); break;
                    case "6": ChangeToItem<PhillyPoacher, PhillyPoacherCustomization>("Philly Poacher"); break;

                    // Drinks
                    case "7": ChangeToItem<SailorSoda, SailorSodaCustomization>("Sailor Soda"); break;
                    case "8": ChangeToItem<MarkarthMilk, MarkarthMilkCustomization>("Markarth Milk"); break;
                    case "9": ChangeToItem<AretinoAppleJuice, AretinoAppleJuiceCustomization>("Aretino Apple Juice"); break;
                    case "10": ChangeToItem<CandlehearthCoffee, CandlehearthCoffeeCustomization>("Candlehearth Coffee"); break;
                    case "11": ChangeToItem<WarriorWater, WarriorWaterCustomization>("Warrior Water"); break;

                    // Sides
                    case "12": ChangeToItem<VokunSalad, SideCustomization>("Vokun Salad"); break;
                    case "13": ChangeToItem<FriedMiraak, SideCustomization>("Fried Miraak"); break;
                    case "14": ChangeToItem<MadOtarGrits, SideCustomization>("Mad Otar Grits"); break;
                    case "15": ChangeToItem<DragonbornWaffleFries, SideCustomization>("Dragonborn Waffle Fries"); break;

                    // Combo
                    case "16": ChangeToItem<Combo, ComboCustomization>("Dragonborn Waffle Fries"); break;

                    // Unknown
                    default:
                        throw new NotImplementedException("Haven't implemented that specific button yet.");
                }
            }
        }

        /// <summary>
        /// Creates a new custom customizer component with the given <typeparamref name="TOrderItem"/> 
        /// and <typeparamref name="TCustomizationOptions"/>, and it
        /// swaps the order screen to show this new customization component with the <paramref name="name"/>
        /// as the title.
        /// </summary>
        /// <typeparam name="TOrderItem">The type of item to create.</typeparam>
        /// <typeparam name="TCustomizationOptions">The customization page to use to create it.</typeparam>
        /// <param name="name">The name of the menu item.</param>
        private void ChangeToItem<TOrderItem, TCustomizationOptions>(string name) where TOrderItem : IOrderItem, new() where TCustomizationOptions : CustomizationScreen, new()
        {
            if(DataContext is Combo combo)
            {
                ItemModification modifier = new ItemModification();
                modifier.customizeItemLabel.Text = "Customize " + name;
                TCustomizationOptions customizationOptions = new TCustomizationOptions();
                TOrderItem item = new TOrderItem();
                customizationOptions.DataContext = item;
                modifier.customizationContainer.Child = customizationOptions;
                modifier.ReturnScreen = ReturnScreen;

                if (item is Entree entree) combo.Entree = entree;
                else if (item is Drink drink) combo.Drink = drink;
                else if (item is Side side) combo.Side = side;

                OrderComponent.ChangeScreen(modifier);
            }
            else if(OrderComponent.DataContext is Order order)
            {
                ItemCustomization customizer = new ItemCustomization();
                customizer.customizeItemLabel.Text = "Customize " + name;
                TCustomizationOptions customizationOptions = new TCustomizationOptions();
                TOrderItem item = new TOrderItem();
                customizationOptions.DataContext = item;
                customizer.customizationContainer.Child = customizationOptions;
                OrderComponent.ChangeScreen(customizer);

                order.Add(item);
            }
        }

        private void CancelClicked(object sender, RoutedEventArgs e)
        {
            OrderComponent.ChangeScreen(ReturnScreen);
        }
    }
}