namespace RpgGame
{
    using System;
    using System.IO;
    using System.Media;
    using System.Reflection;

    public class Sound
    {
        //[DllImport("winmm.dll")]
        //static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        //private void PlayWorker()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    mciSendString("open \"" + FileName + "\" alias " + this.TrackName, sb, 0, IntPtr.Zero);
        //    mciSendString("play " + this.TrackName, sb, 0, IntPtr.Zero);
        //    IsBeingPlayed = true;
        //}

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

        //public static void PlayTownSound()
        //{
        //    string path = Assembly.GetExecutingAssembly().Location;
        //    path = Path.GetDirectoryName(path);
        //    try
        //    {
        //        var attackSound = new System.Windows.Media.MediaPlayer();
        //        attackSound.Open(new System.Uri());
        //        attackSound.Play();
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        throw new FileNotFoundException();
        //    }
        //    catch (DirectoryNotFoundException)
        //    {
        //        throw new DirectoryNotFoundException("The path to the file is incorrect!");
        //    }
        //    catch (IOException)
        //    {
        //        throw new IOException("Cannot read from file!");
        //    }
        //    catch (InvalidOperationException)
        //    {
        //        throw new InvalidOperationException();
        //    }
        //}

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

        public static void PlayAttackSound()
        {
            try
            {
                var attackSound = new System.Windows.Media.MediaPlayer();
                attackSound.Open(new System.Uri(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()) +
                                    @"\Sound\SoundFiles\BattleAxeSwing.wav"));
                attackSound.Play();
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