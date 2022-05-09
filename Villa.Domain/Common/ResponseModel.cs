using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Domain.Common
{    public class ResponseModel
    {
        public ResponseModel()
        {
            Message = "Bir hata oluştu";
        }
        public ResponseModel(string Message)
        {
            this.Message = Message;
        }
        public ResponseModel(string Message, bool Success)
        {
            this.Message = Message;
            this.Success = Success;
        }
        public ResponseModel(bool Success)
        {
            this.Message = "";
            this.Success = Success;
        }
        public ResponseModel(string Message, bool Success, object Data)
        {
            this.Message = Message;
            this.Success = Success;
            this.Data = Data;
        }
        public ResponseModel(object Data)
        {
            this.Data = Data;
            this.Success = true;
        }
        public bool Success { get; set; } = false;
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
