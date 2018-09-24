namespace Transportation
{
    public class Cycle:TransPo
    {
        public Cycle()
        {

        }
            public override string GetWear(int miles, int temp, int tread)
        {

            string condition = " ";
            if (temp != 0)
            {
                int calcOne = (miles * 2) / temp;
                double calcTwo = tread * .5;
                if (calcOne < calcTwo)
                {
                    condition = "UnSafe";
                }
                else
                {
                    condition = "Safe";

                }
            }
            else
            {
                condition = "Invalid Entry";
            }

            return condition;

        }
    }
}
