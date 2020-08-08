using Kiosk_File_Explorer.Directory.Data;
using System;
using System.IO;

namespace Kiosk_File_Explorer.Directory.Commands
{
    public class FileCommand
    {
        /// <summary>
        /// Hold Source Path for File OR Directory
        /// </summary> 
        private string srourcePath;
        public string SourcePath
        {
            get { return srourcePath; }
            set { srourcePath = value; }
        }


        /// <summary>
        /// Hold Destination Path for File OR Directory
        /// </summary> 
        private string destinitionPath;
        public string DestinitionPath
        {
            get { return destinitionPath; }
            set { destinitionPath = value; }
        }


        /// <summary>
        /// Hold action to perform on Directory or File
        /// </summary>
        private FileActionType actionHolder;

        public FileActionType ActionHolder
        {
            get { return actionHolder; }
            set { actionHolder = value; }
        }



        /// <summary>
        /// Take action on desired action
        /// </summary>
        /// <param name="action">Type of action to be taken</param>
        /// <param name="source">Source Drirectory OR File Path</param>
        /// <param name="destination">Destination Drirectory Path</param>
        public void PerformAction()
        {
            if (this.ActionHolder == FileActionType.Copy)
                DirectoryCopy(this.srourcePath, this.destinitionPath);
            else if (this.ActionHolder == FileActionType.Cut)
                DirectoryMove(this.srourcePath, this.destinitionPath);
        }

        /// <summary>
        /// Copy File(s) Or directory from one directory to another directory
        /// </summary>
        /// <param name="sourceDirName">Source Drirectory OR File Path</param>
        /// <param name="destDirName">Source Drirectory OR File Path</param>
        /// <param name="copySubDirs">Should copy sub-directories</param>
        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs = true)
        {

            //If File Exist
            if (!File.Exists(sourceDirName))
            {
                throw new DirectoryNotFoundException(
                    "Source file does not exist or could not be found: "
                    + sourceDirName);
            }
            try
            {
                ValidateDirectory(destinitionPath);
                //CopyFile
                File.Copy(sourceDirName, destDirName + Path.GetFileName(sourceDirName), true);
            }
            catch
            {

            }

        }

        /// <summary>
        /// Move File(s) Or directory from one directory to another directory
        /// </summary>
        /// <param name="sourceDirName">Source Drirectory OR File Path</param>
        /// <param name="destDirName">Source Drirectory OR File Path</param>
        private void DirectoryMove(string sourceDir, string destDir)
        {
            if (!File.Exists(sourceDir))
            {
                throw new DirectoryNotFoundException(
                    "Source file does not exist or could not be found: "
                    + sourceDir);
            }
            try
            {
                ValidateDirectory(destinitionPath);
                System.IO.Directory.Move(sourceDir, destDir);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Velidate Directory, create if not exist
        /// </summary>
        /// <param name="path">Directory Path</param>
        /// <returns></returns>
        private string ValidateDirectory(string path)
        {
            if (!System.IO.Directory.Exists(destinitionPath))
            {
                System.IO.Directory.CreateDirectory(destinitionPath);
            }
            return path;
        }
 
    }
}
