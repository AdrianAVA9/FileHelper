using FileHelper.AppException;
using FileHelper.Entities;
using FileHelper.Enums;

namespace FileHelper
{
    public class FileHelperActionResult
    {
        public FileHelperActionStatus Status { get; set; }
        public FileHelperException Exception { get; set; }
        public FileInfo FileInfo { get; set; }

        public FileHelperActionResult(FileHelperActionStatus status, FileInfo fileInfo) : this(status, fileInfo, null)
        {
        }

        public FileHelperActionResult(FileHelperActionStatus status, FileHelperException exception) : this(status, null, exception)
        {
        }

        public FileHelperActionResult(FileHelperActionStatus status, FileInfo fileInfo, FileHelperException exception)
        {
            Status = status;
            Exception = exception;
            FileInfo = fileInfo;
        }
    }
}
