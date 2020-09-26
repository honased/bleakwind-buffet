/*
 * Author: Eric Honas
 * Class name: MenuSelectionScreen.xaml.cs
 * Purpose: A component used for displaying the menu of available options.
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Interfaces;
using BleakwindBuffet.Data.Sides;
using PointOfSale.Interfaces;
using PointOfSale.Screens;
using PointOfSale.Screens.Menus;
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

        /// <summary>
        /// The parent that is holding and displaying this component.
        /// </summary>
        public Order OrderComponent { get; set; }

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
                    case "0": CustomizeItem<BriarheartBurger, BriarheartBurgerCustomization>("Briarheart Burger"); break;
                    case "1": CustomizeItem<DoubleDraugr, DoubleDraugrCustomization>("Double Draugr"); break;
                    case "2": CustomizeItem<ThalmorTriple, ThalmorTripleCustomization>("Thalmor Triple"); break;
                    case "3": CustomizeItem<SmokehouseSkeleton, SmokehouseSkeletonCustomization>("Smokehouse Skeleton"); break;
                    case "4": CustomizeItem<GardenOrcOmelette, GardenOrcOmeletteCustomization>("Garden Orc Omelette"); break;
                    case "5": CustomizeItem<ThugsTBone, ThugsTBoneCustomization>("Thugs T-Bone"); break;
                    case "6": CustomizeItem<PhillyPoacher, PhillyPoacherCustomization>("Philly Poacher"); break;

                    // Drinks
                    case "7": CustomizeItem<SailorSoda, SailorSodaCustomization>("Sailor Soda"); break;
                    case "8": CustomizeItem<MarkarthMilk, MarkarthMilkCustomization>("Markarth Milk"); break;
                    case "9": CustomizeItem<AretinoAppleJuice, AretinoAppleJuiceCustomization>("Aretino Apple Juice"); break;
                    case "10": CustomizeItem<CandlehearthCoffee, CandlehearthCoffeeCustomization>("Candlehearth Coffee"); break;
                    case "11": CustomizeItem<WarriorWater, WarriorWaterCustomization>("Warrior Water"); break;

                    // Sides
                    case "12": CustomizeItem<VokunSalad, SideCustomization>("Vokun Salad"); break;
                    case "13": CustomizeItem<FriedMiraak, SideCustomization>("Fried Miraak"); break;
                    case "14": CustomizeItem<MadOtarGrits, SideCustomization>("Mad Otar Grits"); break;
                    case "15": CustomizeItem<DragonbornWaffleFries, SideCustomization>("Dragonborn Waffle Fries"); break;

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
        private void CustomizeItem<TOrderItem, TCustomizationOptions>(string name) where TOrderItem : IOrderItem where TCustomizationOptions : UIElement, ICustomizable, new()
        {
            ItemCustomization customizer = new ItemCustomization();

            customizer.customizeItemLabel.Text = "Customize " + name;

            TCustomizationOptions customizationOptions = new TCustomizationOptions();
            customizationOptions.CustomizableItemType = typeof(TOrderItem);

            customizer.customizationContainer.Child = customizationOptions;

            OrderComponent.ChangeScreen(customizer);
        }
    }
}