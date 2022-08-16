using System.IO;
using System.Web;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter
{
    public interface IUnicodeFileToHtmlTextConverter
    {
        string ConvertToHtml();
    }

    public interface IIextReader
    {
        string OpenText();
    }

    public class UnicodeFileToHtmlTextConverter : IUnicodeFileToHtmlTextConverter
    {
        private readonly string _fullFilenameWithPath;


        public UnicodeFileToHtmlTextConverter(string fullFilenameWithPath)
        {
            _fullFilenameWithPath = fullFilenameWithPath;
        }

        public string ConvertToHtml()
        {
            using (TextReader unicodeFileStream = File.OpenText(_fullFilenameWithPath))
            {
                string html = string.Empty;

                string line = unicodeFileStream.ReadLine();
                while (line != null)
                {
                    html += HttpUtility.HtmlEncode(line);
                    html += "<br />";
                    line = unicodeFileStream.ReadLine();
                }

                return html;
            }
        }
    }
}
