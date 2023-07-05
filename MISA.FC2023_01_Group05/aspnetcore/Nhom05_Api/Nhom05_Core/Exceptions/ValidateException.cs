using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom05_Core.Exceptions
{
    /// <summary>
    /// Exception đại diện cho lỗi nhập liệu người dùng
    /// </summary>
    /// Created By: BNTIEN (05/07/2023)
    public class ValidateException : Exception
    {
        #region Property
        /// <summary>
        /// Mã lỗi
        /// </summary>
        public int ErrorCode { get; set; }
        /// <summary>
        /// Thông tin lỗi
        /// </summary>
        public string? ErrorMessage { get; set; }
        public Object? Data { get; set; }
        #endregion

        #region Constructor
        public ValidateException() { }
        public ValidateException(int errorCode, string? errors, object? data)
        {
            ErrorCode = errorCode;
            ErrorMessage = errors;
            Data = data;
        }
        #endregion
    }
}
