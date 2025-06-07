using Abstract.Factory.Models;

namespace Abstract.Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFactory chineseFactory = FoodFactory.CreateFactory(FoodType.Chinese);
            if(chineseFactory is not null)
            {
                chineseFactory.Starter().Prepare();
                chineseFactory.MainCourse().Prepare();
                chineseFactory.Desert().Prepare();
            }

            IFactory indianFactory = FoodFactory.CreateFactory(FoodType.Indian);
            if(indianFactory is not null)
            {
                indianFactory.Starter().Prepare();
                indianFactory.MainCourse().Prepare();
                indianFactory.Desert().Prepare();
            }
        }
    }
}
