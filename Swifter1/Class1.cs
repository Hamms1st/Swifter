


namespace Swifter1
{
    class Class1
    {
        public int check = 0;
        public void main()
        {
            test ts = new test();
            bluetooth bt = new bluetooth();
            dark dt = new dark();
            Mute mt = new Mute();
            battery battery = new battery();
            Energy eg = new Energy();
            OpenApp op = new OpenApp();
            PasteText pt = new PasteText();
            
            try
            {
                op.main("C:\\Users\\me\\AppData\\Local\\Programs\\Opera\\opera.exe");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}


