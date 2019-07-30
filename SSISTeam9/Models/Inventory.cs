using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSISTeam9.Models
{
    public class Inventory
    {
        private long itemId;
        private string itemCode;
        private string binNo;
        private int stockLevel;
        private int reorderLevel;
        private int reorderQty;
        private string category;
        private string description;
        private string unitOfMeasure;
        private string imageUrl;

        public long ItemId
        {
            get { return itemId; }
        }

        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        public string BinNo
        {
            get { return binNo; }
            set { binNo = value; }
        }

        public int StockLevel
        {
            get { return stockLevel; }
            set { stockLevel = value; }
        }

        public int ReorderLevel
        {
            get { return reorderLevel; }
            set { reorderLevel = value; }
        }

        public int ReorderQty
        {
            get { return reorderQty; }
            set { reorderQty = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string UnitOfMeasure
        {
            get { return unitOfMeasure; }
            set { unitOfMeasure = value; }
        }

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }
    }
}