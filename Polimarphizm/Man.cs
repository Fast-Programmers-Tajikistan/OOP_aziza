using Polimarphizm;

namespace Polimarphizm
{
    public class Man : User
    {
        public override string GetName(string name)
        {
            if (name == null)
            {
                return string.Empty;
            }

            var reverseName = new string(name.Reverse().ToArray());

            return reverseName;
        }

        public override string SetName(string name)
        {
            return name.Replace(" ", ".");
        }
    }
}