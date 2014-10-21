using System.CodeDom.Compiler;

namespace RpgGame
{
    using System;
    using System.IO;
    using System.Media;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Text;

    
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
            //string additionalPath = "Sound\\SoundFiles\\" + fileName;
            string path = Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            path = Path.Combine(path, "BattleAxeSwing.wav");

            return path;
        }

        public static void PlayMapSound()
        {
            
            try
            {
                using (SoundPlayer mapSound = new SoundPlayer("..\\..\\Sound\\SoundFiles\\DiabloTristramVillage.wav"))
                {
                    mapSound.PlayLooping();
                }
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

        public static void PlayTownSound()
        {
            string path = Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            try
            {
                using (SoundPlayer townSound = new SoundPlayer())
                {
                    townSound.Play();
                }
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
                using (SoundPlayer battleSound = new SoundPlayer("..\\..\\Sound\\SoundFiles\\TheBattle.wav"))
                {
                    battleSound.Play();
                }
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
                using (SoundPlayer attackSound = new SoundPlayer("..\\..\\Sound\\SoundFiles\\BattleAxeSwing.wav"))
                {
                    attackSound.Play();
                }
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
