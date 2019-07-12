using System;
using System.Reflection;

namespace APIMIDDLEWARE._Functions.Models
{
    public enum ContentType
    {
        [ContentMetadata(Value = "application/x-authorware-bin", IsBinary = true)]
        AAB,

        [ContentMetadata(Value = "audio/x-aac", IsBinary = true)]
        AAC,

        [ContentMetadata(Value = "application/x-authorware-map", IsBinary = true)]
        AAM,

        [ContentMetadata(Value = "application/x-authorware-seg", IsBinary = true)]
        AAS,

        [ContentMetadata(Value = "application/x-abiword", IsBinary = true)]
        ABW,

        [ContentMetadata(Value = "application/pkix-attr-cert", IsBinary = true)]
        AC,

        [ContentMetadata(Value = "application/vnd.americandynamics.acc", IsBinary = true)]
        ACC,

        [ContentMetadata(Value = "application/x-ace-compressed", IsBinary = true)]
        ACE,

        [ContentMetadata(Value = "application/vnd.acucobol", IsBinary = true)]
        ACU,

        [ContentMetadata(Value = "application/vnd.acucorp", IsBinary = true)]
        ACUTC,

        [ContentMetadata(Value = "audio/adpcm", IsBinary = true)]
        ADP,

        [ContentMetadata(Value = "application/vnd.audiograph", IsBinary = true)]
        AEP,

        [ContentMetadata(Value = "application/x-font-type1", IsBinary = true)]
        AFM,

        [ContentMetadata(Value = "application/vnd.ibm.modcap", IsBinary = true)]
        AFP,

        [ContentMetadata(Value = "application/vnd.ahead.space", IsBinary = true)]
        AHEAD,

        [ContentMetadata(Value = "application/postscript", IsBinary = true)]
        AI,

        [ContentMetadata(Value = "audio/x-aiff", IsBinary = true)]
        AIF,

        [ContentMetadata(Value = "audio/x-aiff", IsBinary = true)]
        AIFC,

        [ContentMetadata(Value = "audio/x-aiff", IsBinary = true)]
        AIFF,

        [ContentMetadata(Value = "application/vnd.adobe.air-application-installer-package+zip", IsBinary = true)]
        AIR,

        [ContentMetadata(Value = "application/vnd.dvb.ait", IsBinary = true)]
        AIT,

        [ContentMetadata(Value = "application/vnd.amiga.ami", IsBinary = true)]
        AMI,

        [ContentMetadata(Value = "application/vnd.android.package-archive", IsBinary = true)]
        APK,

        [ContentMetadata(Value = "text/cache-manifest", IsText = true)]
        APPCACHE,

        [ContentMetadata(Value = "application/x-ms-application", IsBinary = true)]
        APPLICATION,

        [ContentMetadata(Value = "application/vnd.lotus-approach", IsBinary = true)]
        APR,

        [ContentMetadata(Value = "application/x-freearc", IsBinary = true)]
        ARC,

        [ContentMetadata(Value = "text/plain", IsText = true)]
        ASC,

        [ContentMetadata(Value = "video/x-ms-asf", IsBinary = true)]
        ASF,

        [ContentMetadata(Value = "text/x-asm", IsText = true)]
        ASM,

        [ContentMetadata(Value = "application/vnd.accpac.simply.aso", IsBinary = true)]
        ASO,

        [ContentMetadata(Value = "video/x-ms-asf", IsBinary = true)]
        ASX,

        [ContentMetadata(Value = "application/vnd.acucorp", IsBinary = true)]
        ATC,

        [ContentMetadata(Value = "application/atom+xml", IsText = true)]
        ATOM,

        [ContentMetadata(Value = "application/atomcat+xml", IsText = true)]
        ATOMCAT,

        [ContentMetadata(Value = "application/atomsvc+xml", IsText = true)]
        ATOMSVC,

        [ContentMetadata(Value = "application/vnd.antix.game-component", IsBinary = true)]
        ATX,

        [ContentMetadata(Value = "audio/basic", IsBinary = true)]
        AU,

        [ContentMetadata(Value = "video/x-msvideo", IsBinary = true)]
        AVI,

        [ContentMetadata(Value = "application/applixware", IsBinary = true)]
        AW,

        [ContentMetadata(Value = "application/vnd.airzip.filesecure.azf", IsBinary = true)]
        AZF,

        [ContentMetadata(Value = "application/vnd.airzip.filesecure.azs", IsBinary = true)]
        AZS,

        [ContentMetadata(Value = "application/vnd.amazon.ebook", IsBinary = true)]
        AZW,

        [ContentMetadata(Value = "application/x-msdownload", IsBinary = true)]
        BAT,

        [ContentMetadata(Value = "application/x-bcpio", IsBinary = true)]
        BCPIO,

        [ContentMetadata(Value = "application/x-font-bdf", IsBinary = true)]
        BDF,

        [ContentMetadata(Value = "application/vnd.syncml.dm+wbxml", IsText = true)]
        BDM,

        [ContentMetadata(Value = "application/vnd.realvnc.bed", IsBinary = true)]
        BED,

        [ContentMetadata(Value = "application/vnd.fujitsu.oasysprs", IsBinary = true)]
        BH2,

        [ContentMetadata(Value = "application/octet-stream", IsBinary = true)]
        BIN,

        [ContentMetadata(Value = "application/x-blorb", IsBinary = true)]
        BLB,

        [ContentMetadata(Value = "application/x-blorb", IsBinary = true)]
        BLORB,

        [ContentMetadata(Value = "application/vnd.bmi", IsBinary = true)]
        BMI,

        [ContentMetadata(Value = "image/bmp", IsBinary = true)]
        BMP,

        [ContentMetadata(Value = "application/vnd.framemaker", IsBinary = true)]
        BOOK,

        [ContentMetadata(Value = "application/vnd.previewsystems.box", IsBinary = true)]
        BOX,

        [ContentMetadata(Value = "application/x-bzip2", IsBinary = true)]
        BOZ,

        [ContentMetadata(Value = "application/octet-stream", IsBinary = true)]
        BPK,

        [ContentMetadata(Value = "image/prs.btif", IsBinary = true)]
        BTIF,

        [ContentMetadata(Value = "application/x-bzip", IsBinary = true)]
        BZ,

        [ContentMetadata(Value = "application/x-bzip2", IsBinary = true)]
        BZ2,

        [ContentMetadata(Value = "text/x-c", IsText = true)]
        C,

        [ContentMetadata(Value = "application/vnd.cluetrust.cartomobile-config", IsBinary = true)]
        C11AMC,

        [ContentMetadata(Value = "application/vnd.cluetrust.cartomobile-config-pkg", IsBinary = true)]
        C11AMZ,

