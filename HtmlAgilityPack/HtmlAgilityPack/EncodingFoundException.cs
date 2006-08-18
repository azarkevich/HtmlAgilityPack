// HtmlAgilityPack V1.0 - Simon Mourier <simon_mourier@hotmail.com>
using System;
using System.Text;

namespace HtmlAgilityPack
{
    internal class EncodingFoundException : Exception
    {
        private Encoding _encoding;

        internal EncodingFoundException(Encoding encoding)
        {
            _encoding = encoding;
        }

        internal Encoding Encoding
        {
            get
            {
                return _encoding;
            }
        }
    }
}
