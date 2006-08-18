// HtmlAgilityPack V1.0 - Simon Mourier <simon_mourier@hotmail.com>
using System;

namespace HtmlAgilityPack
{
    /// <summary>
    /// Represents an HTML comment.
    /// </summary>
    public class HtmlCommentNode : HtmlNode
    {
        private string _comment;

        internal HtmlCommentNode(HtmlDocument ownerdocument, int index)
            :
            base(HtmlNodeType.Comment, ownerdocument, index)
        {
        }

        /// <summary>
        /// Gets or Sets the HTML between the start and end tags of the object. In the case of a text node, it is equals to OuterHtml.
        /// </summary>
        public override string InnerHtml
        {
            get
            {
                if (_comment == null)
                {
                    return base.InnerHtml;
                }
                return _comment;
            }
            set
            {
                _comment = value;
            }
        }

        /// <summary>
        /// Gets or Sets the object and its content in HTML.
        /// </summary>
        public override string OuterHtml
        {
            get
            {
                if (_comment == null)
                {
                    return base.OuterHtml;
                }
                return "<!--" + _comment + "-->";
            }
        }

        /// <summary>
        /// Gets or Sets the comment text of the node.
        /// </summary>
        public string Comment
        {
            get
            {
                if (_comment == null)
                {
                    return base.InnerHtml;
                }
                return _comment;
            }
            set
            {
                _comment = value;
            }
        }
    }

}
