using FoodShopping.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodShopping.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle="Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4},
            new PizzasModel(){
                ImageTitle="Bolognese",
                PizzaName="Bolognese",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                FinalPrice=5},
            new PizzasModel(){
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=2,
                TomatoSauce=true,
                Ham=true,
                Pineapple=true,
                FinalPrice=10},
            new PizzasModel(){
                ImageTitle="Mushroom",
                PizzaName="Mushroom",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                FinalPrice=4},
            new PizzasModel(){
                ImageTitle="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Tuna=true,
                FinalPrice=5}
        };
        public void OnGet()
        {
        }
    }
}
