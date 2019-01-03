﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACHR.Common
{
    public class SboConsts
    {
        public const string BO_OBJECT_BP = "2";
        public const string BO_OBJECT_BP_GROUP = "10";
        public const string BO_OBJECT_CREDIT_NOTE = "14";
        public const string BO_OBJECT_DELIVERY_NOTE = "15";
        public const int BO_OBJECT_DELIVERY_NOTE_INT = 15;
        public const string BO_OBJECT_INVOICE = "13";
        public const string BO_OBJECT_ITEM = "4";
        public const string BO_OBJECT_PURCHASE_CREDIT_NOTE = "19";
        public const string BO_OBJECT_PURCHASE_DELIVERY_NOTE = "20";
        public const string BO_OBJECT_PURCHASE_INVOICE = "18";
        public const string BO_OBJECT_PURCHASE_ORDER = "22";
        public const string BO_OBJECT_PURCHASE_QUOTATION = "540000006";
        public const int BO_OBJECT_PURCHASE_QUOTATION_INT = 540000006;
        public const string BO_OBJECT_PURCHASE_RETURN = "21";
        public const string BO_OBJECT_RECEIPT_INVENTORY = "59";
        public const string BO_OBJECT_RETURN = "16";
        public const string BO_OBJECT_SALE_ORDER = "17";
        public const int BO_OBJECT_SALE_ORDER_INT = 17;
        public const string BPFORM_ITEM_CARDCODE = "5";
        public const int CELL_SPECIFIC_BASEENTRY = 55;
        public const int CELL_SPECIFIC_BASELINE = 56;
        public const int CELL_SPECIFIC_BASETYPE = 53;
        public const int CELL_SPECIFIC_BP_ITEMCODE = 4;
        public const int CELL_SPECIFIC_DISCOUNT_PRC = 21;
        public const int CELL_SPECIFIC_GLACCOUNT = 37;
        public const int CELL_SPECIFIC_ITEMCODE = 3;
        public const int CELL_SPECIFIC_LINESTATUS = 50;
        public const int CELL_SPECIFIC_LINETYPE = 1;
        public const int CELL_SPECIFIC_PRICE = 20;
        public const int CELL_SPECIFIC_PRICE_AFTER_DISCOUNT = 23;
        public const int CELL_SPECIFIC_QUANTITY = 13;
        public const int CELL_SPECIFIC_RATE = 22;
        public const int CELL_SPECIFIC_WHSCODE = 32;
        public const int CELL_SPECIFIC_WITHOUT_QTY_POSTING = 316;
        public const int COLOR_GREEN = 4089662;
        public const int COLOR_RED = 9662683;
        public const int COLOR_YELLOW = 65535;
        public const string DEBUG_CONNECTION_STRING = "0030002C0030002C00530041005000420044005F00440061007400650076002C0050004C006F006D0056004900490056";
        public const string FORM_BOM = "672";
        public const string FORM_BP = "134";
        public const string FORM_BP_GROUP = "174";
        public const string FORM_CREDIT_MEMO = "179";
        public const string FORM_DELIVERY_NOTE = "140";
        public const string FORM_DISCOUNT_GROUP = "958";
        public const string FORM_DRAFT = "112";
        public const string FORM_FREIGHT_CHARGES = "3007";
        public const string FORM_INVENTORY_IN = "721";
        public const string FORM_INVENTORY_OUT = "720";
        public const string FORM_INVENTORY_TRANSFER = "940";
        public const string FORM_INVENTORY_TRANSFER_REQUEST = "1250000940";
        public const string FORM_INVOICE = "133";
        public const string FORM_ITEM = "150";
        public const string FORM_MAIN_MENU = "169";
        public const string FORM_PRODUCTION_ORDER = "65211";
        public const string FORM_PURCHASE_CREDIT_NOTE = "181";
        public const string FORM_PURCHASE_DELIVERY_NOTE = "143";
        public const string FORM_PURCHASE_INVOICE = "141";
        public const string FORM_PURCHASE_ORDER = "142";
        public const string FORM_PURCHASE_QUOTATION = "540000988";
        public const string FORM_PURCHASE_RETURN = "182";
        public const string FORM_RECEIPT_PO = "65214";
        public const string FORM_REPORT_ACCOUNTING_901 = "901";
        public const string FORM_REPORT_ACCOUNTING_960 = "960";
        public const string FORM_RETURN = "180";
        public const string FORM_SALE_QUOTATION = "149";
        public const string FORM_SALES_ORDER = "139";
        public const string FORM_SERVICE_CALL = "60110";
        public const string FORM_UDF_BOM = "-672";
        public const string FORM_UDF_BP = "-134";
        public const string FORM_UDF_CREDIT_MEMO = "-179";
        public const string FORM_UDF_DELIVERY_NOTE = "-140";
        public const string FORM_UDF_INVOICE = "-133";
        public const string FORM_UDF_ITEM = "-150";
        public const string FORM_UDF_PRODUCTION_ORDER = "-65211";
        public const string FORM_UDF_PURCHASE_CREDIT_NOTE = "-181";
        public const string FORM_UDF_PURCHASE_DELIVERY_NOTE = "-143";
        public const string FORM_UDF_PURCHASE_INVOICE = "-141";
        public const string FORM_UDF_PURCHASE_ORDER = "-142";
        public const string FORM_UDF_PURCHASE_RETURN = "-182";
        public const string FORM_UDF_RECEIPT_PO = "-65214";
        public const string FORM_UDF_RETURN = "-180";
        public const string FORM_UDF_SALE_ORDER = "-139";
        public const string FORM_WAREHOUSE_SETUP = "62";
        public const string FORM_WAREHOUSE_TRANSFER = "940";
        public const string INVENTORY_TRANSFER_CARDCODE = "3";
        public const string INVENTORY_TRANSFER_CARDNAME = "7";
        public const string INVENTORY_TRANSFER_CONTACT_PERSON = "31";
        public const string INVENTORY_TRANSFER_DOC_DATE = "14";
        public const string INVENTORY_TRANSFER_DOC_DUE_DATE = "1250000072";
        public const string INVENTORY_TRANSFER_DOC_STATUS = "1250000070";
        public const string INVENTORY_TRANSFER_DOCNUM = "11";
        public const string INVENTORY_TRANSFER_MATRIX_ATTACHMENTS = "1320000096";
        public const string INVENTORY_TRANSFER_MATRIX_CONTENTS = "23";
        public const string INVENTORY_TRANSFER_REMARKS = "41";
        public const string INVENTORY_TRANSFER_SHIP_TO = "9";
        public const string MENU_ITEM_BASE_DOCUMENT = "5898";
        public const string MENU_ITEM_DATA = "1280";
        public const string MENU_ITEM_DUPLICATE = "1287";
        public const string MENU_ITEM_FIND_RECORD = "1281";
        public const string MENU_ITEM_FLD_BUSINESS_PARTNERS = "43535";
        public const string MENU_ITEM_FLD_INVENTORY = "3072";
        public const string MENU_ITEM_FLD_PRICELISTS = "43541";
        public const string MENU_ITEM_FLD_PRODUCTION = "4352";
        public const string MENU_ITEM_FLD_PURCHASES_AP = "2304";
        public const string MENU_ITEM_FLD_REPORTS = "43545";
        public const string MENU_ITEM_FLD_SALES_AR = "2048";
        public const string MENU_ITEM_FLD_SERVICE = "3584";
        public const string MENU_ITEM_IMPORT_DATA = "8960";
        public const string MENU_ITEM_INVENTORY_ITEMMANAGMENT = "15872";
        public const string MENU_ITEM_NEW_RECORD = "1282";
        public const string MENU_ITEM_NEXT_RECORD = "1288";
        public const string MENU_ITEM_PREVIOUS_RECORD = "1289";
        public const string MENU_ITEM_PRODUCTION_ORDER = "4369";
        public const string MENU_ITEM_PURCHASE_ORDER = "2305";
        public const string MENU_ITEM_REPORT_COMPLETION = "5922";
        public const string MENU_ITEM_SALES_ORDER = "2050";
        public const string MENU_ITEM_SAVE_AS_DRAFT = "5907";
        public const string MENU_ITEM_UDF = "6913";
        public const string SALESFORM_COL_ACCOUNT_FOC = "210000336";
        public const string SALESFORM_COL_ACCOUNTCODE = "29";
        public const string SALESFORM_COL_DISCOUNT_PERCENTAGE = "24";
        public const string SALESFORM_COL_ITEMCODE = "1";
        public const string SALESFORM_COL_ITEMNAME = "3";
        public const string SALESFORM_COL_MTX_ATT_PATH = "1320000003";
        public const string SALESFORM_COL_NUMPERMSR = "213";
        public const string SALESFORM_COL_OPEN_QUANTITY = "32";
        public const string SALESFORM_COL_PRICE = "14";
        public const string SALESFORM_COL_QUANTITY = "11";
        public const string SALESFORM_COL_TYPE = "257";
        public const string SALESFORM_COL_UDF_COMPANY = "U_Company";
        public const string SALESFORM_ITEM_CARDCODE = "4";
        public const string SALESFORM_ITEM_CARDNAME = "54";
        public const string SALESFORM_ITEM_COMMENTS = "16";
        public const string SALESFORM_ITEM_DOC_STATUS = "81";
        public const string SALESFORM_ITEM_DOC_TOTAL = "29";
        public const string SALESFORM_ITEM_DOC_TYPE = "3";
        public const string SALESFORM_ITEM_DOCDATE = "10";
        public const string SALESFORM_ITEM_DOCDUEDATE = "12";
        public const string SALESFORM_ITEM_DOCNUM = "8";
        public const string SALESFORM_ITEM_DOCTOTAL_AFTER_DISCOUNT_TAX_FREIGHT = "29";
        public const string SALESFORM_ITEM_DOCTOTAL_BEFORE_DISCOUNT_TAX_FREIGHT = "22";
        public const string SALESFORM_ITEM_MATRIX = "38";
        public const string SALESFORM_ITEM_MATRIX_ATTACHMENTS = "1320002138";
        public const string SALESFORM_ITEM_MATRIX_SERVICE = "39";
        public const string SALESFORM_ITEM_NUMATCARD = "14";
        public const string SALESFORM_ITEM_REQ_DATE = "540002106";
        public const string SALESFORM_ITEM_SERIES = "88";
        public const string SALESFORM_ITEM_TAXDATE = "46";

        public SboConsts();
    }
}