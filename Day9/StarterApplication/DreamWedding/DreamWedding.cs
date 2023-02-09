using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DreamWedding_Proj
{
    internal class DreamWedding
    {
        public bool ValidatePakage(String packageType)
        {
            if (packageType == "FSW" || packageType=="DW" || packageType == "D")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateEventList(String packageType,List<String> events)
        {
           if(packageType=="FSW" || packageType == "fsw")
            {
                if(events.Contains("wedding venues") && events.Contains("vendor management")&& events.Contains("wedding invites") && events.Contains("photography & videography")&& events.Contains("bridal styling"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           else if (packageType == "DW" || packageType == "dw")
            {
                if (events.Contains("wedding venues") && events.Contains("transportation") && events.Contains("bridal styling"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (packageType == "D" || packageType == "d")
            {
                if (events.Contains("floor design") && events.Contains("lighting design") && events.Contains("furniture linen"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           return false;

        }

        public bool ValidateEventCost(double eventCost)
        {
            if (eventCost < 5000)
            {
                Console.WriteLine("Low Cost Amount...Restart the Application");
                System.Environment.Exit(0);
                return false;
            }
            else
            {
                return true;
            }
        }

        public Dictionary<string, double> CreateWedding(string packageType, List<String> eventsCost)
        {
            Dictionary<string, double> ans = new Dictionary<string, double>();
            List<String> l=new List<String>();
            List<Double> d = new List<Double>();
            foreach(String item in eventsCost)
            {
                
                l.Add(item.Split(',')[0]);
                d.Add(double.Parse(item.Split(',')[1]));
                
            }

            bool IsMoney = false;
            foreach(double item in d)
            {
                if (ValidateEventCost(item) == true)
                {
                    IsMoney= true;
                }
            }
            
            if(IsMoney==true && ValidateEventList(packageType,l) == true)
            {
                String[] ss = new String[10];
                double[] dd = new double[10];

                l.CopyTo(ss);
                d.CopyTo(dd);

                for(int i = 0; i < 10; i++)
                {
                    if (ss[i]!=null)
                    ans.Add(ss[i], dd[i]);
                }
                
            }
            return ans;
            
        }

        public double GetTotalCost(Dictionary<String, double> wedding)
        {
            double totalCost = 0.0;
            foreach(KeyValuePair<String,double> item in wedding)
            {
                totalCost+= item.Value;
            }
            return totalCost;
        }



    }
}
