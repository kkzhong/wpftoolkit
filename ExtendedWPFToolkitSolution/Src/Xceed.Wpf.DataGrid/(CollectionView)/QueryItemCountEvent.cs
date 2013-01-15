﻿/************************************************************************

   Extended WPF Toolkit

   Copyright (C) 2010-2012 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   This program can be provided to you by Xceed Software Inc. under a
   proprietary commercial license agreement for use in non-Open Source
   projects. The commercial version of Extended WPF Toolkit also includes
   priority technical support, commercial updates, and many additional 
   useful WPF controls if you license Xceed Business Suite for WPF.

   Visit http://xceed.com and follow @datagrid on Twitter.

  **********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Collections.ObjectModel;

namespace Xceed.Wpf.DataGrid
{
  public class QueryItemCountEventArgs : EventArgs
  {
    #region CONSTRUCTORS

    internal QueryItemCountEventArgs( DataGridVirtualizingCollectionView collectionView, 
      DataGridVirtualizingCollectionViewGroup collectionViewGroup )
    {
      m_dataGridVirtualizingCollectionView = collectionView;
      m_readonlyGroupPath = collectionViewGroup.GroupPath.AsReadOnly();

      m_count = -1;
    }

    #endregion CONSTRUCTORS

    #region CollectionView PROPERTY

    public DataGridVirtualizingCollectionView CollectionView
    {
      get
      {
        return m_dataGridVirtualizingCollectionView;
      }
    }

    #endregion CollectionView PROPERTY

    #region GroupPath PROPERTY

    public ReadOnlyCollection<DataGridGroupInfo> GroupPath
    {
      get
      {
        return m_readonlyGroupPath;
      }
    }

    #endregion GroupPath PROPERTY

    #region Count PROPERTY

    public int Count
    {
      get
      {
        return m_count;
      }
      set
      {
        m_count = value;
      }
    }

    #endregion Count PROPERTY

    #region PRIVATE FIELDS

    private DataGridVirtualizingCollectionView m_dataGridVirtualizingCollectionView;
    private ReadOnlyCollection<DataGridGroupInfo> m_readonlyGroupPath;

    private int m_count;

    #endregion PRIVATE FIELDS
  }
}