        [ContentMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4D,

        [ContentMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4F,

        [ContentMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4G,

        [ContentMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4P,

        [ContentMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4U,

        [ContentMetadata(Value = "application/vnd.ms-cab-compressed", IsBinary = true)]
        CAB,

        [ContentMetadata(Value = "audio/x-caf", IsBinary = true)]
        CAF,

        [ContentMetadata(Value = "application/vnd.tcpdump.pcap", IsBinary = true)]
        CAP,

        [ContentMetadata(Value = "application/vnd.curl.car", IsBinary = true)]
        CAR,

        [ContentMetadata(Value = "application/vnd.ms-pki.seccat", IsBinary = true)]
        CAT,

        [ContentMetadata(Value = "application/x-cbr", IsBinary = true)]
        CB7,

        [ContentMetadata(Value = "application/x-cbr", IsBinary = true)]
        CBA,

        [ContentMetadata(Value = "application/x-cbr", IsBinary = true)]
        CBR,

        [ContentMetadata(Value = "application/x-cbr", IsBinary = true)]
        CBT,

        [ContentMetadata(Value = "application/x-cbr", IsBinary = true)]
        CBZ,

        [ContentMetadata(Value = "text/x-c", IsText = true)]
        CC,

        [ContentMetadata(Value = "application/x-director", IsBinary = true)]
        CCT,

        [ContentMetadata(Value = "application/ccxml+xml", IsText = true)]
        CCXML,

        [ContentMetadata(Value = "application/vnd.contact.cmsg", IsBinary = true)]
        CDBCMSG,

        [ContentMetadata(Value = "application/x-netcdf", IsBinary = true)]
        CDF,

        [ContentMetadata(Value = "application/vnd.mediastation.cdkey", IsBinary = true)]
        CDKEY,

        [ContentMetadata(Value = "application/cdmi-capability", IsBinary = true)]
        CDMIA,

        [ContentMetadata(Value = "application/cdmi-container", IsBinary = true)]
        CDMIC,

        [ContentMetadata(Value = "application/cdmi-domain", IsBinary = true)]
        CDMID,

        [ContentMetadata(Value = "application/cdmi-object", IsBinary = true)]
        CDMIO,

        [ContentMetadata(Value = "application/cdmi-queue", IsBinary = true)]
        CDMIQ,

        [ContentMetadata(Value = "chemical/x-cdx", IsBinary = true)]
        CDX,

        [ContentMetadata(Value = "application/vnd.chemdraw+xml", IsText = true)]
        CDXML,

        [ContentMetadata(Value = "application/vnd.cinderella", IsBinary = true)]
        CDY,

        [ContentMetadata(Value = "application/pkix-cert", IsBinary = true)]
        CER,

        [ContentMetadata(Value = "application/x-cfs-compressed", IsBinary = true)]
        CFS,

        [ContentMetadata(Value = "image/cgm", IsBinary = true)]
        CGM,

        [ContentMetadata(Value = "application/x-chat", IsBinary = true)]
        CHAT,

        [ContentMetadata(Value = "application/vnd.ms-htmlhelp", IsBinary = true)]
        CHM,

        [ContentMetadata(Value = "application/vnd.kde.kchart", IsBinary = true)]
        CHRT,

        [ContentMetadata(Value = "chemical/x-cif", IsBinary = true)]
        CIF,

        [ContentMetadata(Value = "application/vnd.anser-web-certificate-issue-initiation", IsBinary = true)]
        CII,

        [ContentMetadata(Value = "application/vnd.ms-artgalry", IsBinary = true)]
        CIL,

        [ContentMetadata(Value = "application/vnd.claymore", IsBinary = true)]
        CLA,

        [ContentMetadata(Value = "application/java-vm", IsBinary = true)]
        CLASS,

        [ContentMetadata(Value = "application/vnd.crick.clicker.keyboard", IsBinary = true)]
        CLKK,

        [ContentMetadata(Value = "application/vnd.crick.clicker.palette", IsBinary = true)]
        CLKP,

        [ContentMetadata(Value = "application/vnd.crick.clicker.template", IsBinary = true)]
        CLKT,

        [ContentMetadata(Value = "application/vnd.crick.clicker.wordbank", IsBinary = true)]
        CLKW,

        [ContentMetadata(Value = "application/vnd.crick.clicker", IsBinary = true)]
        CLKX,

        [ContentMetadata(Value = "application/x-msclip", IsBinary = true)]
        CLP,

        [ContentMetadata(Value = "application/vnd.cosmocaller", IsBinary = true)]
        CMC,

        [ContentMetadata(Value = "chemical/x-cmdf", IsBinary = true)]
        CMDF,

        [ContentMetadata(Value = "chemical/x-cml", IsBinary = true)]
        CML,

        [ContentMetadata(Value = "application/vnd.yellowriver-custom-menu", IsBinary = true)]
        CMP,

        [ContentMetadata(Value = "image/x-cmx", IsBinary = true)]
        CMX,

        [ContentMetadata(Value = "application/vnd.rim.cod", IsBinary = true)]
        COD,

        [ContentMetadata(Value = "application/x-msdownload", IsBinary = true)]
        COM,

        [ContentMetadata(Value = "text/plain", IsText = true)]
        CONF,

        [ContentMetadata(Value = "application/x-cpio", IsBinary = true)]
        CPIO,

        [ContentMetadata(Value = "text/x-c", IsText = true)]
        CPP,

        [ContentMetadata(Value = "application/mac-compactpro", IsBinary = true)]
        CPT,

        [ContentMetadata(Value = "application/x-mscardfile", IsBinary = true)]
        CRD,

        [ContentMetadata(Value = "application/pkix-crl", IsBinary = true)]
        CRL,

        [ContentMetadata(Value = "application/x-x509-ca-cert", IsBinary = true)]
        CRT,

        [ContentMetadata(Value = "application/vnd.rig.cryptonote", IsBinary = true)]
        CRYPTONOTE,

        [ContentMetadata(Value = "application/x-csh", IsBinary = true)]
        CSH,

        [ContentMetadata(Value = "chemical/x-csml", IsBinary = true)]
        CSML,

        [ContentMetadata(Value = "application/vnd.commonspace", IsBinary = true)]
        CSP,

        [ContentMetadata(Value = "text/css", IsText = true)]
        CSS,

        [ContentMetadata(Value = "application/x-director", IsBinary = true)]
        CST,

        [ContentMetadata(Value = "text/csv", IsText = true)]
        CSV,

        [ContentMetadata(Value = "application/cu-seeme", IsBinary = true)]
        CU,

        [ContentMetadata(Value = "text/vnd.curl", IsText = true)]
        CURL,

        [ContentMetadata(Value = "application/prs.cww", IsBinary = true)]
        CWW,

        [ContentMetadata(Value = "application/x-director", IsBinary = true)]
        CXT,

        [ContentMetadata(Value = "text/x-c", IsText = true)]
        CXX,

        [ContentMetadata(Value = "model/vnd.collada+xml", IsText = true)]
        DAE,

        [ContentMetadata(Value = "application/vnd.mobius.daf", IsBinary = true)]
        DAF,

        [ContentMetadata(Value = "application/vnd.dart", IsBinary = true)]
        DART,

        [ContentMetadata(Value = "application/vnd.fdsn.seed", IsBinary = true)]
        DATALESS,

        [ContentMetadata(Value = "application/davmount+xml", IsText = true)]
        DAVMOUNT,

        [ContentMetadata(Value = "application/docbook+xml", IsText = true)]
        DBK,

        [ContentMetadata(Value = "application/x-director", IsBinary = true)]
        DCR,

        [ContentMetadata(Value = "text/vnd.curl.dcurl", IsText = true)]
        DCURL,

        [ContentMetadata(Value = "application/vnd.oma.dd2+xml", IsText = true)]
        DD2,

        [ContentMetadata(Value = "application/vnd.fujixerox.ddd", IsBinary = true)]
        DDD,

        [ContentMetadata(Value = "application/x-debian-package", IsBinary = true)]
        DEB,

        [ContentMetadata(Value = "text/plain", IsText = true)]
        DEF,

        [ContentMetadata(Value = "application/octet-stream", IsBinary = true)]
        DEPLOY,

        [ContentMetadata(Value = "application/x-x509-ca-cert", IsBinary = true)]
        DER,

        [ContentMetadata(Value = "application/vnd.dreamfactory", IsBinary = true)]
        DFAC,

        [ContentMetadata(Value = "application/x-dgc-compressed", IsBinary = true)]
        DGC,

        [ContentMetadata(Value = "text/x-c", IsText = true)]
        DIC,

        [ContentMetadata(Value = "video/x-dv", IsBinary = true)]
        DIF,

        [ContentMetadata(Value = "application/x-director", IsBinary = true)]
        DIR,

        [ContentMetadata(Value = "application/vnd.mobius.dis", IsBinary = true)]
        DIS,

        [ContentMetadata(Value = "application/octet-stream", IsBinary = true)]
        DIST,

        [ContentMetadata(Value = "application/octet-stream", IsBinary = true)]
        DISTZ,

        [ContentMetadata(Value = "image/vnd.djvu", IsBinary = true)]
        DJV,

        [ContentMetadata(Value = "image/vnd.djvu", IsBinary = true)]
        DJVU,

        [ContentMetadata(Value = "application/x-msdownload", IsBinary = true)]
        DLL,

        [ContentMetadata(Value = "application/x-apple-diskimage", IsBinary = true)]
        DMG,

        [ContentMetadata(Value = "application/vnd.tcpdump.pcap", IsBinary = true)]
        DMP,

        [ContentMetadata(Value = "application/octet-stream", IsBinary = true)]
        DMS,

        [ContentMetadata(Value = "application/vnd.dna", IsBinary = true)]
        DNA,

        [ContentMetadata(Value = "application/msword", IsBinary = true)]
        DOC,

        [ContentMetadata(Value = "application/vnd.ms-word.document.macroenabled.12", IsBinary = true)]
        DOCM,

        [ContentMetadata(Value = "application/vnd.openxmlformats-officedocument.wordprocessingml.document", IsBinary = true)]
        DOCX,

        [ContentMetadata(Value = "application/msword", IsBinary = true)]
        DOT,

        [ContentMetadata(Value = "application/vnd.ms-word.template.macroenabled.12", IsBinary = true)]
        DOTM,

        [ContentMetadata(Value = "application/vnd.openxmlformats-officedocument.wordprocessingml.template", IsBinary = true)]
        DOTX,

        [ContentMetadata(Value = "application/vnd.osgi.dp", IsBinary = true)]
        DP,

        [ContentMetadata(Value = "application/vnd.dpgraph", IsBinary = true)]
        DPG,

        [ContentMetadata(Value = "audio/vnd.dra", IsBinary = true)]
        DRA,

        [ContentMetadata(Value = "text/prs.lines.tag", IsText = true)]
        DSC,

        [ContentMetadata(Value = "application/dssc+der", IsBinary = true)]
        DSSC,

        [ContentMetadata(Value = "application/x-dtbook+xml", IsText = true)]
        DTB,

        [ContentMetadata(Value = "application/xml-dtd", IsBinary = true)]
        DTD,

        [ContentMetadata(Value = "audio/vnd.dts", IsBinary = true)]
        DTS,

        [ContentMetadata(Value = "audio/vnd.dts.hd", IsBinary = true)]
        DTSHD,

        [ContentMetadata(Value = "application/octet-stream", IsBinary = true)]
        DUMP,

        [ContentMetadata(Value = "video/x-dv", IsBinary = true)]
        DV,

        [ContentMetadata(Value = "video/vnd.dvb.file", IsBinary = true)]
        DVB,

        [ContentMetadata(Value = "application/x-dvi", IsBinary = true)]
        DVI,

        [ContentMetadata(Value = "model/vnd.dwf", IsBinary = true)]
        DWF,

        [ContentMetadata(Value = "image/vnd.dwg", IsBinary = true)]
        DWG,

        [ContentMetadata(Value = "image/vnd.dxf", IsBinary = true)]
        DXF,

        [ContentMetadata(Value = "application/vnd.spotfire.dxp", IsBinary = true)]
        DXP,

        [ContentMetadata(Value = "application/x-director", IsBinary = true)]
        DXR,

        [ContentMetadata(Value = "audio/vnd.nuera.ecelp4800", IsBinary = true)]
        ECELP4800,

        [ContentMetadata(Value = "audio/vnd.nuera.ecelp7470", IsBinary = true)]
        ECELP7470,

        [ContentMetadata(Value = "audio/vnd.nuera.ecelp9600", IsBinary = true)]
        ECELP9600,

        [ContentMetadata(Value = "application/ecmascript", IsBinary = true)]
        ECMA,

        [ContentMetadata(Value = "application/vnd.novadigm.edm", IsBinary = true)]
        EDM,

        [ContentMetadata(Value = "application/vnd.novadigm.edx", IsBinary = true)]
        EDX,

        [ContentMetadata(Value = "application/vnd.picsel", IsBinary = true)]
        EFIF,

        [ContentMetadata(Value = "application/vnd.pg.osasli", IsBinary = true)]
        EI6,

        [ContentMetadata(Value = "application/octet-stream", IsBinary = true)]
        ELC,

        [ContentMetadata(Value = "application/x-msmetafile", IsBinary = true)]
        EMF,

        [ContentMetadata(Value = "message/rfc822", IsBinary = true)]
        EML,

        [ContentMetadata(Value = "application/emma+xml", IsText = true)]
        EMMA,

        [ContentMetadata(Value = "application/x-msmetafile", IsBinary = true)]
        EMZ,

        [ContentMetadata(Value = "audio/vnd.digital-winds", IsBinary = true)]
        EOL,

        [ContentMetadata(Value = "application/vnd.ms-fontobject", IsBinary = true)]
        EOT,

        [ContentMetadata(Value = "application/postscript", IsBinary = true)]
        EPS,

        [ContentMetadata(Value = "application/epub+zip", IsBinary = true)]
        EPUB,

        [ContentMetadata(Value = "application/vnd.eszigno3+xml", IsText = true)]
        ES3,

        [ContentMetadata(Value = "application/vnd.osgi.subsystem", IsBinary = true)]
        ESA,

        [ContentMetadata(Value = "application/vnd.epson.esf", IsBinary = true)]
        ESF,

        [ContentMetadata(Value = "application/vnd.eszigno3+xml", IsText = true)]
        ET3,

        [ContentMetadata(Value = "text/x-setext", IsText = true)]
        ETX,

        [ContentMetadata(Value = "application/x-eva", IsBinary = true)]
        EVA,

        [ContentMetadata(Value = "application/x-envoy", IsBinary = true)]
        EVY,

        [ContentMetadata(Value = "application/x-msdownload", IsBinary = true)]
        EXE,

        [ContentMetadata(Value = "application/exi", IsBinary = true)]
        EXI,

        [ContentMetadata(Value = "application/vnd.novadigm.ext", IsBinary = true)]
        EXT,

        [ContentMetadata(Value = "MIME type (lowercased)", IsBinary = true)]
        EXTENSIONS,

        [ContentMetadata(Value = "application/andrew-inset", IsBinary = true)]
        EZ,

        [ContentMetadata(Value = "application/vnd.ezpix-album", IsBinary = true)]
        EZ2,

        [ContentMetadata(Value = "application/vnd.ezpix-package", IsBinary = true)]
        EZ3,

        [ContentMetadata(Value = "text/x-fortran", IsText = true)]
        F,

        [ContentMetadata(Value = "video/x-f4v", IsBinary = true)]
        F4V,

        [ContentMetadata(Value = "text/x-fortran", IsText = true)]
        F77,

        [ContentMetadata(Value = "text/x-fortran", IsText = true)]
        F90,

        [ContentMetadata(Value = "image/vnd.fastbidsheet", IsBinary = true)]
        FBS,

        [ContentMetadata(Value = "application/vnd.adobe.formscentral.fcdt", IsBinary = true)]
        FCDT,

        [ContentMetadata(Value = "application/vnd.isac.fcs", IsBinary = true)]
        FCS,

        [ContentMetadata(Value = "application/vnd.fdf", IsBinary = true)]
        FDF,

        [ContentMetadata(Value = "application/vnd.denovo.fcselayout-link", IsBinary = true)]
        FE_LAUNCH,

        [ContentMetadata(Value = "application/vnd.fujitsu.oasysgp", IsBinary = true)]
        FG5,

        [ContentMetadata(Value = "application/x-director", IsBinary = true)]
        FGD,

        [ContentMetadata(Value = "image/x-freehand", IsBinary = true)]
        FH,

        [ContentMetadata(Value = "image/x-freehand", IsBinary = true)]
        FH4,

        [ContentMetadata(Value = "image/x-freehand", IsBinary = true)]
        FH5,

        [ContentMetadata(Value = "image/x-freehand", IsBinary = true)]
        FH7,

        [ContentMetadata(Value = "image/x-freehand", IsBinary = true)]
        FHC,

        [ContentMetadata(Value = "application/x-xfig", IsBinary = true)]
        FIG,

        [ContentMetadata(Value = "audio/x-flac", IsBinary = true)]
        FLAC,

        [ContentMetadata(Value = "video/x-fli", IsBinary = true)]
        FLI,

        [ContentMetadata(Value = "application/vnd.micrografx.flo", IsBinary = true)]
        FLO,

        [ContentMetadata(Value = "video/x-flv", IsBinary = true)]
        FLV,

        [ContentMetadata(Value = "application/vnd.kde.kivio", IsBinary = true)]
        FLW,

        [ContentMetadata(Value = "text/vnd.fmi.flexstor", IsText = true)]
        FLX,

        [ContentMetadata(Value = "text/vnd.fly", IsText = true)]
        FLY,

        [ContentMetadata(Value = "application/vnd.framemaker", IsBinary = true)]
        FM,

        [ContentMetadata(Value = "application/vnd.frogans.fnc", IsBinary = true)]
        FNC,

        [ContentMetadata(Value = "text/x-fortran", IsText = true)]
        FOR,

        [ContentMetadata(Value = "image/vnd.fpx", IsBinary = true)]
        FPX,

        [ContentMetadata(Value = "application/vnd.framemaker", IsBinary = true)]
        FRAME,

        [ContentMetadata(Value = "application/vnd.fsc.weblaunch", IsBinary = true)]
        FSC,

        [ContentMetadata(Value = "image/vnd.fst", IsBinary = true)]
        FST,

        [ContentMetadata(Value = "application/vnd.fluxtime.clip", IsBinary = true)]
        FTC,

        [ContentMetadata(Value = "application/vnd.anser-web-funds-transfer-initiation", IsBinary = true)]
        FTI,

        [ContentMetadata(Value = "video/vnd.fvt", IsBinary = true)]
        FVT,

        [ContentMetadata(Value = "application/vnd.adobe.fxp", IsBinary = true)]
        FXP,

        [ContentMetadata(Value = "application/vnd.adobe.fxp", IsBinary = true)]
        FXPL,

        [ContentMetadata(Value = "application/vnd.fuzzysheet", IsBinary = true)]
        FZS,

        [ContentMetadata(Value = "application/vnd.geoplan", IsBinary = true)]
        G2W,

        [ContentMetadata(Value = "image/g3fax", IsBinary = true)]
        G3,

        [ContentMetadata(Value = "application/vnd.geospace", IsBinary = true)]
        G3W,

        [ContentMetadata(Value = "application/vnd.groove-account", IsBinary = true)]
        GAC,

        [ContentMetadata(Value = "application/x-tads", IsBinary = true)]
        GAM,

        [ContentMetadata(Value = "application/rpki-ghostbusters", IsBinary = true)]
        GBR,

        [ContentMetadata(Value = "application/x-gca-compressed", IsBinary = true)]
        GCA,

        [ContentMetadata(Value = "model/vnd.gdl", IsBinary = true)]
        GDL,

        [ContentMetadata(Value = "application/vnd.dynageo", IsBinary = true)]
        GEO,

        [ContentMetadata(Value = "application/vnd.geometry-explorer", IsBinary = true)]
        GEX,

        [ContentMetadata(Value = "application/vnd.geogebra.file", IsBinary = true)]
        GGB,

        [ContentMetadata(Value = "application/vnd.geogebra.tool", IsBinary = true)]
        GGT,

        [ContentMetadata(Value = "application/vnd.groove-help", IsBinary = true)]
        GHF,

        [ContentMetadata(Value = "image/gif", IsBinary = true)]
        GIF,

        [ContentMetadata(Value = "application/vnd.groove-identity-message", IsBinary = true)]
        GIM,

        [ContentMetadata(Value = "application/gml+xml", IsText = true)]
        GML,

        [ContentMetadata(Value = "application/vnd.gmx", IsBinary = true)]
        GMX,

        [ContentMetadata(Value = "application/x-gnumeric", IsBinary = true)]
        GNUMERIC,

        [ContentMetadata(Value = "application/vnd.flographit", IsBinary = true)]
        GPH,

        [ContentMetadata(Value = "application/gpx+xml", IsText = true)]
        GPX,

        [ContentMetadata(Value = "application/vnd.grafeq", IsBinary = true)]
        GQF,

        [ContentMetadata(Value = "application/vnd.grafeq", IsBinary = true)]
        GQS,

        [ContentMetadata(Value = "application/srgs", IsBinary = true)]
        GRAM,

        [ContentMetadata(Value = "application/x-gramps-xml", IsText = true)]
        GRAMPS,

        [ContentMetadata(Value = "application/vnd.geometry-explorer", IsBinary = true)]
        GRE,

        [ContentMetadata(Value = "application/vnd.groove-injector", IsBinary = true)]
        GRV,

        [ContentMetadata(Value = "application/srgs+xml", IsText = true)]
        GRXML,

        [ContentMetadata(Value = "application/x-font-ghostscript", IsBinary = true)]
        GSF,

        [ContentMetadata(Value = "application/x-gtar", IsBinary = true)]
        GTAR,

        [ContentMetadata(Value = "application/vnd.groove-tool-message", IsBinary = true)]
        GTM,

        [ContentMetadata(Value = "model/vnd.gtw", IsBinary = true)]
        GTW,

        [ContentMetadata(Value = "text/vnd.graphviz", IsText = true)]
        GV,

        [ContentMetadata(Value = "application/gxf", IsBinary = true)]
        GXF,

        [ContentMetadata(Value = "application/vnd.geonext", IsBinary = true)]
        GXT,

        [ContentMetadata(Value = "text/x-c", IsText = true)]
        H,

        [ContentMetadata(Value = "video/h261", IsBinary = true)]
        H261,

        [ContentMetadata(Value = "video/h263", IsBinary = true)]
        H263,

        [ContentMetadata(Value = "video/h264", IsBinary = true)]
        H264,

        [ContentMetadata(Value = "application/vnd.hal+xml", IsText = true)]
        HAL,

        [ContentMetadata(Value = "application/vnd.hbci", IsBinary = true)]
        HBCI,

        [ContentMetadata(Value = "application/x-hdf", IsBinary = true)]
        HDF,

        [ContentMetadata(Value = "text/x-c", IsText = true)]
        HH,

        [ContentMetadata(Value = "application/winhlp", IsBinary = true)]
        HLP,

        [ContentMetadata(Value = "application/vnd.hp-hpgl", IsBinary = true)]
        HPGL,

        [ContentMetadata(Value = "application/vnd.hp-hpid", IsBinary = true)]
        HPID,

        [ContentMetadata(Value = "application/vnd.hp-hps", IsBinary = true)]
        HPS,

        [ContentMetadata(Value = "application/mac-binhex40", IsBinary = true)]
        HQX,

        [ContentMetadata(Value = "application/vnd.kenameaapp", IsBinary = true)]
        HTKE,

        [ContentMetadata(Value = "text/html", IsText = true)]
        HTM,

        [ContentMetadata(Value = "text/html", IsText = true)]
        HTML,

        [ContentMetadata(Value = "application/vnd.yamaha.hv-dic", IsBinary = true)]
        HVD,

        [ContentMetadata(Value = "application/vnd.yamaha.hv-voice", IsBinary = true)]
        HVP,

        [ContentMetadata(Value = "application/vnd.yamaha.hv-script", IsBinary = true)]
        HVS,

        [ContentMetadata(Value = "application/vnd.intergeo", IsBinary = true)]
        I2G,

        [ContentMetadata(Value = "x-conference/x-cooltalk", IsBinary = true)]
        IC,

        [ContentMetadata(Value = "application/vnd.iccprofile", IsBinary = true)]
        ICC,

        [ContentMetadata(Value = "x-conference/x-cooltalk", IsBinary = true)]
        ICE,

        [ContentMetadata(Value = "application/vnd.iccprofile", IsBinary = true)]
        ICM,

        [ContentMetadata(Value = "image/x-icon", IsBinary = true)]
        ICO,

        [ContentMetadata(Value = "text/calendar", IsText = true)]
        ICS,

        [ContentMetadata(Value = "image/ief", IsBinary = true)]
        IEF,

        [ContentMetadata(Value = "text/calendar", IsText = true)]
        IFB,

        [ContentMetadata(Value = "application/vnd.shana.informed.formdata", IsBinary = true)]
        IFM,

        [ContentMetadata(Value = "model/iges", IsBinary = true)]
        IGES,

        [ContentMetadata(Value = "application/vnd.igloader", IsBinary = true)]
        IGL,

        [ContentMetadata(Value = "application/vnd.insors.igm", IsBinary = true)]
        IGM,

        [ContentMetadata(Value = "model/iges", IsBinary = true)]
        IGS,

        [ContentMetadata(Value = "application/vnd.micrografx.igx", IsBinary = true)]
        IGX,

        [ContentMetadata(Value = "application/vnd.shana.informed.interchange", IsBinary = true)]
        IIF,

        [ContentMetadata(Value = "application/vnd.accpac.simply.imp", IsBinary = true)]
        IMP,

        [ContentMetadata(Value = "application/vnd.ms-ims", IsBinary = true)]
        IMS,

        [ContentMetadata(Value = "text/plain", IsText = true)]
        IN,

        [ContentMetadata(Value = "application/inkml+xml", IsText = true)]
        INK,

        [ContentMetadata(Value = "application/inkml+xml", IsText = true)]
        INKML,

        [ContentMetadata(Value = "application/x-install-instructions", IsBinary = true)]
        INSTALL,

        [ContentMetadata(Value = "application/vnd.astraea-software.iota", IsBinary = true)]
        IOTA,

        [ContentMetadata(Value = "application/ipfix", IsBinary = true)]
        IPFIX,

        [ContentMetadata(Value = "application/vnd.shana.informed.package", IsBinary = true)]
        IPK,

        [ContentMetadata(Value = "application/vnd.ibm.rights-management", IsBinary = true)]
        IRM,

        [ContentMetadata(Value = "application/vnd.irepository.package+xml", IsText = true)]
        IRP,

        [ContentMetadata(Value = "application/x-iso9660-image", IsBinary = true)]
        ISO,

        [ContentMetadata(Value = "application/vnd.shana.informed.formtemplate", IsBinary = true)]
        ITP,

        [ContentMetadata(Value = "application/vnd.immervision-ivp", IsBinary = true)]
        IVP,

        [ContentMetadata(Value = "application/vnd.immervision-ivu", IsBinary = true)]
        IVU,

        [ContentMetadata(Value = "text/vnd.sun.j2me.app-descriptor", IsText = true)]
        JAD,

        [ContentMetadata(Value = "application/vnd.jam", IsBinary = true)]
        JAM,

        [ContentMetadata(Value = "application/java-archive", IsBinary = true)]
        JAR,

        [ContentMetadata(Value = "text/x-java-source", IsText = true)]
        JAVA,

        [ContentMetadata(Value = "application/vnd.jisp", IsBinary = true)]
        JISP,

        [ContentMetadata(Value = "application/vnd.hp-jlyt", IsBinary = true)]
        JLT,

        [ContentMetadata(Value = "application/x-java-jnlp-file", IsBinary = true)]
        JNLP,

        [ContentMetadata(Value = "application/vnd.joost.joda-archive", IsBinary = true)]
        JODA,

        [ContentMetadata(Value = "image/jp2", IsBinary = true)]
        JP2,

        [ContentMetadata(Value = "image/jpeg", IsBinary = true)]
        JPE,

        [ContentMetadata(Value = "image/jpeg", IsBinary = true)]
        JPEG,

        [ContentMetadata(Value = "image/jpeg", IsBinary = true)]
        JPG,

        [ContentMetadata(Value = "video/jpm", IsBinary = true)]
        JPGM,

        [ContentMetadata(Value = "video/jpeg", IsBinary = true)]
        JPGV,

        [ContentMetadata(Value = "video/jpm", IsBinary = true)]
        JPM,

        [ContentMetadata(Value = "application/javascript", IsText = true)]
        JS,

        [ContentMetadata(Value = "application/json", IsText = true)]
        JSON,

        [ContentMetadata(Value = "application/jsonml+json", IsText = true)]
        JSONML,

        [ContentMetadata(Value = "audio/midi", IsBinary = true)]
        KAR,

        [ContentMetadata(Value = "application/vnd.kde.karbon", IsBinary = true)]
        KARBON,

        [ContentMetadata(Value = "application/vnd.kde.kformula", IsBinary = true)]
        KFO,

        [ContentMetadata(Value = "application/vnd.kidspiration", IsBinary = true)]
        KIA,

        [ContentMetadata(Value = "application/vnd.google-earth.kml+xml", IsText = true)]
        KML,

        [ContentMetadata(Value = "application/vnd.google-earth.kmz", IsBinary = true)]
        KMZ,

        [ContentMetadata(Value = "application/vnd.kinar", IsBinary = true)]
        KNE,

        [ContentMetadata(Value = "application/vnd.kinar", IsBinary = true)]
        KNP,

        [ContentMetadata(Value = "application/vnd.kde.kontour", IsBinary = true)]
        KON,

        [ContentMetadata(Value = "application/vnd.kde.kpresenter", IsBinary = true)]
        KPR,

        [ContentMetadata(Value = "application/vnd.kde.kpresenter", IsBinary = true)]
        KPT,

        [ContentMetadata(Value = "application/vnd.ds-keypoint", IsBinary = true)]
        KPXX,

        [ContentMetadata(Value = "application/vnd.kde.kspread", IsBinary = true)]
        KSP,

        [ContentMetadata(Value = "application/vnd.kahootz", IsBinary = true)]
        KTR,

        [ContentMetadata(Value = "image/ktx", IsBinary = true)]
        KTX,

        [ContentMetadata(Value = "application/vnd.kahootz", IsBinary = true)]
        KTZ,

        [ContentMetadata(Value = "application/vnd.kde.kword", IsBinary = true)]
        KWD,

        [ContentMetadata(Value = "application/vnd.kde.kword", IsBinary = true)]
        KWT,

        [ContentMetadata(Value = "application/vnd.las.las+xml", IsText = true)]
        LASXML,

        [ContentMetadata(Value = "application/x-latex", IsBinary = true)]
        LATEX,

        [ContentMetadata(Value = "application/vnd.llamagraphics.life-balance.desktop", IsBinary = true)]
        LBD,

        [ContentMetadata(Value = "application/vnd.llamagraphics.life-balance.exchange+xml", IsText = true)]
        LBE,

        [ContentMetadata(Value = "application/vnd.hhe.lesson-player", IsBinary = true)]
        LES,

        [ContentMetadata(Value = "application/x-lzh-compressed", IsBinary = true)]
        LHA,

        [ContentMetadata(Value = "application/vnd.route66.link66+xml", IsText = true)]
        LINK66,

        [ContentMetadata(Value = "text/plain", IsText = true)]
        LIST,

        [ContentMetadata(Value = "application/vnd.ibm.modcap", IsBinary = true)]
        LIST3820,

        [ContentMetadata(Value = "application/vnd.ibm.modcap", IsBinary = true)]
        LISTAFP,

        [ContentMetadata(Value = "application/x-ms-shortcut", IsBinary = true)]
        LNK,

        [ContentMetadata(Value = "text/plain", IsText = true)]
        LOG,

        [ContentMetadata(Value = "application/lost+xml", IsText = true)]
        LOSTXML,

        [ContentMetadata(Value = "application/octet-stream", IsBinary = true)]
        LRF,

        [ContentMetadata(Value = "application/vnd.ms-lrm", IsBinary = true)]
        LRM,

        [ContentMetadata(Value = "application/vnd.frogans.ltf", IsBinary = true)]
        LTF,

        [ContentMetadata(Value = "audio/vnd.lucent.voice", IsBinary = true)]
        LVP,

        [ContentMetadata(Value = "application/vnd.lotus-wordpro", IsBinary = true)]
        LWP,

        [ContentMetadata(Value = "application/x-lzh-compressed", IsBinary = true)]
        LZH,

        [ContentMetadata(Value = "application/x-msmediaview", IsBinary = true)]
        M13,

        [ContentMetadata(Value = "application/x-msmediaview", IsBinary = true)]
        M14,

        [ContentMetadata(Value = "video/mpeg", IsBinary = true)]
        M1V,

        [ContentMetadata(Value = "application/mp21", IsBinary = true)]
        M21,

        [ContentMetadata(Value = "audio/mpeg", IsBinary = true)]
        M2A,

        [ContentMetadata(Value = "video/mpeg", IsBinary = true)]
        M2V,

        [ContentMetadata(Value = "audio/mpeg", IsBinary = true)]
        M3A,

        [ContentMetadata(Value = "audio/x-mpegurl", IsBinary = true)]
        M3U,

        [ContentMetadata(Value = "application/vnd.apple.mpegurl", IsBinary = true)]
        M3U8,

        [ContentMetadata(Value = "audio/mp4a-latm", IsBinary = true)]
        M4A,

        [ContentMetadata(Value = "audio/mp4a-latm", IsBinary = true)]
        M4B,

        [ContentMetadata(Value = "audio/mp4a-latm", IsBinary = true)]
        M4P,

        [ContentMetadata(Value = "video/vnd.mpegurl", IsBinary = true)]
        M4U,

        [ContentMetadata(Value = "video/x-m4v", IsBinary = true)]
        M4V,

        [ContentMetadata(Value = "application/mathematica", IsBinary = true)]
        MA,

        [ContentMetadata(Value = "image/x-macpaint", IsBinary = true)]
        MAC,

        [ContentMetadata(Value = "application/mads+xml", IsText = true)]
        MADS,

        [ContentMetadata(Value = "application/vnd.ecowin.chart", IsBinary = true)]
        MAG,

        [ContentMetadata(Value = "application/vnd.framemaker", IsBinary = true)]
        MAKER,

        [ContentMetadata(Value = "application/x-troff-man", IsBinary = true)]
        MAN,

        [ContentMetadata(Value = "application/octet-stream", IsBinary = true)]
        MAR,

        [ContentMetadata(Value = "application/mathml+xml", IsText = true)]
        MATHML,

        [ContentMetadata(Value = "application/mathematica", IsBinary = true)]
        MB,

        [ContentMetadata(Value = "application/vnd.mobius.mbk", IsBinary = true)]
        MBK,

        [ContentMetadata(Value = "application/mbox", IsBinary = true)]
        MBOX,

        [ContentMetadata(Value = "application/vnd.medcalcdata", IsBinary = true)]
        MC1,

        [ContentMetadata(Value = "application/vnd.mcd", IsBinary = true)]
        MCD,

        [ContentMetadata(Value = "text/vnd.curl.mcurl", IsText = true)]
        MCURL,

        [ContentMetadata(Value = "application/x-msaccess", IsBinary = true)]
        MDB,

        [ContentMetadata(Value = "image/vnd.ms-modi", IsBinary = true)]
        MDI,

        [ContentMetadata(Value = "application/x-troff-me", IsBinary = true)]
        ME,

        [ContentMetadata(Value = "model/mesh", IsBinary = true)]
        MESH,

        [ContentMetadata(Value = "application/metalink4+xml", IsText = true)]
        META4,

        [ContentMetadata(Value = "application/metalink+xml", IsText = true)]
        METALINK,

        [ContentMetadata(Value = "application/mets+xml", IsText = true)]
        METS,

        [ContentMetadata(Value = "application/vnd.mfmp", IsBinary = true)]
        MFM,

        [ContentMetadata(Value = "application/rpki-manifest", IsBinary = true)]
        MFT,

        [ContentMetadata(Value = "application/vnd.osgeo.mapguide.package", IsBinary = true)]
        MGP,

        [ContentMetadata(Value = "application/vnd.proteus.magazine", IsBinary = true)]
        MGZ,

        [ContentMetadata(Value = "audio/midi", IsBinary = true)]
        MID,

        [ContentMetadata(Value = "audio/midi", IsBinary = true)]
        MIDI,

        [ContentMetadata(Value = "application/x-mie", IsBinary = true)]
        MIE,

        [ContentMetadata(Value = "application/vnd.mif", IsBinary = true)]
        MIF,

        [ContentMetadata(Value = "message/rfc822", IsBinary = true)]
        MIME,

        [ContentMetadata(Value = "video/mj2", IsBinary = true)]
        MJ2,

        [ContentMetadata(Value = "video/mj2", IsBinary = true)]
        MJP2,

        [ContentMetadata(Value = "video/x-matroska", IsBinary = true)]
        MK3D,

        [ContentMetadata(Value = "audio/x-matroska", IsBinary = true)]
        MKA,

        [ContentMetadata(Value = "video/x-matroska", IsBinary = true)]
        MKS,

        [ContentMetadata(Value = "video/x-matroska", IsBinary = true)]
        MKV,

        [ContentMetadata(Value = "application/vnd.dolby.mlp", IsBinary = true)]
        MLP,

        [ContentMetadata(Value = "application/vnd.chipnuts.karaoke-mmd", IsBinary = true)]
        MMD,

        [ContentMetadata(Value = "application/vnd.smaf", IsBinary = true)]
        MMF,

        [ContentMetadata(Value = "image/vnd.fujixerox.edmics-mmr", IsBinary = true)]
        MMR,

        [ContentMetadata(Value = "video/x-mng", IsBinary = true)]
        MNG,

        [ContentMetadata(Value = "application/x-msmoney", IsBinary = true)]
        MNY,

        [ContentMetadata(Value = "application/x-mobipocket-ebook", IsBinary = true)]
        MOBI,

        [ContentMetadata(Value = "application/mods+xml", IsText = true)]
        MODS,

        [ContentMetadata(Value = "video/quicktime", IsBinary = true)]
        MOV,

        [ContentMetadata(Value = "video/x-sgi-movie", IsBinary = true)]
        MOVIE,

        [ContentMetadata(Value = "audio/mpeg", IsBinary = true)]
        MP2,

        [ContentMetadata(Value = "application/mp21", IsBinary = true)]
        MP21,

        [ContentMetadata(Value = "audio/mpeg", IsBinary = true)]
        MP2A,

        [ContentMetadata(Value = "audio/mpeg", IsBinary = true)]
        MP3,

        [ContentMetadata(Value = "video/mp4", IsBinary = true)]
        MP4,

        [ContentMetadata(Value = "audio/mp4", IsBinary = true)]
        MP4A,

        [ContentMetadata(Value = "application/mp4", IsBinary = true)]
        MP4S,

        [ContentMetadata(Value = "video/mp4", IsBinary = true)]
        MP4V,

        [ContentMetadata(Value = "application/vnd.mophun.certificate", IsBinary = true)]
        MPC,

        [ContentMetadata(Value = "video/mpeg", IsBinary = true)]
        MPE,

        [ContentMetadata(Value = "video/mpeg", IsBinary = true)]
        MPEG,

        [ContentMetadata(Value = "video/mpeg", IsBinary = true)]
        MPG,

        [ContentMetadata(Value = "video/mp4", IsBinary = true)]
        MPG4,

        [ContentMetadata(Value = "audio/mpeg", IsBinary = true)]
        MPGA,

        [ContentMetadata(Value = "application/vnd.apple.installer+xml", IsText = true)]
        MPKG,

        [ContentMetadata(Value = "application/vnd.blueice.multipass", IsBinary = true)]
        MPM,

        [ContentMetadata(Value = "application/vnd.mophun.application", IsBinary = true)]
        MPN,

        [ContentMetadata(Value = "application/vnd.ms-project", IsBinary = true)]
        MPP,

        [ContentMetadata(Value = "application/vnd.ms-project", IsBinary = true)]
        MPT,

        [ContentMetadata(Value = "application/vnd.ibm.minipay", IsBinary = true)]
        MPY,

        [ContentMetadata(Value = "application/vnd.mobius.mqy", IsBinary = true)]
        MQY,

        [ContentMetadata(Value = "application/marc", IsBinary = true)]
        MRC,

        [ContentMetadata(Value = "application/marcxml+xml", IsText = true)]
        MRCX,

        [ContentMetadata(Value = "application/x-troff-ms", IsBinary = true)]
        MS,

        [ContentMetadata(Value = "application/mediaservercontrol+xml", IsText = true)]
        MSCML,

        [ContentMetadata(Value = "application/vnd.fdsn.mseed", IsBinary = true)]
        MSEED,

        [ContentMetadata(Value = "application/vnd.mseq", IsBinary = true)]
        MSEQ,

        [ContentMetadata(Value = "application/vnd.epson.msf", IsBinary = true)]
        MSF,

        [ContentMetadata(Value = "model/mesh", IsBinary = true)]
        MSH,

        [ContentMetadata(Value = "application/x-msdownload", IsBinary = true)]
        MSI,

        [ContentMetadata(Value = "application/vnd.mobius.msl", IsBinary = true)]
        MSL,

        [ContentMetadata(Value = "application/vnd.muvee.style", IsBinary = true)]
        MSTY,

        [ContentMetadata(Value = "model/vnd.mts", IsBinary = true)]
        MTS,

        [ContentMetadata(Value = "application/vnd.musician", IsBinary = true)]
        MUS,

        [ContentMetadata(Value = "application/vnd.recordare.musicxml+xml", IsText = true)]
        MUSICXML,

        [ContentMetadata(Value = "application/x-msmediaview", IsBinary = true)]
        MVB,

        [ContentMetadata(Value = "application/vnd.mfer", IsBinary = true)]
        MWF,

        [ContentMetadata(Value = "application/mxf", IsBinary = true)]
        MXF,

        [ContentMetadata(Value = "application/vnd.recordare.musicxml", IsText = true)]
        MXL,

        [ContentMetadata(Value = "application/xv+xml", IsText = true)]
        MXML,

        [ContentMetadata(Value = "application/vnd.triscape.mxs", IsBinary = true)]
        MXS,

        [ContentMetadata(Value = "video/vnd.mpegurl", IsBinary = true)]
        MXU,

        [ContentMetadata(Value = "text/n3", IsText = true)]
        N3,

        [ContentMetadata(Value = "application/mathematica", IsBinary = true)]
        NB,

        [ContentMetadata(Value = "application/vnd.wolfram.player", IsBinary = true)]
        NBP,

        [ContentMetadata(Value = "application/x-netcdf", IsBinary = true)]
        NC,

        [ContentMetadata(Value = "application/x-dtbncx+xml", IsText = true)]
        NCX,

        [ContentMetadata(Value = "text/x-nfo", IsText = true)]
        NFO,

        [ContentMetadata(Value = "application/vnd.nokia.n-gage.data", IsBinary = true)]
        NGDAT,

        [ContentMetadata(Value = "application/vnd.nitf", IsBinary = true)]
        NITF,

        [ContentMetadata(Value = "application/vnd.neurolanguage.nlu", IsBinary = true)]
        NLU,

        [ContentMetadata(Value = "application/vnd.enliven", IsBinary = true)]
        NML,

        [ContentMetadata(Value = "application/vnd.noblenet-directory", IsBinary = true)]
        NND,

        [ContentMetadata(Value = "application/vnd.noblenet-sealer", IsBinary = true)]
        NNS,

        [ContentMetadata(Value = "application/vnd.noblenet-web", IsBinary = true)]
        NNW,

        [ContentMetadata(Value = "image/vnd.net-fpx", IsBinary = true)]
        NPX,

        [ContentMetadata(Value = "application/x-conference", IsBinary = true)]
        NSC,

        [ContentMetadata(Value = "application/vnd.lotus-notes", IsBinary = true)]
        NSF,

        [ContentMetadata(Value = "application/vnd.nitf", IsBinary = true)]
        NTF,

        [ContentMetadata(Value = "application/x-nzb", IsBinary = true)]
        NZB,

        [ContentMetadata(Value = "application/vnd.fujitsu.oasys2", IsBinary = true)]
        OA2,

        [ContentMetadata(Value = "application/vnd.fujitsu.oasys3", IsBinary = true)]
        OA3,

        [ContentMetadata(Value = "application/vnd.fujitsu.oasys", IsBinary = true)]
        OAS,

        [ContentMetadata(Value = "application/x-msbinder", IsBinary = true)]
        OBD,

        [ContentMetadata(Value = "application/x-tgif", IsBinary = true)]
        OBJ,

        [ContentMetadata(Value = "application/oda", IsBinary = true)]
        ODA,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.database", IsBinary = true)]
        ODB,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.chart", IsBinary = true)]
        ODC,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.formula", IsBinary = true)]
        ODF,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.formula-template", IsBinary = true)]
        ODFT,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.graphics", IsBinary = true)]
        ODG,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.image", IsBinary = true)]
        ODI,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.text-master", IsBinary = true)]
        ODM,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.presentation", IsBinary = true)]
        ODP,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.spreadsheet", IsBinary = true)]
        ODS,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.text", IsBinary = true)]
        ODT,

        [ContentMetadata(Value = "audio/ogg", IsBinary = true)]
        OGA,

        [ContentMetadata(Value = "video/ogg", IsBinary = true)]
        OGG,

        [ContentMetadata(Value = "video/ogg", IsBinary = true)]
        OGV,

        [ContentMetadata(Value = "application/ogg", IsBinary = true)]
        OGX,

        [ContentMetadata(Value = "application/omdoc+xml", IsText = true)]
        OMDOC,

        [ContentMetadata(Value = "application/onenote", IsBinary = true)]
        ONEPKG,

        [ContentMetadata(Value = "application/onenote", IsBinary = true)]
        ONETMP,

        [ContentMetadata(Value = "application/onenote", IsBinary = true)]
        ONETOC,

        [ContentMetadata(Value = "application/onenote", IsBinary = true)]
        ONETOC2,

        [ContentMetadata(Value = "application/oebps-package+xml", IsText = true)]
        OPF,

        [ContentMetadata(Value = "text/x-opml", IsText = true)]
        OPML,

        [ContentMetadata(Value = "application/vnd.palm", IsBinary = true)]
        OPRC,

        [ContentMetadata(Value = "application/vnd.lotus-organizer", IsBinary = true)]
        ORG,

        [ContentMetadata(Value = "application/vnd.yamaha.openscoreformat", IsBinary = true)]
        OSF,

        [ContentMetadata(Value = "application/vnd.yamaha.openscoreformat.osfpvg+xml", IsText = true)]
        OSFPVG,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.chart-template", IsBinary = true)]
        OTC,

        [ContentMetadata(Value = "application/x-font-otf", IsBinary = true)]
        OTF,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.graphics-template", IsBinary = true)]
        OTG,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.text-web", IsBinary = true)]
        OTH,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.image-template", IsBinary = true)]
        OTI,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.presentation-template", IsBinary = true)]
        OTP,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.spreadsheet-template", IsBinary = true)]
        OTS,

        [ContentMetadata(Value = "application/vnd.oasis.opendocument.text-template", IsBinary = true)]
        OTT,

        [ContentMetadata(Value = "application/oxps", IsBinary = true)]
        OXPS,

        [ContentMetadata(Value = "application/vnd.openofficeorg.extension", IsBinary = true)]
        OXT,

        [ContentMetadata(Value = "text/x-pascal", IsText = true)]
        P,

        [ContentMetadata(Value = "application/pkcs10", IsBinary = true)]
        P10,

        [ContentMetadata(Value = "application/x-pkcs12", IsBinary = true)]
        P12,

        [ContentMetadata(Value = "application/x-pkcs7-certificates", IsBinary = true)]
        P7B,

        [ContentMetadata(Value = "application/pkcs7-mime", IsBinary = true)]
        P7C,

        [ContentMetadata(Value = "application/pkcs7-mime", IsBinary = true)]
        P7M,

        [ContentMetadata(Value = "application/x-pkcs7-certreqresp", IsBinary = true)]
        P7R,

        [ContentMetadata(Value = "application/pkcs7-signature", IsBinary = true)]
        P7S,

        [ContentMetadata(Value = "application/pkcs8", IsBinary = true)]
        P8,

        [ContentMetadata(Value = "text/x-pascal", IsText = true)]
        PAS,

        [ContentMetadata(Value = "application/vnd.pawaafile", IsBinary = true)]
        PAW,

        [ContentMetadata(Value = "application/vnd.powerbuilder6", IsBinary = true)]
        PBD,

        [ContentMetadata(Value = "image/x-portable-bitmap", IsBinary = true)]
        PBM,

        [ContentMetadata(Value = "application/vnd.tcpdump.pcap", IsBinary = true)]
        PCAP,

        [ContentMetadata(Value = "application/x-font-pcf", IsBinary = true)]
        PCF,

        [ContentMetadata(Value = "application/vnd.hp-pcl", IsBinary = true)]
        PCL,

        [ContentMetadata(Value = "application/vnd.hp-pclxl", IsBinary = true)]
        PCLXL,

        [ContentMetadata(Value = "image/x-pict", IsBinary = true)]
        PCT,

        [ContentMetadata(Value = "application/vnd.curl.pcurl", IsBinary = true)]
        PCURL,

        [ContentMetadata(Value = "image/x-pcx", IsBinary = true)]
        PCX,

        [ContentMetadata(Value = "applicaton/octet-stream", IsBinary = true)]
        PDB,

        [ContentMetadata(Value = "application/pdf", IsBinary = true)]
        PDF,

        [ContentMetadata(Value = "application/x-font-type1", IsBinary = true)]
        PFA,

        [ContentMetadata(Value = "application/x-font-type1", IsBinary = true)]
        PFB,

        [ContentMetadata(Value = "application/x-font-type1", IsBinary = true)]
        PFM,

        [ContentMetadata(Value = "application/font-tdpfr", IsBinary = true)]
        PFR,

        [ContentMetadata(Value = "application/x-pkcs12", IsBinary = true)]
        PFX,

        [ContentMetadata(Value = "image/x-portable-graymap", IsBinary = true)]
        PGM,

        [ContentMetadata(Value = "application/x-chess-pgn", IsBinary = true)]
        PGN,

        [ContentMetadata(Value = "application/pgp-encrypted", IsBinary = true)]
        PGP,

        [ContentMetadata(Value = "image/x-pict", IsBinary = true)]
        PIC,

        [ContentMetadata(Value = "image/pict", IsBinary = true)]
        PICT,

        [ContentMetadata(Value = "application/octet-stream", IsBinary = true)]
        PKG,

        [ContentMetadata(Value = "application/pkixcmp", IsBinary = true)]
        PKI,

        [ContentMetadata(Value = "application/pkix-pkipath", IsBinary = true)]
        PKIPATH,

        [ContentMetadata(Value = "application/vnd.3gpp.pic-bw-large", IsBinary = true)]
        PLB,

        [ContentMetadata(Value = "application/vnd.mobius.plc", IsBinary = true)]
        PLC,

        [ContentMetadata(Value = "application/vnd.pocketlearn", IsBinary = true)]
        PLF,

        [ContentMetadata(Value = "application/pls+xml", IsText = true)]
        PLS,

        [ContentMetadata(Value = "application/vnd.ctc-posml", IsBinary = true)]
        PML,

        [ContentMetadata(Value = "image/png", IsBinary = true)]
        PNG,

        [ContentMetadata(Value = "image/x-portable-anymap", IsBinary = true)]
        PNM,

        [ContentMetadata(Value = "image/x-macpaint", IsBinary = true)]
        PNT,

        [ContentMetadata(Value = "image/x-macpaint", IsBinary = true)]
        PNTG,

        [ContentMetadata(Value = "application/vnd.macports.portpkg", IsBinary = true)]
        PORTPKG,

        [ContentMetadata(Value = "application/vnd.ms-powerpoint", IsBinary = true)]
        POT,

        [ContentMetadata(Value = "application/vnd.ms-powerpoint.template.macroenabled.12", IsBinary = true)]
        POTM,

        [ContentMetadata(Value = "application/vnd.openxmlformats-officedocument.presentationml.template", IsBinary = true)]
        POTX,

        [ContentMetadata(Value = "application/vnd.ms-powerpoint.addin.macroenabled.12", IsBinary = true)]
        PPAM,

        [ContentMetadata(Value = "application/vnd.cups-ppd", IsBinary = true)]
        PPD,

        [ContentMetadata(Value = "image/x-portable-pixmap", IsBinary = true)]
        PPM,

        [ContentMetadata(Value = "application/vnd.ms-powerpoint", IsBinary = true)]
        PPS,

        [ContentMetadata(Value = "application/vnd.ms-powerpoint.slideshow.macroenabled.12", IsBinary = true)]
        PPSM,

        [ContentMetadata(Value = "application/vnd.openxmlformats-officedocument.presentationml.slideshow", IsBinary = true)]
        PPSX,

        [ContentMetadata(Value = "application/vnd.ms-powerpoint", IsBinary = true)]
        PPT,

        [ContentMetadata(Value = "application/vnd.ms-powerpoint.presentation.macroenabled.12", IsBinary = true)]
        PPTM,

        [ContentMetadata(Value = "application/vnd.openxmlformats-officedocument.presentationml.presentation", IsBinary = true)]
        PPTX,

        [ContentMetadata(Value = "application/vnd.palm", IsBinary = true)]
        PQA,

        [ContentMetadata(Value = "application/x-mobipocket-ebook", IsBinary = true)]
        PRC,

        [ContentMetadata(Value = "application/vnd.lotus-freelance", IsBinary = true)]
        PRE,

        [ContentMetadata(Value = "application/pics-rules", IsBinary = true)]
        PRF,

        [ContentMetadata(Value = "application/postscript", IsBinary = true)]
        PS,

        [ContentMetadata(Value = "application/vnd.3gpp.pic-bw-small", IsBinary = true)]
        PSB,

        [ContentMetadata(Value = "image/vnd.adobe.photoshop", IsBinary = true)]
        PSD,

        [ContentMetadata(Value = "application/x-font-linux-psf", IsBinary = true)]
        PSF,

        [ContentMetadata(Value = "application/pskc+xml", IsText = true)]
        PSKCXML,

        [ContentMetadata(Value = "application/vnd.pvi.ptid1", IsBinary = true)]
        PTID,

        [ContentMetadata(Value = "application/x-mspublisher", IsBinary = true)]
        PUB,

        [ContentMetadata(Value = "application/vnd.3gpp.pic-bw-var", IsBinary = true)]
        PVB,

        [ContentMetadata(Value = "application/vnd.3m.post-it-notes", IsBinary = true)]
        PWN,

        [ContentMetadata(Value = "audio/vnd.ms-playready.media.pya", IsBinary = true)]
        PYA,

        [ContentMetadata(Value = "video/vnd.ms-playready.media.pyv", IsBinary = true)]
        PYV,

        [ContentMetadata(Value = "application/vnd.epson.quickanime", IsBinary = true)]
        QAM,

        [ContentMetadata(Value = "application/vnd.intu.qbo", IsBinary = true)]
        QBO,

        [ContentMetadata(Value = "application/vnd.intu.qfx", IsBinary = true)]
        QFX,

        [ContentMetadata(Value = "application/vnd.publishare-delta-tree", IsBinary = true)]
        QPS,

        [ContentMetadata(Value = "video/quicktime", IsBinary = true)]
        QT,

        [ContentMetadata(Value = "image/x-quicktime", IsBinary = true)]
        QTI,

        [ContentMetadata(Value = "image/x-quicktime", IsBinary = true)]
        QTIF,

        [ContentMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QWD,

        [ContentMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QWT,

        [ContentMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QXB,

        [ContentMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QXD,

        [ContentMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QXL,

        [ContentMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QXT,

        [ContentMetadata(Value = "audio/x-pn-realaudio", IsBinary = true)]
        RA,

        [ContentMetadata(Value = "audio/x-pn-realaudio", IsBinary = true)]
        RAM,

        [ContentMetadata(Value = "application/x-rar-compressed", IsBinary = true)]
        RAR,

        [ContentMetadata(Value = "image/x-cmu-raster", IsBinary = true)]
        RAS,

        [ContentMetadata(Value = "application/vnd.ipunplugged.rcprofile", IsBinary = true)]
        RCPROFILE,

        [ContentMetadata(Value = "application/rdf+xml", IsText = true)]
        RDF,

        [ContentMetadata(Value = "application/vnd.data-vision.rdz", IsBinary = true)]
        RDZ,

        [ContentMetadata(Value = "application/vnd.businessobjects", IsBinary = true)]
        REP,

        [ContentMetadata(Value = "application/x-dtbresource+xml", IsText = true)]
        RES,

        [ContentMetadata(Value = "image/x-rgb", IsBinary = true)]
        RGB,

        [ContentMetadata(Value = "application/reginfo+xml", IsText = true)]
        RIF,

        [ContentMetadata(Value = "audio/vnd.rip", IsBinary = true)]
        RIP,

        [ContentMetadata(Value = "application/x-research-info-systems", IsBinary = true)]
        RIS,

        [ContentMetadata(Value = "application/resource-lists+xml", IsText = true)]
        RL,

        [ContentMetadata(Value = "image/vnd.fujixerox.edmics-rlc", IsBinary = true)]
        RLC,

        [ContentMetadata(Value = "application/resource-lists-diff+xml", IsText = true)]
        RLD,

        [ContentMetadata(Value = "application/vnd.rn-realmedia", IsBinary = true)]
        RM,

        [ContentMetadata(Value = "audio/midi", IsBinary = true)]
        RMI,

        [ContentMetadata(Value = "audio/x-pn-realaudio-plugin", IsBinary = true)]
        RMP,

        [ContentMetadata(Value = "application/vnd.jcp.javame.midlet-rms", IsBinary = true)]
        RMS,

        [ContentMetadata(Value = "application/vnd.rn-realmedia-vbr", IsBinary = true)]
        RMVB,

        [ContentMetadata(Value = "application/relax-ng-compact-syntax", IsBinary = true)]
        RNC,

        [ContentMetadata(Value = "application/rpki-roa", IsBinary = true)]
        ROA,

        [ContentMetadata(Value = "application/x-troff", IsBinary = true)]
        ROFF,

        [ContentMetadata(Value = "application/vnd.cloanto.rp9", IsBinary = true)]
        RP9,

        [ContentMetadata(Value = "application/vnd.nokia.radio-presets", IsBinary = true)]
        RPSS,

        [ContentMetadata(Value = "application/vnd.nokia.radio-preset", IsBinary = true)]
        RPST,

        [ContentMetadata(Value = "application/sparql-query", IsBinary = true)]
        RQ,

        [ContentMetadata(Value = "application/rls-services+xml", IsText = true)]
        RS,

        [ContentMetadata(Value = "application/rsd+xml", IsText = true)]
        RSD,

        [ContentMetadata(Value = "application/rss+xml", IsText = true)]
        RSS,

        [ContentMetadata(Value = "application/rtf", IsBinary = true)]
        RTF,

        [ContentMetadata(Value = "text/richtext", IsText = true)]
        RTX,

        [ContentMetadata(Value = "text/x-asm", IsText = true)]
        S,

        [ContentMetadata(Value = "audio/s3m", IsBinary = true)]
        S3M,

        [ContentMetadata(Value = "application/vnd.yamaha.smaf-audio", IsBinary = true)]
        SAF,

        [ContentMetadata(Value = "application/sbml+xml", IsText = true)]
        SBML,

        [ContentMetadata(Value = "application/vnd.ibm.secure-container", IsBinary = true)]
        SC,

        [ContentMetadata(Value = "application/x-msschedule", IsBinary = true)]
        SCD,

        [ContentMetadata(Value = "application/vnd.lotus-screencam", IsBinary = true)]
        SCM,

        [ContentMetadata(Value = "application/scvp-cv-request", IsBinary = true)]
        SCQ,

        [ContentMetadata(Value = "application/scvp-cv-response", IsBinary = true)]
        SCS,

        [ContentMetadata(Value = "text/vnd.curl.scurl", IsText = true)]
        SCURL,

        [ContentMetadata(Value = "application/vnd.stardivision.draw", IsBinary = true)]
        SDA,

        [ContentMetadata(Value = "application/vnd.stardivision.calc", IsBinary = true)]
        SDC,

        [ContentMetadata(Value = "application/vnd.stardivision.impress", IsBinary = true)]
        SDD,

        [ContentMetadata(Value = "application/vnd.solent.sdkm+xml", IsText = true)]
        SDKD,

        [ContentMetadata(Value = "application/vnd.solent.sdkm+xml", IsText = true)]
        SDKM,

        [ContentMetadata(Value = "application/sdp", IsBinary = true)]
        SDP,

        [ContentMetadata(Value = "application/vnd.stardivision.writer", IsBinary = true)]
        SDW,

        [ContentMetadata(Value = "application/vnd.seemail", IsBinary = true)]
        SEE,

        [ContentMetadata(Value = "application/vnd.fdsn.seed", IsBinary = true)]
        SEED,

        [ContentMetadata(Value = "application/vnd.sema", IsBinary = true)]
        SEMA,

        [ContentMetadata(Value = "application/vnd.semd", IsBinary = true)]
        SEMD,

        [ContentMetadata(Value = "application/vnd.semf", IsBinary = true)]
        SEMF,

        [ContentMetadata(Value = "application/java-serialized-object", IsBinary = true)]
        SER,

        [ContentMetadata(Value = "application/set-payment-initiation", IsBinary = true)]
        SETPAY,

        [ContentMetadata(Value = "application/set-registration-initiation", IsBinary = true)]
        SETREG,

        [ContentMetadata(Value = "application/vnd.spotfire.sfs", IsBinary = true)]
        SFS,

        [ContentMetadata(Value = "text/x-sfv", IsText = true)]
        SFV,

        [ContentMetadata(Value = "image/sgi", IsBinary = true)]
        SGI,

        [ContentMetadata(Value = "application/vnd.stardivision.writer-global", IsBinary = true)]
        SGL,

        [ContentMetadata(Value = "text/sgml", IsText = true)]
        SGM,

        [ContentMetadata(Value = "text/sgml", IsText = true)]
        SGML,

        [ContentMetadata(Value = "application/x-sh", IsBinary = true)]
        SH,

        [ContentMetadata(Value = "application/x-shar", IsBinary = true)]
        SHAR,

        [ContentMetadata(Value = "application/shf+xml", IsText = true)]
        SHF,

        [ContentMetadata(Value = "image/x-mrsid-image", IsBinary = true)]
        SID,

        [ContentMetadata(Value = "application/pgp-signature", IsBinary = true)]
        SIG,

        [ContentMetadata(Value = "audio/silk", IsBinary = true)]
        SIL,

        [ContentMetadata(Value = "model/mesh", IsBinary = true)]
        SILO,

        [ContentMetadata(Value = "application/vnd.symbian.install", IsBinary = true)]
        SIS,

        [ContentMetadata(Value = "application/vnd.symbian.install", IsBinary = true)]
        SISX,

        [ContentMetadata(Value = "application/x-stuffit", IsBinary = true)]
        SIT,

        [ContentMetadata(Value = "application/x-stuffitx", IsBinary = true)]
        SITX,

        [ContentMetadata(Value = "application/x-koan", IsBinary = true)]
        SKD,

        [ContentMetadata(Value = "application/x-koan", IsBinary = true)]
        SKM,

        [ContentMetadata(Value = "application/x-koan", IsBinary = true)]
        SKP,

        [ContentMetadata(Value = "application/x-koan", IsBinary = true)]
        SKT,

        [ContentMetadata(Value = "application/vnd.ms-powerpoint.slide.macroenabled.12", IsBinary = true)]
        SLDM,

        [ContentMetadata(Value = "application/vnd.openxmlformats-officedocument.presentationml.slide", IsBinary = true)]
        SLDX,

        [ContentMetadata(Value = "application/vnd.epson.salt", IsBinary = true)]
        SLT,

        [ContentMetadata(Value = "application/vnd.stepmania.stepchart", IsBinary = true)]
        SM,

        [ContentMetadata(Value = "application/vnd.stardivision.math", IsBinary = true)]
        SMF,

        [ContentMetadata(Value = "application/smil+xml", IsText = true)]
        SMI,

        [ContentMetadata(Value = "application/smil+xml", IsText = true)]
        SMIL,

        [ContentMetadata(Value = "video/x-smv", IsBinary = true)]
        SMV,

        [ContentMetadata(Value = "application/vnd.stepmania.package", IsBinary = true)]
        SMZIP,

        [ContentMetadata(Value = "audio/basic", IsBinary = true)]
        SND,

        [ContentMetadata(Value = "application/x-font-snf", IsBinary = true)]
        SNF,

        [ContentMetadata(Value = "application/octet-stream", IsBinary = true)]
        SO,

        [ContentMetadata(Value = "application/x-pkcs7-certificates", IsBinary = true)]
        SPC,

        [ContentMetadata(Value = "application/vnd.yamaha.smaf-phrase", IsBinary = true)]
        SPF,

        [ContentMetadata(Value = "application/x-futuresplash", IsBinary = true)]
        SPL,

        [ContentMetadata(Value = "text/vnd.in3d.spot", IsText = true)]
        SPOT,

        [ContentMetadata(Value = "application/scvp-vp-response", IsBinary = true)]
        SPP,

        [ContentMetadata(Value = "application/scvp-vp-request", IsBinary = true)]
        SPQ,

        [ContentMetadata(Value = "audio/ogg", IsBinary = true)]
        SPX,

        [ContentMetadata(Value = "application/x-sql", IsBinary = true)]
        SQL,

        [ContentMetadata(Value = "application/x-wais-source", IsBinary = true)]
        SRC,

        [ContentMetadata(Value = "application/x-subrip", IsBinary = true)]
        SRT,

        [ContentMetadata(Value = "application/sru+xml", IsText = true)]
        SRU,

        [ContentMetadata(Value = "application/sparql-results+xml", IsText = true)]
        SRX,

        [ContentMetadata(Value = "application/ssdl+xml", IsText = true)]
        SSDL,

        [ContentMetadata(Value = "application/vnd.kodak-descriptor", IsBinary = true)]
        SSE,

        [ContentMetadata(Value = "application/vnd.epson.ssf", IsBinary = true)]
        SSF,

        [ContentMetadata(Value = "application/ssml+xml", IsText = true)]
        SSML,

        [ContentMetadata(Value = "application/vnd.sailingtracker.track", IsBinary = true)]
        ST,

        [ContentMetadata(Value = "application/vnd.sun.xml.calc.template", IsBinary = true)]
        STC,

        [ContentMetadata(Value = "application/vnd.sun.xml.draw.template", IsBinary = true)]
        STD,

        [ContentMetadata(Value = "application/vnd.wt.stf", IsBinary = true)]
        STF,

        [ContentMetadata(Value = "application/vnd.sun.xml.impress.template", IsBinary = true)]
        STI,

        [ContentMetadata(Value = "application/hyperstudio", IsBinary = true)]
        STK,

        [ContentMetadata(Value = "application/vnd.ms-pki.stl", IsBinary = true)]
        STL,

        [ContentMetadata(Value = "application/vnd.pg.format", IsBinary = true)]
        STR,

        [ContentMetadata(Value = "application/vnd.sun.xml.writer.template", IsBinary = true)]
        STW,

        [ContentMetadata(Value = "text/vnd.dvb.subtitle", IsText = true)]
        SUB,

        [ContentMetadata(Value = "application/vnd.sus-calendar", IsBinary = true)]
        SUS,

        [ContentMetadata(Value = "application/vnd.sus-calendar", IsBinary = true)]
        SUSP,

        [ContentMetadata(Value = "application/x-sv4cpio", IsBinary = true)]
        SV4CPIO,

        [ContentMetadata(Value = "application/x-sv4crc", IsBinary = true)]
        SV4CRC,

        [ContentMetadata(Value = "application/vnd.dvb.service", IsBinary = true)]
        SVC,

        [ContentMetadata(Value = "application/vnd.svd", IsBinary = true)]
        SVD,

        [ContentMetadata(Value = "image/svg+xml", IsText = true)]
        SVG,

        [ContentMetadata(Value = "image/svg+xml", IsText = true)]
        SVGZ,

        [ContentMetadata(Value = "application/x-director", IsBinary = true)]
        SWA,

        [ContentMetadata(Value = "application/x-shockwave-flash", IsBinary = true)]
        SWF,

        [ContentMetadata(Value = "application/vnd.aristanetworks.swi", IsBinary = true)]
        SWI,

        [ContentMetadata(Value = "application/vnd.sun.xml.calc", IsBinary = true)]
        SXC,

        [ContentMetadata(Value = "application/vnd.sun.xml.draw", IsBinary = true)]
        SXD,

        [ContentMetadata(Value = "application/vnd.sun.xml.writer.global", IsBinary = true)]
        SXG,

        [ContentMetadata(Value = "application/vnd.sun.xml.impress", IsBinary = true)]
        SXI,

        [ContentMetadata(Value = "application/vnd.sun.xml.math", IsBinary = true)]
        SXM,

        [ContentMetadata(Value = "application/vnd.sun.xml.writer", IsBinary = true)]
        SXW,

        [ContentMetadata(Value = "application/x-troff", IsBinary = true)]
        T,

        [ContentMetadata(Value = "application/x-t3vm-image", IsBinary = true)]
        T3,

        [ContentMetadata(Value = "application/vnd.mynfc", IsBinary = true)]
        TAGLET,

        [ContentMetadata(Value = "application/vnd.tao.intent-module-archive", IsBinary = true)]
        TAO,

        [ContentMetadata(Value = "application/x-tar", IsBinary = true)]
        TAR,

        [ContentMetadata(Value = "application/vnd.3gpp2.tcap", IsBinary = true)]
        TCAP,

        [ContentMetadata(Value = "application/x-tcl", IsBinary = true)]
        TCL,

        [ContentMetadata(Value = "application/vnd.smart.teacher", IsBinary = true)]
        TEACHER,

        [ContentMetadata(Value = "application/tei+xml", IsText = true)]
        TEI,

        [ContentMetadata(Value = "application/tei+xml", IsText = true)]
        TEICORPUS,

        [ContentMetadata(Value = "application/x-tex", IsBinary = true)]
        TEX,

        [ContentMetadata(Value = "application/x-texinfo", IsBinary = true)]
        TEXI,

        [ContentMetadata(Value = "application/x-texinfo", IsBinary = true)]
        TEXINFO,

        [ContentMetadata(Value = "text/plain", IsText = true)]
        TEXT,

        [ContentMetadata(Value = "application/thraud+xml", IsText = true)]
        TFI,

        [ContentMetadata(Value = "application/x-tex-tfm", IsBinary = true)]
        TFM,

        [ContentMetadata(Value = "image/x-tga", IsBinary = true)]
        TGA,

        [ContentMetadata(Value = "application/vnd.ms-officetheme", IsBinary = true)]
        THMX,

        [ContentMetadata(Value = "image/tiff", IsBinary = true)]
        TIF,

        [ContentMetadata(Value = "image/tiff", IsBinary = true)]
        TIFF,

        [ContentMetadata(Value = "application/vnd.tmobile-livetv", IsBinary = true)]
        TMO,

        [ContentMetadata(Value = "application/x-bittorrent", IsBinary = true)]
        TORRENT,

        [ContentMetadata(Value = "application/vnd.groove-tool-template", IsBinary = true)]
        TPL,

        [ContentMetadata(Value = "application/vnd.trid.tpt", IsBinary = true)]
        TPT,

        [ContentMetadata(Value = "application/x-troff", IsBinary = true)]
        TR,

        [ContentMetadata(Value = "application/vnd.trueapp", IsBinary = true)]
        TRA,

        [ContentMetadata(Value = "application/x-msterminal", IsBinary = true)]
        TRM,

        [ContentMetadata(Value = "application/timestamped-data", IsBinary = true)]
        TSD,

        [ContentMetadata(Value = "text/tab-separated-values", IsText = true)]
        TSV,

        [ContentMetadata(Value = "application/x-font-ttf", IsBinary = true)]
        TTC,

        [ContentMetadata(Value = "application/x-font-ttf", IsBinary = true)]
        TTF,

        [ContentMetadata(Value = "text/turtle", IsText = true)]
        TTL,

        [ContentMetadata(Value = "application/vnd.simtech-mindmapper", IsBinary = true)]
        TWD,

        [ContentMetadata(Value = "application/vnd.simtech-mindmapper", IsBinary = true)]
        TWDS,

        [ContentMetadata(Value = "application/vnd.genomatix.tuxedo", IsBinary = true)]
        TXD,

        [ContentMetadata(Value = "application/vnd.mobius.txf", IsBinary = true)]
        TXF,

        [ContentMetadata(Value = "text/plain", IsText = true)]
        TXT,

        [ContentMetadata(Value = "application/x-authorware-bin", IsBinary = true)]
        U32,

        [ContentMetadata(Value = "application/x-debian-package", IsBinary = true)]
        UDEB,

        [ContentMetadata(Value = "application/vnd.ufdl", IsBinary = true)]
        UFD,

        [ContentMetadata(Value = "application/vnd.ufdl", IsBinary = true)]
        UFDL,

        [ContentMetadata(Value = "application/x-glulx", IsBinary = true)]
        ULX,

        [ContentMetadata(Value = "application/vnd.umajin", IsBinary = true)]
        UMJ,

        [ContentMetadata(Value = "application/vnd.unity", IsBinary = true)]
        UNITYWEB,

        [ContentMetadata(Value = "application/vnd.uoml+xml", IsText = true)]
        UOML,

        [ContentMetadata(Value = "text/uri-list", IsText = true)]
        URI,

        [ContentMetadata(Value = "text/uri-list", IsText = true)]
        URIS,

        [ContentMetadata(Value = "text/uri-list", IsText = true)]
        URLS,

        [ContentMetadata(Value = "application/x-ustar", IsBinary = true)]
        USTAR,

        [ContentMetadata(Value = "application/vnd.uiq.theme", IsBinary = true)]
        UTZ,

        [ContentMetadata(Value = "text/x-uuencode", IsText = true)]
        UU,

        [ContentMetadata(Value = "audio/vnd.dece.audio", IsBinary = true)]
        UVA,

        [ContentMetadata(Value = "application/vnd.dece.data", IsBinary = true)]
        UVD,

        [ContentMetadata(Value = "application/vnd.dece.data", IsBinary = true)]
        UVF,

        [ContentMetadata(Value = "image/vnd.dece.graphic", IsBinary = true)]
        UVG,

        [ContentMetadata(Value = "video/vnd.dece.hd", IsBinary = true)]
        UVH,

        [ContentMetadata(Value = "image/vnd.dece.graphic", IsBinary = true)]
        UVI,

        [ContentMetadata(Value = "video/vnd.dece.mobile", IsBinary = true)]
        UVM,

        [ContentMetadata(Value = "video/vnd.dece.pd", IsBinary = true)]
        UVP,

        [ContentMetadata(Value = "video/vnd.dece.sd", IsBinary = true)]
        UVS,

        [ContentMetadata(Value = "application/vnd.dece.ttml+xml", IsText = true)]
        UVT,

        [ContentMetadata(Value = "video/vnd.uvvu.mp4", IsBinary = true)]
        UVU,

        [ContentMetadata(Value = "video/vnd.dece.video", IsBinary = true)]
        UVV,

        [ContentMetadata(Value = "audio/vnd.dece.audio", IsBinary = true)]
        UVVA,

        [ContentMetadata(Value = "application/vnd.dece.data", IsBinary = true)]
        UVVD,

        [ContentMetadata(Value = "application/vnd.dece.data", IsBinary = true)]
        UVVF,

        [ContentMetadata(Value = "image/vnd.dece.graphic", IsBinary = true)]
        UVVG,

        [ContentMetadata(Value = "video/vnd.dece.hd", IsBinary = true)]
        UVVH,

        [ContentMetadata(Value = "image/vnd.dece.graphic", IsBinary = true)]
        UVVI,

        [ContentMetadata(Value = "video/vnd.dece.mobile", IsBinary = true)]
        UVVM,

        [ContentMetadata(Value = "video/vnd.dece.pd", IsBinary = true)]
        UVVP,

        [ContentMetadata(Value = "video/vnd.dece.sd", IsBinary = true)]
        UVVS,

        [ContentMetadata(Value = "application/vnd.dece.ttml+xml", IsText = true)]
        UVVT,

        [ContentMetadata(Value = "video/vnd.uvvu.mp4", IsBinary = true)]
        UVVU,

        [ContentMetadata(Value = "video/vnd.dece.video", IsBinary = true)]
        UVVV,

        [ContentMetadata(Value = "application/vnd.dece.unspecified", IsBinary = true)]
        UVVX,

        [ContentMetadata(Value = "application/vnd.dece.zip", IsBinary = true)]
        UVVZ,

        [ContentMetadata(Value = "application/vnd.dece.unspecified", IsBinary = true)]
        UVX,

        [ContentMetadata(Value = "application/vnd.dece.zip", IsBinary = true)]
        UVZ,

        [ContentMetadata(Value = "text/vcard", IsText = true)]
        VCARD,

        [ContentMetadata(Value = "application/x-cdlink", IsBinary = true)]
        VCD,

        [ContentMetadata(Value = "text/x-vcard", IsText = true)]
        VCF,

        [ContentMetadata(Value = "application/vnd.groove-vcard", IsBinary = true)]
        VCG,

        [ContentMetadata(Value = "text/x-vcalendar", IsText = true)]
        VCS,

        [ContentMetadata(Value = "application/vnd.vcx", IsBinary = true)]
        VCX,

        [ContentMetadata(Value = "application/vnd.visionary", IsBinary = true)]
        VIS,

        [ContentMetadata(Value = "video/vnd.vivo", IsBinary = true)]
        VIV,

        [ContentMetadata(Value = "video/x-ms-vob", IsBinary = true)]
        VOB,

        [ContentMetadata(Value = "application/vnd.stardivision.writer", IsBinary = true)]
        VOR,

        [ContentMetadata(Value = "application/x-authorware-bin", IsBinary = true)]
        VOX,

        [ContentMetadata(Value = "model/vrml", IsBinary = true)]
        VRML,

        [ContentMetadata(Value = "application/vnd.visio", IsBinary = true)]
        VSD,

        [ContentMetadata(Value = "application/vnd.vsf", IsBinary = true)]
        VSF,

        [ContentMetadata(Value = "application/vnd.visio", IsBinary = true)]
        VSS,

        [ContentMetadata(Value = "application/vnd.visio", IsBinary = true)]
        VST,

        [ContentMetadata(Value = "application/vnd.visio", IsBinary = true)]
        VSW,

        [ContentMetadata(Value = "model/vnd.vtu", IsBinary = true)]
        VTU,

        [ContentMetadata(Value = "application/voicexml+xml", IsText = true)]
        VXML,

        [ContentMetadata(Value = "application/x-director", IsBinary = true)]
        W3D,

        [ContentMetadata(Value = "application/x-doom", IsBinary = true)]
        WAD,

        [ContentMetadata(Value = "audio/x-wav", IsBinary = true)]
        WAV,

        [ContentMetadata(Value = "audio/x-ms-wax", IsBinary = true)]
        WAX,

        [ContentMetadata(Value = "image/vnd.wap.wbmp", IsBinary = true)]
        WBMP,

        [ContentMetadata(Value = "application/vnd.wap.wbxml", IsText = true)]
        WBMXL,

        [ContentMetadata(Value = "application/vnd.criticaltools.wbs+xml", IsText = true)]
        WBS,

        [ContentMetadata(Value = "application/vnd.wap.wbxml", IsText = true)]
        WBXML,

        [ContentMetadata(Value = "application/vnd.ms-works", IsBinary = true)]
        WCM,

        [ContentMetadata(Value = "application/vnd.ms-works", IsBinary = true)]
        WDB,

        [ContentMetadata(Value = "image/vnd.ms-photo", IsBinary = true)]
        WDP,

        [ContentMetadata(Value = "audio/webm", IsBinary = true)]
        WEBA,

        [ContentMetadata(Value = "video/webm", IsBinary = true)]
        WEBM,

        [ContentMetadata(Value = "image/webp", IsBinary = true)]
        WEBP,

        [ContentMetadata(Value = "application/vnd.pmi.widget", IsBinary = true)]
        WG,

        [ContentMetadata(Value = "application/widget", IsBinary = true)]
        WGT,

        [ContentMetadata(Value = "application/vnd.ms-works", IsBinary = true)]
        WKS,

        [ContentMetadata(Value = "video/x-ms-wm", IsBinary = true)]
        WM,

        [ContentMetadata(Value = "audio/x-ms-wma", IsBinary = true)]
        WMA,

        [ContentMetadata(Value = "application/x-ms-wmd", IsBinary = true)]
        WMD,

        [ContentMetadata(Value = "application/x-msmetafile", IsBinary = true)]
        WMF,

        [ContentMetadata(Value = "text/vnd.wap.wml", IsText = true)]
        WML,

        [ContentMetadata(Value = "application/vnd.wap.wmlc", IsBinary = true)]
        WMLC,

        [ContentMetadata(Value = "text/vnd.wap.wmlscript", IsText = true)]
        WMLS,

        [ContentMetadata(Value = "application/vnd.wap.wmlscriptc", IsBinary = true)]
        WMLSC,

        [ContentMetadata(Value = "video/x-ms-wmv", IsBinary = true)]
        WMV,

        [ContentMetadata(Value = "video/x-ms-wmx", IsBinary = true)]
        WMX,

        [ContentMetadata(Value = "application/x-msmetafile", IsBinary = true)]
        WMZ,

        [ContentMetadata(Value = "application/font-woff", IsBinary = true)]
        WOFF,

        [ContentMetadata(Value = "application/vnd.wordperfect", IsBinary = true)]
        WPD,

        [ContentMetadata(Value = "application/vnd.ms-wpl", IsBinary = true)]
        WPL,

        [ContentMetadata(Value = "application/vnd.ms-works", IsBinary = true)]
        WPS,

        [ContentMetadata(Value = "application/vnd.wqd", IsBinary = true)]
        WQD,

        [ContentMetadata(Value = "application/x-mswrite", IsBinary = true)]
        WRI,

        [ContentMetadata(Value = "model/vrml", IsBinary = true)]
        WRL,

        [ContentMetadata(Value = "application/wsdl+xml", IsText = true)]
        WSDL,

        [ContentMetadata(Value = "application/wspolicy+xml", IsText = true)]
        WSPOLICY,

        [ContentMetadata(Value = "application/vnd.webturbo", IsBinary = true)]
        WTB,

        [ContentMetadata(Value = "video/x-ms-wvx", IsBinary = true)]
        WVX,

        [ContentMetadata(Value = "application/x-authorware-bin", IsBinary = true)]
        X32,

        [ContentMetadata(Value = "model/x3d+xml", IsText = true)]
        X3D,

        [ContentMetadata(Value = "model/x3d+binary", IsBinary = true)]
        X3DB,

        [ContentMetadata(Value = "model/x3d+binary", IsBinary = true)]
        X3DBZ,

        [ContentMetadata(Value = "model/x3d+vrml", IsBinary = true)]
        X3DV,

        [ContentMetadata(Value = "model/x3d+vrml", IsBinary = true)]
        X3DVZ,

        [ContentMetadata(Value = "model/x3d+xml", IsText = true)]
        X3DZ,

        [ContentMetadata(Value = "application/xaml+xml", IsText = true)]
        XAML,

        [ContentMetadata(Value = "application/x-silverlight-app", IsBinary = true)]
        XAP,

        [ContentMetadata(Value = "application/vnd.xara", IsBinary = true)]
        XAR,

        [ContentMetadata(Value = "application/x-ms-xbap", IsBinary = true)]
        XBAP,

        [ContentMetadata(Value = "application/vnd.fujixerox.docuworks.binder", IsBinary = true)]
        XBD,

        [ContentMetadata(Value = "image/x-xbitmap", IsBinary = true)]
        XBM,

        [ContentMetadata(Value = "application/xcap-diff+xml", IsText = true)]
        XDF,

        [ContentMetadata(Value = "application/vnd.syncml.dm+xml", IsText = true)]
        XDM,

        [ContentMetadata(Value = "application/vnd.adobe.xdp+xml", IsText = true)]
        XDP,

        [ContentMetadata(Value = "application/dssc+xml", IsText = true)]
        XDSSC,

        [ContentMetadata(Value = "application/vnd.fujixerox.docuworks", IsBinary = true)]
        XDW,

        [ContentMetadata(Value = "application/xenc+xml", IsText = true)]
        XENC,

        [ContentMetadata(Value = "application/patch-ops-error+xml", IsText = true)]
        XER,

        [ContentMetadata(Value = "application/vnd.adobe.xfdf", IsBinary = true)]
        XFDF,

        [ContentMetadata(Value = "application/vnd.xfdl", IsBinary = true)]
        XFDL,

        [ContentMetadata(Value = "application/xhtml+xml", IsText = true)]
        XHT,

        [ContentMetadata(Value = "application/xhtml+xml", IsText = true)]
        XHTML,

        [ContentMetadata(Value = "application/xv+xml", IsText = true)]
        XHVML,

        [ContentMetadata(Value = "image/vnd.xiff", IsBinary = true)]
        XIF,

        [ContentMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLA,

        [ContentMetadata(Value = "application/vnd.ms-excel.addin.macroenabled.12", IsBinary = true)]
        XLAM,

        [ContentMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLC,

        [ContentMetadata(Value = "application/x-xliff+xml", IsText = true)]
        XLF,

        [ContentMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLM,

        [ContentMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLS,

        [ContentMetadata(Value = "application/vnd.ms-excel.sheet.binary.macroenabled.12", IsBinary = true)]
        XLSB,

        [ContentMetadata(Value = "application/vnd.ms-excel.sheet.macroenabled.12", IsBinary = true)]
        XLSM,

        [ContentMetadata(Value = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", IsBinary = true)]
        XLSX,

        [ContentMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLT,

        [ContentMetadata(Value = "application/vnd.ms-excel.template.macroenabled.12", IsBinary = true)]
        XLTM,

        [ContentMetadata(Value = "application/vnd.openxmlformats-officedocument.spreadsheetml.template", IsBinary = true)]
        XLTX,

        [ContentMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLW,

        [ContentMetadata(Value = "audio/xm", IsBinary = true)]
        XM,

        [ContentMetadata(Value = "application/xml", IsText = true)]
        XML,

        [ContentMetadata(Value = "application/x-www-form-urlencoded", IsBinary = true)]
        X_WWW_FORM_URLENCODED,

        [ContentMetadata(Value = "application/vnd.olpc-sugar", IsBinary = true)]
        XO,

        [ContentMetadata(Value = "application/xop+xml", IsText = true)]
        XOP,

        [ContentMetadata(Value = "application/x-xpinstall", IsBinary = true)]
        XPI,

        [ContentMetadata(Value = "application/xproc+xml", IsText = true)]
        XPL,

        [ContentMetadata(Value = "image/x-xpixmap", IsBinary = true)]
        XPM,

        [ContentMetadata(Value = "application/vnd.is-xpr", IsBinary = true)]
        XPR,

        [ContentMetadata(Value = "application/vnd.ms-xpsdocument", IsBinary = true)]
        XPS,

        [ContentMetadata(Value = "application/vnd.intercon.formnet", IsBinary = true)]
        XPW,

        [ContentMetadata(Value = "application/vnd.intercon.formnet", IsBinary = true)]
        XPX,

        [ContentMetadata(Value = "application/xml", IsText = true)]
        XSL,

        [ContentMetadata(Value = "application/xslt+xml", IsText = true)]
        XSLT,

        [ContentMetadata(Value = "application/vnd.syncml+xml", IsText = true)]
        XSM,

        [ContentMetadata(Value = "application/xspf+xml", IsText = true)]
        XSPF,

        [ContentMetadata(Value = "application/vnd.mozilla.xul+xml", IsText = true)]
        XUL,

        [ContentMetadata(Value = "application/xv+xml", IsText = true)]
        XVM,

        [ContentMetadata(Value = "application/xv+xml", IsText = true)]
        XVML,

        [ContentMetadata(Value = "image/x-xwindowdump", IsBinary = true)]
        XWD,

        [ContentMetadata(Value = "chemical/x-xyz", IsBinary = true)]
        XYZ,

        [ContentMetadata(Value = "application/x-xz", IsBinary = true)]
        XZ,

        [ContentMetadata(Value = "application/yang", IsBinary = true)]
        YANG,

        [ContentMetadata(Value = "application/yin+xml", IsText = true)]
        YIN,

        [ContentMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z1,

        [ContentMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z2,

        [ContentMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z3,

        [ContentMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z4,

        [ContentMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z5,

        [ContentMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z6,

        [ContentMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z7,

        [ContentMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z8,

        [ContentMetadata(Value = "application/vnd.zzazz.deck+xml", IsText = true)]
        ZAZ,

        [ContentMetadata(Value = "application/zip", IsBinary = true)]
        ZIP,

        [ContentMetadata(Value = "application/vnd.zul", IsBinary = true)]
        ZIR,

        [ContentMetadata(Value = "application/vnd.zul", IsBinary = true)]
        ZIRZ,

        [ContentMetadata(Value = "application/vnd.handheld-entertainment+xml", IsText = true)]
        ZMM,

        [ContentMetadata(Value = "application/octet-stream", IsBinary = true)]
        DEFAULT
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    class ContentMetadata : Attribute
    {
        public ContentMetadata()
        {
            this.Value = "text/plain";
            this.IsText = true;
        }

        public string Value { get; set; }
        public bool IsText { get; set; }
        public bool IsBinary
        {
            get
            {
                return !this.IsText;
            }
            set
            {
                this.IsText = !value;
            }
        }
    }

    public static class ContentTypeExtensions
    {
        private static object GetContentMetadata(ContentType ct)
        {
            var type = ct.GetType();
            MemberInfo[] info = type.GetMember(ct.ToString());
            if ((info != null) && (info.Length > 0))
            {
                object[] attrs = info[0].GetCustomAttributes(typeof(ContentMetadata), false);
                if ((attrs != null) && (attrs.Length > 0))
                {
                    return attrs[0];
                }
            }
            return null;
        }

        public static string ToValue(this ContentType ct)
        {
            var ContentMetadata = GetContentMetadata(ct);
            return (ContentMetadata != null) ? ((ContentMetadata)ContentMetadata).Value : ct.ToString();
        }

        public static bool IsText(this ContentType ct)
        {
            var ContentMetadata = GetContentMetadata(ct);
            return (ContentMetadata != null) ? ((ContentMetadata)ContentMetadata).IsText : true;
        }

        public static bool IsBinary(this ContentType ct)
        {
            var ContentMetadata = GetContentMetadata(ct);
            return (ContentMetadata != null) ? ((ContentMetadata)ContentMetadata).IsBinary : false;
        }
    }
}