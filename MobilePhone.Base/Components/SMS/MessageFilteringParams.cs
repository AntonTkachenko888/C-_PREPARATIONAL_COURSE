using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.SMS
{
    public class MessageFilteringParams
    {
        public string SelectedUser { get; set; } = "";
        public SortOptions UsersSortOptions { get; set; } = SortOptions.AND;
        public string MessageText { get; set; } = "";
        public SortOptions MessageTextSortOptions { get; set; } = SortOptions.AND;
        public DateTime FromDate { get; set; } = DateTime.MinValue;
        public DateTime BeforeDate { get; set; } = DateTime.MaxValue;
        public string FormattingOptions { get; set; } = "None";
    }
}
