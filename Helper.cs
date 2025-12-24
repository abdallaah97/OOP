namespace oop
{
    public static class Helper
    {
        public static int IdCounter = 1000;

        public static int GenerateId() 
        { 
            return IdCounter++;
        }
    }
}
