namespace Algorithms_TreeBuild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataSort sort = new DataSort(); 
            TreeBuilder build = new TreeBuilder();
            
            string[] strArray = sort.ConvertIntArrayToStringArray(sort.ReadDataFromFile(sort.path));
            build.BuildTree(strArray);

        }
    }
}