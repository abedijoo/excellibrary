using System;
using System.Collections.Generic;
using System.Text;

namespace QiHe.Office.Excel
{
    public class RecordType
    {
        //public const UInt16 DIMENSIONS = 0x0000; //BIFF2
        //public const UInt16 BLANK = 0x0001; //BIFF2
        public const UInt16 INTEGER = 0x0002;
        //public const UInt16 NUMBER = 0x0003; //BIFF2
        //public const UInt16 LABEL = 0x0004; //BIFF2
        //public const UInt16 BOOLERR = 0x0005; //BIFF2
        public const UInt16 FORMULA = 0x0006;
        //public const UInt16 STRING = 0x0007; //BIFF2
        //public const UInt16 ROW = 0x0008; //BIFF2
        //public const UInt16 BOF = 0x0009; //BIFF2
        public const UInt16 EOF = 0x000A;
        //public const UInt16 INDEX = 0x000B; //BIFF2
        public const UInt16 CALCCOUNT = 0x000C;
        public const UInt16 CALCMODE = 0x000D;
        public const UInt16 PRECISION = 0x000E;
        public const UInt16 REFMODE = 0x000F;
        public const UInt16 DELTA = 0x0010;
        public const UInt16 ITERATION = 0x0011;
        public const UInt16 PROTECT = 0x0012;
        public const UInt16 PASSWORD = 0x0013;
        public const UInt16 HEADER = 0x0014;
        public const UInt16 FOOTER = 0x0015;
        public const UInt16 EXTERNCOUNT = 0x0016;
        public const UInt16 EXTERNSHEET = 0x0017;
        public const UInt16 NAME = 0x0018;
        public const UInt16 WINDOWPROTECT = 0x0019;
        public const UInt16 VERTICALPAGEBREAKS = 0x001A;
        public const UInt16 HORIZONTALPAGEBREAKS = 0x001B;
        public const UInt16 NOTE = 0x001C;
        public const UInt16 SELECTION = 0x001D;
        //public const UInt16 FORMAT = 0x001E; //BIFF2 BIFF3
        //public const UInt16 BUILTINFMTCOUNT = 0x001F; //Deleted in BIFF5/BIFF7
        public const UInt16 COLUMNDEFAULT = 0x0020;
        //public const UInt16 ARRAY = 0x0021; //BIFF2
        public const UInt16 DATEMODE = 0x0022;
        public const UInt16 EXTERNNAME = 0x0023;
        public const UInt16 COLWIDTH = 0x0024;
        //public const UInt16 DEFAULTROWHEIGHT = 0x0025; //BIFF2
        public const UInt16 LEFTMARGIN = 0x0026;
        public const UInt16 RIGHTMARGIN = 0x0027;
        public const UInt16 TOPMARGIN = 0x0028;
        public const UInt16 BOTTOMMARGIN = 0x0029;
        public const UInt16 PRINTHEADERS = 0x002A;
        public const UInt16 PRINTGRIDLINES = 0x002B;
        public const UInt16 FILEPASS = 0x002F;
        public const UInt16 FONT = 0x0031;
        public const UInt16 PRINTSIZE = 0x0033;
        public const UInt16 INFOOPTS = 0x0035;
        //public const UInt16 TABLEOP = 0x0036; //BIFF2
        public const UInt16 TABLEOP2 = 0x0037;
        public const UInt16 WNDESK = 0x0038;
        public const UInt16 BEGINPREF = 0x003A;
        public const UInt16 ENDPREF = 0x003B;
        public const UInt16 CONTINUE = 0x003C;
        public const UInt16 WINDOW1 = 0x003D;
        //public const UInt16 WINDOW2 = 0x003E; //BIFF2
        public const UInt16 BACKUP = 0x0040;
        public const UInt16 PANE = 0x0041;
        public const UInt16 CODEPAGE = 0x0042;
        //public const UInt16 XF = 0x0043; //BIFF2
        public const UInt16 IXFE = 0x0044;
        public const UInt16 EFONT = 0x0045;
        public const UInt16 SHOWSCROLL = 0x0046;
        public const UInt16 SHOWFORMULA = 0x0047;
        public const UInt16 STATUSBAR = 0x0048;
        public const UInt16 SHORTMENUS = 0x0049;
        public const UInt16 DDEENABLED = 0x004A;
        public const UInt16 AUTODEC = 0x004B;
        public const UInt16 MENUKEY = 0x004C;
        public const UInt16 PLS_ZOOM = 0x004D;
        public const UInt16 MENUUND = 0x004E;
        public const UInt16 MOVESEL = 0x004F;
        public const UInt16 DCON = 0x0050;
        public const UInt16 DCONREF = 0x0051;
        public const UInt16 DCONNAME = 0x0052;
        public const UInt16 DEFCOLWIDTH = 0x0055;
        //public const UInt16 BUILTINFMTCOUNT = 0x0056; //Deleted in BIFF5/BIFF7
        public const UInt16 TOOLBAR = 0x0058;
        public const UInt16 XCT = 0x0059;
        public const UInt16 CRN = 0x005A;
        public const UInt16 FILESHARING = 0x005B;
        public const UInt16 WRITEACCESS = 0x005C;
        public const UInt16 OBJ = 0x005D;
        public const UInt16 UNCALCED = 0x005E;
        public const UInt16 SAVERECALC = 0x005F;
        public const UInt16 TEMPLATE = 0x0060;
        public const UInt16 OBJECTPROTECT = 0x0063;
        public const UInt16 COLINFO = 0x007D;
        //public const UInt16 RK = 0x007E;
        public const UInt16 IMDATA = 0x007F;
        public const UInt16 GUTS = 0x0080;
        public const UInt16 WSBOOL = 0x0081;
        public const UInt16 GRIDSET = 0x0082;
        public const UInt16 HCENTER = 0x0083;
        public const UInt16 VCENTER = 0x0084;
        public const UInt16 BOUNDSHEET = 0x0085;
        public const UInt16 WRITEPROT = 0x0086;
        public const UInt16 ADDIN = 0x0087;
        public const UInt16 EDG = 0x0088;
        public const UInt16 PUB = 0x0089;
        public const UInt16 NOTEOFF = 0x008A;
        public const UInt16 LH = 0x008B;
        public const UInt16 COUNTRY = 0x008C;
        public const UInt16 HIDEOBJ = 0x008D;
        public const UInt16 SHEETSOFFSET = 0x008E;
        public const UInt16 SHEETHDR = 0x008F;
        public const UInt16 SORT = 0x0090;
        public const UInt16 SUB = 0x0091;
        public const UInt16 PALETTE = 0x0092;
        //public const UInt16 STYLE = 0x0093;
        public const UInt16 LHRECORD = 0x0094;
        public const UInt16 LHNGRAPH = 0x0095;
        public const UInt16 SOUND = 0x0096;
        public const UInt16 LPR = 0x0098;
        public const UInt16 STANDARDWIDTH = 0x0099;
        public const UInt16 FNGROUPNAME = 0x009A;
        public const UInt16 FILTERMODE = 0x009B;
        public const UInt16 FNGROUPCOUNT = 0x009C;
        public const UInt16 AUTOFILTERINFO = 0x009D;
        public const UInt16 AUTOFILTER = 0x009E;
        public const UInt16 SCL = 0x00A0;
        public const UInt16 SETUP = 0x00A1;
        public const UInt16 PROJEXTSHEET = 0x00A3;
        public const UInt16 DRAGDROP = 0x00A8;
        public const UInt16 COORDLIST = 0x00A9;
        public const UInt16 GCW = 0x00AB;
        public const UInt16 SCENMAN = 0x00AE;
        public const UInt16 SCENARIO = 0x00AF;
        public const UInt16 SXVIEW = 0x00B0;
        public const UInt16 SXVD = 0x00B1;
        public const UInt16 SXVI = 0x00B2;
        public const UInt16 SXIVD = 0x00B4;
        public const UInt16 SXLI = 0x00B5;
        public const UInt16 SXPI = 0x00B6;
        public const UInt16 DOCROUTE = 0x00B8;
        public const UInt16 RECIPNAME = 0x00B9;
        //public const UInt16 SHRFMLA = 0x00BC;
        public const UInt16 MULRK = 0x00BD;
        public const UInt16 MULBLANK = 0x00BE;
        public const UInt16 MMS = 0x00C1;
        public const UInt16 ADDMENU = 0x00C2;
        public const UInt16 DELMENU = 0x00C3;
        public const UInt16 SXDI = 0x00C5;
        public const UInt16 SXDB = 0x00C6;
        public const UInt16 SXFIELD = 0x00C7;
        public const UInt16 SXINDEXLIST = 0x00C8;
        public const UInt16 SXDOUBLE = 0x00C9;
        public const UInt16 SXBOOLEAN = 0x00CA;
        public const UInt16 SXERROR = 0x00CB;
        public const UInt16 SXINTEGER = 0x00CC;
        public const UInt16 SXSTRING = 0x00CD;
        public const UInt16 SXDATETIME = 0x00CE;
        public const UInt16 SXEMPTY = 0x00CF;
        public const UInt16 SXTBL = 0x00D0;
        public const UInt16 SXTBRGITEM = 0x00D1;
        public const UInt16 SXTBPG = 0x00D2;
        public const UInt16 OBPROJ = 0x00D3;
        public const UInt16 SXIDSTM = 0x00D5;
        public const UInt16 RSTRING = 0x00D6;
        public const UInt16 DBCELL = 0x00D7;
        public const UInt16 SXNUMGROUP = 0x00D8;
        public const UInt16 SXGROUPINFO = 0x00D9;
        public const UInt16 BOOKBOOL = 0x00DA;
        public const UInt16 REVERT = 0x00DB;
        public const UInt16 SXEXT_PARAMQRY = 0x00DC;
        public const UInt16 SCENPROTECT = 0x00DD;
        public const UInt16 OLESIZE = 0x00DE;
        public const UInt16 UDDESC = 0x00DF;
        public const UInt16 XF = 0x00E0;
        public const UInt16 INTERFACEHDR = 0x00E1;
        public const UInt16 INTERFACEEND = 0x00E2;
        public const UInt16 SXVS = 0x00E3;
        public const UInt16 MERGEDCELLS = 0x00E5;
        public const UInt16 BITMAP = 0x00E9;
        public const UInt16 MSODRAWINGGROUP = 0x00EB;
        public const UInt16 MSODRAWING = 0x00EC;
        public const UInt16 MSODRAWINGSELECTION = 0x00ED;
        public const UInt16 PHONETIC = 0x00EF;
        public const UInt16 SXRULE = 0x00F0;
        public const UInt16 SXEX = 0x00F1;
        public const UInt16 SXFILT = 0x00F2;
        public const UInt16 SXNAME = 0x00F6;
        public const UInt16 SXSELECT = 0x00F7;
        public const UInt16 SXPAIR = 0x00F8;
        public const UInt16 SXFMLA = 0x00F9;
        public const UInt16 SXFORMAT = 0x00FB;
        public const UInt16 SST = 0x00FC;
        public const UInt16 LABELSST = 0x00FD;
        public const UInt16 EXTSST = 0x00FF;
        public const UInt16 SXVDEX = 0x0100;
        public const UInt16 SXFORMULA = 0x0103;
        public const UInt16 SXDBEX = 0x0122;
        public const UInt16 CHTRINSERT = 0x0137;
        public const UInt16 CHTRINFO = 0x0138;
        public const UInt16 CHTRCELLCONTENT = 0x013B;
        public const UInt16 TABID = 0x013D;
        public const UInt16 CHTRMOVERANGE = 0x0140;
        public const UInt16 CHTRINSERTTAB = 0x014D;
        public const UInt16 LABELRANGES = 0x015F;
        public const UInt16 USESELFS = 0x0160;
        public const UInt16 DSF = 0x0161;
        public const UInt16 XL5MODIFY = 0x0162;
        public const UInt16 CHTRHEADER = 0x0196;
        public const UInt16 USERBVIEW = 0x01A9;
        public const UInt16 USERSVIEWBEGIN = 0x01AA;
        public const UInt16 USERSVIEWEND = 0x01AB;
        public const UInt16 QSI = 0x01AD;
        public const UInt16 SUPBOOK = 0x01AE;
        public const UInt16 CONDFMT = 0x01B0;
        public const UInt16 CF = 0x01B1;
        public const UInt16 DVAL = 0x01B2;
        public const UInt16 DCONBIN = 0x01B5;
        public const UInt16 TXO = 0x01B6;
        public const UInt16 REFRESHALL = 0x01B7;
        public const UInt16 HLINK = 0x01B8;
        public const UInt16 CODENAME = 0x01BA;
        public const UInt16 SXFDBTYPE = 0x01BB;
        public const UInt16 PROT4REVPASS = 0x01BC;
        public const UInt16 DV = 0x01BE;
        public const UInt16 DIMENSIONS = 0x0200;
        public const UInt16 BLANK = 0x0201;
        public const UInt16 NUMBER = 0x0203;
        public const UInt16 LABEL = 0x0204;
        public const UInt16 BOOLERR = 0x0205;
        //public const UInt16 FORMULA = 0x0206; //BIFF3
        public const UInt16 STRING = 0x0207;
        public const UInt16 ROW = 0x0208;
        //public const UInt16 BOF = 0x0209; //BIFF3
        public const UInt16 INDEX = 0x020B;
        //public const UInt16 NAME = 0x0218; //BIFF3 BIFF4S BIFF4W
        public const UInt16 ARRAY = 0x0221;
        //public const UInt16 EXTERNNAME = 0x0223; //BIFF3 BIFF4S BIFF4W
        public const UInt16 DEFAULTROWHEIGHT = 0x0225;
        //public const UInt16 FONT = 0x0231; //BIFF3 BIFF4S BIFF4W
        public const UInt16 TABLEOP = 0x0236;
        public const UInt16 WINDOW2 = 0x023E;
        //public const UInt16 XF = 0x0243; //BIFF3
        public const UInt16 RK = 0x027E;
        public const UInt16 STYLE = 0x0293;
        //public const UInt16 FORMULA = 0x0406; //BIFF4S BIFF4W
        //public const UInt16 BOF = 0x0409; //BIFF4S BIFF4W
        public const UInt16 FORMAT = 0x041E;
        //public const UInt16 XF = 0x0443; //BIFF4S BIFF4W
        public const UInt16 SHRFMLA = 0x04BC;
        public const UInt16 QUICKTIP = 0x0800;
        public const UInt16 WEBQRYSETTINGS = 0x0803;
        public const UInt16 WEBQRYTABLES = 0x0804;
        public const UInt16 BOF = 0x0809; //BIFF5 BIFF7 BIFF8 BIFF8X
        public const UInt16 SHEETLAYOUT = 0x0862;
        public const UInt16 SHEETPROTECTION = 0x0867;
        public const UInt16 RANGEPROTECTION = 0x0868;
        public const UInt16 CHUNITS = 0x1001;
        public const UInt16 CHCHART = 0x1002;
        public const UInt16 CHSERIES = 0x1003;
        //public const UInt16 CHSOURCELINK = 0x1004;
        public const UInt16 CHDATAFORMAT = 0x1006;
        public const UInt16 CHLINEFORMAT = 0x1007;
        public const UInt16 CHMARKERFORMAT = 0x1009;
        public const UInt16 CHAREAFORMAT = 0x100A;
        public const UInt16 CHPIEFORMAT = 0x100B;
        public const UInt16 CHATTACHEDLABEL = 0x100C;
        public const UInt16 CHSTRING = 0x100D;
        public const UInt16 CHCHARTFORMAT = 0x1014;
        public const UInt16 CHLEGEND = 0x1015;
        public const UInt16 CHSERIESLIST = 0x1016;
        public const UInt16 CHBAR = 0x1017;
        public const UInt16 CHLINE = 0x1018;
        public const UInt16 CHPIE = 0x1019;
        public const UInt16 CHAREA = 0x101A;
        public const UInt16 CHSCATTER = 0x101B;
        public const UInt16 CHCHARTLINE = 0x101C;
        public const UInt16 CHAXIS = 0x101D;
        public const UInt16 CHTICK = 0x101E;
        public const UInt16 CHVALUERANGE = 0x101F;
        public const UInt16 CHLABELRANGE = 0x1020;
        public const UInt16 CHAXISLINE = 0x1021;
        public const UInt16 CHFORMATLINK = 0x1022;
        public const UInt16 CHDEFAULTTEXT = 0x1024;
        public const UInt16 CHTEXT = 0x1025;
        public const UInt16 CHFONT = 0x1026;
        public const UInt16 CHOBJECTLINK = 0x1027;
        public const UInt16 CHARROW = 0x102D;
        public const UInt16 CHARROWHEAD = 0x102F;
        public const UInt16 CHFRAME = 0x1032;
        public const UInt16 CHBEGIN = 0x1033;
        public const UInt16 CHEND = 0x1034;
        public const UInt16 CHPLOTAREA = 0x1035;
        public const UInt16 CHCHARTSIZE = 0x1036;
        public const UInt16 CHRELPOSITION = 0x1037;
        public const UInt16 CHARROWRELPOS = 0x1038;
        public const UInt16 CHCHART3D = 0x103A;
        public const UInt16 CHMULTILINK = 0x103B;
        public const UInt16 CHPICFORMAT = 0x103C;
        public const UInt16 CHDROPBAR = 0x103D;
        public const UInt16 CHRADARLINE = 0x103E;
        public const UInt16 CHSURFACE = 0x103F;
        public const UInt16 CHRADARAREA = 0x1040;
        public const UInt16 CHAXESSET = 0x1041;
        public const UInt16 CHLEGENDENTRY = 0x1043;
        public const UInt16 CHPROPERTIES = 0x1044;
        public const UInt16 CHSERGROUP = 0x1045;
        public const UInt16 CHUSEDAXESSETS = 0x1046;
        public const UInt16 CHPIVOTREF = 0x1048;
        public const UInt16 CHSERPARENT = 0x104A;
        public const UInt16 CHSERTRENDLINE = 0x104B;
        public const UInt16 CHFORMAT = 0x104E;
        public const UInt16 CHPOS = 0x104F;
        public const UInt16 CHFORMATRUNS = 0x1050;
        public const UInt16 CHSOURCELINK = 0x1051;
        public const UInt16 CHSERERRORBAR = 0x105B;
        public const UInt16 CHSERIESFORMAT = 0x105D;
        public const UInt16 CH3DDATAFORMAT = 0x105F;
        public const UInt16 CHFONTBASE = 0x1060;
        public const UInt16 CHPIEEXT = 0x1061;
        public const UInt16 CHEXTRANGE = 0x1062;
        public const UInt16 CHDATATABLE = 0x1063;
        public const UInt16 CHPLOTGROWTH = 0x1064;
        public const UInt16 CHSERINDEX = 0x1065;
        public const UInt16 CHESCHERFORMAT = 0x1066;
        public const UInt16 CHPIEEXTSETT = 0x1067;
    }
}