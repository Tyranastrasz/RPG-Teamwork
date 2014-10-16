namespace RpgGame
{
    using System;
    using System.IO;
    using System.Media;

    public class Sound
    {
        public static void PlayMapSound()
        {
            try
            {
                using (SoundPlayer mapSound = new SoundPlayer())
                {
                    mapSound.Play();
                }
            }
            catch (ArgumentException)
            {
                throw new ArgumentException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
        }

        public static void PlayTownSound()
        {
            try
            {
                using (SoundPlayer townSound = new SoundPlayer())
                {
                    townSound.Play();
                }
            }
            catch (ArgumentException)
            {
                throw new ArgumentException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
        }

        public static void PlayBattleSound()
        {
            try
            {
                using (SoundPlayer battleSound = new SoundPlayer())
                {
                    battleSound.Play();
                }
            }
            catch (ArgumentException)
            {
                throw new ArgumentException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
        }
    }
}
