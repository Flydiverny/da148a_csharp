using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(new Program().GenerateHTMLRecurrence(7));
            Console.ReadLine();
        }

        public String GenerateHTMLRecurrence(int weeks)
        {
            var recurr = weeks * 7;
            var counter = 0;
            var sb = new StringBuilder();

            var days = new[] { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };

            sb.AppendFormat("<div id=\"recurrOpt{0}\" class=\"schedSection\" data-bind=\"visible: ShowRecurrOpt{0}\">", recurr);

            for (var w = 1; w <= weeks; w++)
            {
                sb.AppendFormat("<div id=\"dayGroup_{0}_{1}\" class=\"day_group\">", recurr, w);

                foreach (var day in days)
                {
                    sb.AppendFormat("<div data-bind=\"attr: {{ 'class': $data.cssClass}}\" class=\"day day_{0}_{1} input-group\">", recurr, w)
                    .AppendFormat("<span class=\"input-group-addon input-sm {0}\"></span>", day)
                    .AppendFormat("<span class=\"input-group-addon input-sm\">")
                    .AppendFormat("<input type=\"checkbox\" data-bind=\"checked: ScheduleMask[{0}]\">", counter++)
                    .Append("</span>")
                    .Append("</div>");
                }
            }

            return sb.ToString();
        }

        /*
         
         
            
            <div data-bind="attr: { 'class': $data.cssClass }" class="day day_7_1">
                <label class="tuesday checkbox-inline">tue</label>
                <input type="checkbox" data-bind="checked: ScheduleMask[1]"></div>
            <div data-bind="attr: { 'class': $data.cssClass }" class="day day_7_1">
                <label class="wednesday checkbox-inline">wed</label>
                <input type="checkbox" data-bind="checked: ScheduleMask[2]"></div>
            <div data-bind="attr: { 'class': $data.cssClass }" class="day day_7_1">
                <label class="thursday checkbox-inline">thur</label>
                <input type="checkbox" data-bind="checked: ScheduleMask[3]"></div>
            <div data-bind="attr: { 'class': $data.cssClass }" class="day day_7_1">
                <label class="friday checkbox-inline">fri</label>
                <input type="checkbox" data-bind="checked: ScheduleMask[4]"></div>
            <div data-bind="attr: { 'class': $data.cssClass }" class="day day_7_1">
                <label class="saturday checkbox-inline">sat</label>
                <input type="checkbox" data-bind="checked: ScheduleMask[5]"></div>
            <div data-bind="attr: { 'class': $data.cssClass }" class="day day_7_1">
                <label class="sunday checkbox-inline">sun</label>
                <input type="checkbox" data-bind="checked: ScheduleMask[6]"></div>
        </div>
         
         
         
         
         */
    }
}
