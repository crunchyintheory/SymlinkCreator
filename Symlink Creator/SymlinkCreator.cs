using System;
using System.Runtime.InteropServices;
using System.IO;

namespace SymlinkCreator
{
    public enum LinkType
    {
        File = 0,
        Directory = 1
    }
    public class LinkCreator
    {
        [DllImport("kernel32.dll")]
        private static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, LinkType dwFlags);
        public static bool createSymbolicLink(string destinationPath, string targetPath, LinkType linkType)
        {
            completeLinkStep(new EventArgs());
            if (CreateSymbolicLink(destinationPath, targetPath, linkType))
            {
                completeLinkStep(new EventArgs());
            }
            return true;
        }
        public static bool createSymbolicLinkAndMove(string destinationPath, string targetPath, LinkType linkType)
        {
            if(linkType == LinkType.Directory)
            {
                completeLinkStep(new EventArgs());
                Directory.Move(targetPath, destinationPath);
                completeLinkStep(new EventArgs());
                if (CreateSymbolicLink(targetPath, destinationPath, linkType))
                {
                    completeLinkStep(new EventArgs());
                }
                return true;
            } else
            {
                completeLinkStep(new EventArgs());
                File.Move(targetPath, destinationPath);
                completeLinkStep(new EventArgs());
                if (CreateSymbolicLink(targetPath, destinationPath, linkType))
                {
                    completeLinkStep(new EventArgs());
                }
                return true;
            }
        }
        public static bool createSymbolicLinkNoExecutables(string destinationPath, string targetPath)
        {
            return false;
        }
        public static event EventHandler LinkStepCompleted = delegate {};
        public static void completeLinkStep(EventArgs e)
        {
            LinkStepCompleted?.Invoke(null, e);
        }
    }
}
