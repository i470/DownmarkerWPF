﻿using System.ComponentModel;
using ICSharpCode.AvalonEdit.Document;
using MarkPad.Document.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarkPad.Document.Search
{
    public interface ISearchProvider
    {
        void Initialise(DocumentView documentView);

        void Disconnect();

        void DoSearch(SearchType searchType, bool selectSearch);

        IEnumerable<TextSegment> SearchHits { get; }

        int NumberOfHits { get; }

        int CurrentHitIndex { get; }
    }
}