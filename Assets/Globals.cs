using System;
namespace Application
{
    public static class Globals
    {
        public static int Lives = 1;
        public static int BlockCount = 1;

        public static void ResetGame(){
            Lives = 1;
            BlockCount = 1;
        }
    }
}
