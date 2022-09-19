using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class PaginationData
    {
        public object? data { get; set; }
        public Int32? CurrentPage { get; set; }
        public Int32? TotalPage { get; set; }
        public Int32? Count { get; set; }

    }
}