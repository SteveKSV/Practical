using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.Mordor_s_Cruel_Plan.FoodList;

namespace _05.Mordor_s_Cruel_Plan.Factories.FoodList
{
    public class FoodFactory
    {
        private string foodName;
        private List<AbstractFood> listOfFood;
        public FoodFactory(List<AbstractFood> listOfFood)
        {
            this.listOfFood = listOfFood;
        }

        public string FoodName
        {
            get
            {
                return foodName;
            }
            set
            {
                foodName = value;
            }
        }

        public static List<AbstractFood> ProduceFood(string input)
        {
            var foods = new List<AbstractFood>();
            var inputData = input.ToLower().Split(' ', ',');

            foreach (var entry in inputData)
            {
                switch (entry)
                {
                    case "cram":
                        foods.Add(new Cram());
                        break;
                    case "lembas":
                        foods.Add(new Lembas());
                        break;
                    case "apple":
                        foods.Add(new Apple());
                        break;
                    case "melon":
                        foods.Add(new Melon());
                        break;
                    case "honeycake":
                        foods.Add(new HoneyCake());
                        break;
                    case "mushrooms":
                        foods.Add(new Mushrooms());
                        break;
                    default:
                        foods.Add(new EverythingElse());
                        break;
                }
            }

            return foods;
        }
    }
}
