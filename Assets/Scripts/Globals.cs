using System;
namespace Application
{
    public static class Globals
    {
        public static int Lives = 3;
        public static int BlockCount = 36;

        public static void ResetGame(){
            Lives = 3;
            BlockCount = 36;
        }
    }
}
