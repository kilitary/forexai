namespace FinancePermutator.Media
{
    public static class Audio
    {
        public static void playFoto()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            player.SoundLocation = "foto.wav";
            player.Play();
        }
    }
}
