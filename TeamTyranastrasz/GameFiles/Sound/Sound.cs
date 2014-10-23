namespace RpgGame.Sound
{
    using System;
    using System.IO;
    using System.Media;
    using System.Reflection;

    public class Sound
    {
        public static string GeneratePathToFile(string fileName)
        {
            string additionalPath = "Sound\\SoundFiles\\" + fileName;
            string path = Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            path = Path.Combine(path, "BattleAxeSwing.wav");

            return path;
        }

        public static void PlayMapSound()
        {

            try
            {
                SoundPlayer mapSound = new SoundPlayer("..\\..\\Sound\\SoundFiles\\DiabloTristramVillage.wav");
                mapSound.PlayLooping();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }

        public static void PlayBattleSound()
        {
            try
            {
                SoundPlayer battleSound = new SoundPlayer("..\\..\\Sound\\SoundFiles\\TheBattle.wav");
                battleSound.PlayLooping();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }

        public static void PlayFirstSpellSound()
        {
            try
            {
                var firstSpellSound = new System.Windows.Media.MediaPlayer();
                firstSpellSound.Open(new System.Uri(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) +
                                    @"\Sound\SoundFiles\Spell1Sound.wav"));
                firstSpellSound.Play();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }

        public static void PlaySecondSpellSound()
        {
            try
            {
                var secondSpellSound = new System.Windows.Media.MediaPlayer();
                secondSpellSound.Open(new System.Uri(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) +
                                    @"\Sound\SoundFiles\Spell2Sound.wav"));
                secondSpellSound.Play();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }

        public static void PlayThirdSpellSound()
        {
            try
            {
                var thirdSpellSound = new System.Windows.Media.MediaPlayer();
                thirdSpellSound.Open(new System.Uri(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) +
                                    @"\Sound\SoundFiles\Spell3Sound.wav"));
                thirdSpellSound.Play();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }

        public static void PlayHealSound()
        {
            try
            {
                var healSound = new System.Windows.Media.MediaPlayer();
                healSound.Open(new System.Uri(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) +
                                    @"\Sound\SoundFiles\Heal.mp3"));
                healSound.Play();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }

        public static void PlayAttackBuffSound()
        {
            try
            {
                var attackBuffSound = new System.Windows.Media.MediaPlayer();
                attackBuffSound.Open(new System.Uri(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) +
                                    @"\Sound\SoundFiles\AttackBuff.wav"));
                attackBuffSound.Play();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }

        public static void playDefenseBuffSound()
        {
            try
            {
                var defenseBuffSound = new System.Windows.Media.MediaPlayer();
                defenseBuffSound.Open(new System.Uri(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) +
                                    @"\Sound\SoundFiles\DefenseBuff.flac"));
                defenseBuffSound.Play();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }

        public static void PlayAttackSound()
        {
            try
            {
                var attackBuffSound = new System.Windows.Media.MediaPlayer();
                attackBuffSound.Open(new System.Uri(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) +
                                    @"\Sound\SoundFiles\BattleAxeSwing.wav"));
                attackBuffSound.Play();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }

        public static void PlayDefendSound()
        {
            try
            {
                var defendSound = new System.Windows.Media.MediaPlayer();
                defendSound.Open(new System.Uri(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) +
                                    @"\Sound\SoundFiles\DefendSound.wav"));
                defendSound.Play();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            catch (DirectoryNotFoundException)
            {
                throw new DirectoryNotFoundException("The path to the file is incorrect!");
            }
            catch (IOException)
            {
                throw new IOException("Cannot read from file!");
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}