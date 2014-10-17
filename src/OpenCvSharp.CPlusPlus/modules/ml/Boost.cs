﻿using System;

namespace OpenCvSharp.CPlusPlus.ML
{
#if LANG_JP
    /// <summary>
    /// 弱い決定木クラス
    /// </summary>
#else
	/// <summary>
    /// Weak tree classifier
    /// </summary>
#endif
	public class Boost : DTrees
	{
        /// <summary>
        /// Track whether Dispose has been called
        /// </summary>
        private bool disposed;
       
		#region Init and Disposal
#if LANG_JP
        /// <summary>
        /// 既定のコンストラクタ
        /// </summary>
#else
	    /// <summary>
	    /// Default constructor
	    /// </summary>
#endif
	    public Boost()
		{
		}

#if LANG_JP
        /// <summary>
        /// リソースの解放
        /// </summary>
        /// <param name="disposing">
        /// trueの場合は、このメソッドがユーザコードから直接が呼ばれたことを示す。マネージ・アンマネージ双方のリソースが解放される。
        /// falseの場合は、このメソッドはランタイムからファイナライザによって呼ばれ、もうほかのオブジェクトから参照されていないことを示す。アンマネージリソースのみ解放される。
        ///</param>
#else
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// If disposing equals true, the method has been called directly or indirectly by a user's code. Managed and unmanaged resources can be disposed.
        /// If false, the method has been called by the runtime from inside the finalizer and you should not reference other objects. Only unmanaged resources can be disposed.
        /// </param>
#endif
        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                try
                {
                    if (disposing)
                    {
                    }
                    if (IsEnabledDispose)
                    {
                    }
                    disposed = true;
                }
                finally
                {
                    base.Dispose(disposing);
                }
            }
        }
		#endregion

        #region Methods
		#endregion
	}
}