using System;
using System.Collections.Generic;
using System.Linq;

namespace TraderaAcronymBingo.Models
{
    public static class Acronyms
    {
        public static readonly IList<Acronym> All = new List<Acronym>
        {
            new Acronym("API", "Application Programming Interface. In the Tradera-specific case the API available on https://api.tradera.com"),
            new Acronym("ASP", "Average Sales Price"),
            new Acronym("ATO", "Account Takeover. En bedragare som kapar en annan användares konto"),
            new Acronym("BBE", "Bad Buyer Experience, jämförs oftast mot antalet sålda varor (xBBE)"),
            new Acronym("BIN", "Buy It Now. Fixed price option for a listing."),
            new Acronym("BLP", "Browsing List Page."),
            new Acronym("CR", "Conversion Rate."),
            new Acronym("CRP", "Custom Result Page"),
            new Acronym("CRU", "Confirmed Registered User."),
            new Acronym("CS", "Customer Support."),
            new Acronym("CSA", "Clothes, Shoes and Accessories."),
            new Acronym("DW", "A database used for analysis where we store all historical data "),
            new Acronym("DBR", "Detailed Buyer Rating. Sellers can grade the payment performance of the buyer on a scale from 1-5."),
            new Acronym("DSR", "Detailed Seller Rating. Buyers can grade 4 aspects of the transaction on a scale from 1-5. Used to calc DSR average."),
            new Acronym("ftgnr", "MemberId. The primary key of the member."),
            new Acronym("GMB", "Gross Merchandise Bought. The total value of goods bought."),
            new Acronym("GMV", "Gross Merchandise Value. The total value of goods sold."),
            new Acronym("GÅNO", "Gemensamt Återkallande av Negativt Omdöme. The process where a Buyer and Seller agree to recall negative Feedback on each other."),
            new Acronym("INR", "Item Not Received - Ett köp som är betalt men där varan inte kommit fram"),
            new Acronym("MH", "Musikhjälpen"),
            new Acronym("NPS", "Net Promoter Score. Metric measured in monthly poll."),
            new Acronym("PPW", "Purchases per visit per week."),
            new Acronym("SEM", "Search Engine Marketing (paid search)."),
            new Acronym("SEO", "Search Engine Optimization."),
            new Acronym("SNAD", "Significantly Not As Described - Ett köp där varan vid leverans inte stämmer överens med beskrivningen"),
            new Acronym("SRP", "Search Result Page."),
            new Acronym("SYI", "Sell Your Item. Site flow to create listings."),
            new Acronym("TnS", "Trust and Safety - Safety-teamet"),
            new Acronym("TP", "Teleperformance. Outsourced customer support."),
            new Acronym("UPI", "Unpaid Item - En försäljning som säljaren inte fått betalt för"),
            new Acronym("UxBBE", "Unique Transactional Bad Buyer Experience. Measurement used to identify bad transactions and sellers."),
            new Acronym("VeRO", "Verified Rights Owner. Program for copyright/trademark owners."),
            new Acronym("VIP", "View Item Page. The page showing a listing.")
        };

        public static IList<T> Randomize<T>(this IList<T> source)
        {
            var rnd = new Random();
            return source.OrderBy(item => rnd.Next()).ToList();
        }
    }
}
