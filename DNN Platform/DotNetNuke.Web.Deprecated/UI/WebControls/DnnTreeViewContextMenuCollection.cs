﻿#region Copyright
// 
// DotNetNuke® - http://www.dotnetnuke.com
// Copyright (c) 2002-2017
// by DotNetNuke Corporation
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion
#region Usings

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

#endregion

namespace DotNetNuke.Web.UI.WebControls
{

    public sealed class DnnTreeViewContextMenuCollection : ICollection, IEnumerable, IStateManager
    {
        private IList<DnnTreeViewContextMenu> _list;
        public IEnumerator GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        public void CopyTo(Array array, int index)
        {
            _list.CopyTo(array.Cast<DnnTreeViewContextMenu>().ToArray(), index);
        }

        public int Count => _list.Count;

        public object SyncRoot  => ((ICollection) _list).SyncRoot;


        public bool IsSynchronized => ((ICollection)_list).IsSynchronized;

        public void LoadViewState(object state)
        {
            
        }

        public object SaveViewState()
        {
            return null;
        }

        public void TrackViewState()
        {

        }

        public bool IsTrackingViewState => false;
    }
}