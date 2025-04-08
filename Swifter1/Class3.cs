

namespace Swifter1
{
    class Class3
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

            try
            {
                mt.main(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}


