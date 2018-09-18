﻿using Cactus.Email.Core.Senders;

namespace Cactus.Email.Core.Managers
{
    public interface ITemplate<TKey>
    {
        TKey Id { get; set; }

        string Name { get; set; }

        string SubjectTemplate { get; set; }

        string BodyTemplate { get; set; }

        bool IsBodyHtml { get; set; }

        string PlainBody { get; set; }

        string Language { get; set; }

        EncodingType? HtmlBodyEncoding { get; set; }

        EncodingType? PlainBodyEncoding { get; set; }
    }
}