//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ./BinShred.g4 by ANTLR 4.5.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.1")]
[System.CLSCompliant(false)]
public partial class BinShredLexer : Lexer {
	public const int
		QUOTEDVALUE=1, COMMA=2, QUOTE=3, COLON=4, SEMI=5, LPAREN=6, RPAREN=7, 
		BYTES=8, ITEMS=9, AS=10, DESCRIBED=11, BY=12, ASCII=13, UNICODE=14, UTF8=15, 
		UINT64=16, UINT32=17, UINT16=18, INT64=19, INT32=20, INT16=21, SINGLE=22, 
		FLOAT=23, DOUBLE=24, ADDITIONAL=25, PROPERTIES=26, IDENTIFIED=27, FROM=28, 
		PADDING=29, TO=30, MULTIPLE=31, OF=32, WS=33, DOC_COMMENT=34, BLOCK_COMMENT=35, 
		LINE_COMMENT=36, INT=37, HEXADECIMAL=38, LABEL=39;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"QUOTEDVALUE", "COMMA", "QUOTE", "COLON", "SEMI", "LPAREN", "RPAREN", 
		"BYTES", "ITEMS", "AS", "DESCRIBED", "BY", "ASCII", "UNICODE", "UTF8", 
		"UINT64", "UINT32", "UINT16", "INT64", "INT32", "INT16", "SINGLE", "FLOAT", 
		"DOUBLE", "ADDITIONAL", "PROPERTIES", "IDENTIFIED", "FROM", "PADDING", 
		"TO", "MULTIPLE", "OF", "WS", "DOC_COMMENT", "BLOCK_COMMENT", "LINE_COMMENT", 
		"INT", "HEXADECIMAL", "LABEL", "A", "B", "C", "D", "E", "F", "G", "H", 
		"I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", 
		"W", "X", "Y", "Z"
	};


	public BinShredLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, "','", "'\"'", "':'", "';'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "QUOTEDVALUE", "COMMA", "QUOTE", "COLON", "SEMI", "LPAREN", "RPAREN", 
		"BYTES", "ITEMS", "AS", "DESCRIBED", "BY", "ASCII", "UNICODE", "UTF8", 
		"UINT64", "UINT32", "UINT16", "INT64", "INT32", "INT16", "SINGLE", "FLOAT", 
		"DOUBLE", "ADDITIONAL", "PROPERTIES", "IDENTIFIED", "FROM", "PADDING", 
		"TO", "MULTIPLE", "OF", "WS", "DOC_COMMENT", "BLOCK_COMMENT", "LINE_COMMENT", 
		"INT", "HEXADECIMAL", "LABEL"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "BinShred.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2)\x1B5\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x4-\t-\x4.\t.\x4/\t/\x4\x30\t\x30\x4\x31\t\x31\x4\x32"+
		"\t\x32\x4\x33\t\x33\x4\x34\t\x34\x4\x35\t\x35\x4\x36\t\x36\x4\x37\t\x37"+
		"\x4\x38\t\x38\x4\x39\t\x39\x4:\t:\x4;\t;\x4<\t<\x4=\t=\x4>\t>\x4?\t?\x4"+
		"@\t@\x4\x41\t\x41\x4\x42\t\x42\x3\x2\x3\x2\x6\x2\x88\n\x2\r\x2\xE\x2\x89"+
		"\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a"+
		"\x3\b\x3\b\x3\t\x3\t\x3\t\x3\t\x3\t\x5\t\x9F\n\t\x3\n\x3\n\x3\n\x3\n\x3"+
		"\n\x3\n\x3\v\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3"+
		"\f\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF"+
		"\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x11"+
		"\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12"+
		"\x3\x12\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13"+
		"\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x15"+
		"\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17"+
		"\x3\x17\x3\x17\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3\x18\x3\x18\x3\x18"+
		"\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3\x1A"+
		"\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1A\x3\x1B"+
		"\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B"+
		"\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x3\x1C"+
		"\x3\x1C\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E"+
		"\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3 \x3 "+
		"\x3 \x3 \x3 \x3 \x3!\x3!\x3!\x3\"\x6\"\x143\n\"\r\"\xE\"\x144\x3\"\x3"+
		"\"\x3#\x3#\x3#\x3#\x3#\a#\x14E\n#\f#\xE#\x151\v#\x3#\x3#\x3#\x3$\x3$\x3"+
		"$\x3$\a$\x15A\n$\f$\xE$\x15D\v$\x3$\x3$\x3$\x3$\x3$\x3%\x3%\x3%\x3%\a"+
		"%\x168\n%\f%\xE%\x16B\v%\x3%\x3%\x3&\x6&\x170\n&\r&\xE&\x171\x3\'\x3\'"+
		"\x3\'\x6\'\x177\n\'\r\'\xE\'\x178\x3(\x3(\a(\x17D\n(\f(\xE(\x180\v(\x3"+
		")\x3)\x3*\x3*\x3+\x3+\x3,\x3,\x3-\x3-\x3.\x3.\x3/\x3/\x3\x30\x3\x30\x3"+
		"\x31\x3\x31\x3\x32\x3\x32\x3\x33\x3\x33\x3\x34\x3\x34\x3\x35\x3\x35\x3"+
		"\x36\x3\x36\x3\x37\x3\x37\x3\x38\x3\x38\x3\x39\x3\x39\x3:\x3:\x3;\x3;"+
		"\x3<\x3<\x3=\x3=\x3>\x3>\x3?\x3?\x3@\x3@\x3\x41\x3\x41\x3\x42\x3\x42\x5"+
		"\x89\x14F\x15B\x2\x43\x3\x3\x5\x4\a\x5\t\x6\v\a\r\b\xF\t\x11\n\x13\v\x15"+
		"\f\x17\r\x19\xE\x1B\xF\x1D\x10\x1F\x11!\x12#\x13%\x14\'\x15)\x16+\x17"+
		"-\x18/\x19\x31\x1A\x33\x1B\x35\x1C\x37\x1D\x39\x1E;\x1F= ?!\x41\"\x43"+
		"#\x45$G%I&K\'M(O)Q\x2S\x2U\x2W\x2Y\x2[\x2]\x2_\x2\x61\x2\x63\x2\x65\x2"+
		"g\x2i\x2k\x2m\x2o\x2q\x2s\x2u\x2w\x2y\x2{\x2}\x2\x7F\x2\x81\x2\x83\x2"+
		"\x3\x2\"\x5\x2\v\f\xE\xF\"\"\x4\x2\f\f\xF\xF\x3\x2\x32;\x4\x2ZZzz\x5\x2"+
		"\x32;\x43H\x63h\x5\x2\x43\\\x61\x61\x63|\a\x2\x30\x30\x32;\x43\\\x61\x61"+
		"\x63|\x4\x2\x43\x43\x63\x63\x4\x2\x44\x44\x64\x64\x4\x2\x45\x45\x65\x65"+
		"\x4\x2\x46\x46\x66\x66\x4\x2GGgg\x4\x2HHhh\x4\x2IIii\x4\x2JJjj\x4\x2K"+
		"Kkk\x4\x2LLll\x4\x2MMmm\x4\x2NNnn\x4\x2OOoo\x4\x2PPpp\x4\x2QQqq\x4\x2"+
		"RRrr\x4\x2SSss\x4\x2TTtt\x4\x2UUuu\x4\x2VVvv\x4\x2WWww\x4\x2XXxx\x4\x2"+
		"YYyy\x4\x2[[{{\x4\x2\\\\||\x1A3\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2"+
		"\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF"+
		"\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2"+
		"\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2"+
		"\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2"+
		"\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2"+
		"/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2"+
		"\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2"+
		"\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2"+
		"\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2"+
		"O\x3\x2\x2\x2\x3\x85\x3\x2\x2\x2\x5\x8D\x3\x2\x2\x2\a\x8F\x3\x2\x2\x2"+
		"\t\x91\x3\x2\x2\x2\v\x93\x3\x2\x2\x2\r\x95\x3\x2\x2\x2\xF\x97\x3\x2\x2"+
		"\x2\x11\x99\x3\x2\x2\x2\x13\xA0\x3\x2\x2\x2\x15\xA6\x3\x2\x2\x2\x17\xA9"+
		"\x3\x2\x2\x2\x19\xB3\x3\x2\x2\x2\x1B\xB6\x3\x2\x2\x2\x1D\xBC\x3\x2\x2"+
		"\x2\x1F\xC4\x3\x2\x2\x2!\xC9\x3\x2\x2\x2#\xD0\x3\x2\x2\x2%\xD7\x3\x2\x2"+
		"\x2\'\xDE\x3\x2\x2\x2)\xE4\x3\x2\x2\x2+\xEA\x3\x2\x2\x2-\xF0\x3\x2\x2"+
		"\x2/\xF7\x3\x2\x2\x2\x31\xFD\x3\x2\x2\x2\x33\x104\x3\x2\x2\x2\x35\x10F"+
		"\x3\x2\x2\x2\x37\x11A\x3\x2\x2\x2\x39\x125\x3\x2\x2\x2;\x12A\x3\x2\x2"+
		"\x2=\x132\x3\x2\x2\x2?\x135\x3\x2\x2\x2\x41\x13E\x3\x2\x2\x2\x43\x142"+
		"\x3\x2\x2\x2\x45\x148\x3\x2\x2\x2G\x155\x3\x2\x2\x2I\x163\x3\x2\x2\x2"+
		"K\x16F\x3\x2\x2\x2M\x173\x3\x2\x2\x2O\x17A\x3\x2\x2\x2Q\x181\x3\x2\x2"+
		"\x2S\x183\x3\x2\x2\x2U\x185\x3\x2\x2\x2W\x187\x3\x2\x2\x2Y\x189\x3\x2"+
		"\x2\x2[\x18B\x3\x2\x2\x2]\x18D\x3\x2\x2\x2_\x18F\x3\x2\x2\x2\x61\x191"+
		"\x3\x2\x2\x2\x63\x193\x3\x2\x2\x2\x65\x195\x3\x2\x2\x2g\x197\x3\x2\x2"+
		"\x2i\x199\x3\x2\x2\x2k\x19B\x3\x2\x2\x2m\x19D\x3\x2\x2\x2o\x19F\x3\x2"+
		"\x2\x2q\x1A1\x3\x2\x2\x2s\x1A3\x3\x2\x2\x2u\x1A5\x3\x2\x2\x2w\x1A7\x3"+
		"\x2\x2\x2y\x1A9\x3\x2\x2\x2{\x1AB\x3\x2\x2\x2}\x1AD\x3\x2\x2\x2\x7F\x1AF"+
		"\x3\x2\x2\x2\x81\x1B1\x3\x2\x2\x2\x83\x1B3\x3\x2\x2\x2\x85\x87\x5\a\x4"+
		"\x2\x86\x88\v\x2\x2\x2\x87\x86\x3\x2\x2\x2\x88\x89\x3\x2\x2\x2\x89\x8A"+
		"\x3\x2\x2\x2\x89\x87\x3\x2\x2\x2\x8A\x8B\x3\x2\x2\x2\x8B\x8C\x5\a\x4\x2"+
		"\x8C\x4\x3\x2\x2\x2\x8D\x8E\a.\x2\x2\x8E\x6\x3\x2\x2\x2\x8F\x90\a$\x2"+
		"\x2\x90\b\x3\x2\x2\x2\x91\x92\a<\x2\x2\x92\n\x3\x2\x2\x2\x93\x94\a=\x2"+
		"\x2\x94\f\x3\x2\x2\x2\x95\x96\a*\x2\x2\x96\xE\x3\x2\x2\x2\x97\x98\a+\x2"+
		"\x2\x98\x10\x3\x2\x2\x2\x99\x9A\x5S*\x2\x9A\x9B\x5\x81\x41\x2\x9B\x9C"+
		"\x5w<\x2\x9C\x9E\x5Y-\x2\x9D\x9F\x5u;\x2\x9E\x9D\x3\x2\x2\x2\x9E\x9F\x3"+
		"\x2\x2\x2\x9F\x12\x3\x2\x2\x2\xA0\xA1\x5\x61\x31\x2\xA1\xA2\x5w<\x2\xA2"+
		"\xA3\x5Y-\x2\xA3\xA4\x5i\x35\x2\xA4\xA5\x5u;\x2\xA5\x14\x3\x2\x2\x2\xA6"+
		"\xA7\x5Q)\x2\xA7\xA8\x5u;\x2\xA8\x16\x3\x2\x2\x2\xA9\xAA\x5W,\x2\xAA\xAB"+
		"\x5Y-\x2\xAB\xAC\x5u;\x2\xAC\xAD\x5U+\x2\xAD\xAE\x5s:\x2\xAE\xAF\x5\x61"+
		"\x31\x2\xAF\xB0\x5S*\x2\xB0\xB1\x5Y-\x2\xB1\xB2\x5W,\x2\xB2\x18\x3\x2"+
		"\x2\x2\xB3\xB4\x5S*\x2\xB4\xB5\x5\x81\x41\x2\xB5\x1A\x3\x2\x2\x2\xB6\xB7"+
		"\x5Q)\x2\xB7\xB8\x5u;\x2\xB8\xB9\x5U+\x2\xB9\xBA\x5\x61\x31\x2\xBA\xBB"+
		"\x5\x61\x31\x2\xBB\x1C\x3\x2\x2\x2\xBC\xBD\x5y=\x2\xBD\xBE\x5k\x36\x2"+
		"\xBE\xBF\x5\x61\x31\x2\xBF\xC0\x5U+\x2\xC0\xC1\x5m\x37\x2\xC1\xC2\x5W"+
		",\x2\xC2\xC3\x5Y-\x2\xC3\x1E\x3\x2\x2\x2\xC4\xC5\x5y=\x2\xC5\xC6\x5w<"+
		"\x2\xC6\xC7\x5[.\x2\xC7\xC8\a:\x2\x2\xC8 \x3\x2\x2\x2\xC9\xCA\x5y=\x2"+
		"\xCA\xCB\x5\x61\x31\x2\xCB\xCC\x5k\x36\x2\xCC\xCD\x5w<\x2\xCD\xCE\a\x38"+
		"\x2\x2\xCE\xCF\a\x36\x2\x2\xCF\"\x3\x2\x2\x2\xD0\xD1\x5y=\x2\xD1\xD2\x5"+
		"\x61\x31\x2\xD2\xD3\x5k\x36\x2\xD3\xD4\x5w<\x2\xD4\xD5\a\x35\x2\x2\xD5"+
		"\xD6\a\x34\x2\x2\xD6$\x3\x2\x2\x2\xD7\xD8\x5y=\x2\xD8\xD9\x5\x61\x31\x2"+
		"\xD9\xDA\x5k\x36\x2\xDA\xDB\x5w<\x2\xDB\xDC\a\x33\x2\x2\xDC\xDD\a\x38"+
		"\x2\x2\xDD&\x3\x2\x2\x2\xDE\xDF\x5\x61\x31\x2\xDF\xE0\x5k\x36\x2\xE0\xE1"+
		"\x5w<\x2\xE1\xE2\a\x38\x2\x2\xE2\xE3\a\x36\x2\x2\xE3(\x3\x2\x2\x2\xE4"+
		"\xE5\x5\x61\x31\x2\xE5\xE6\x5k\x36\x2\xE6\xE7\x5w<\x2\xE7\xE8\a\x35\x2"+
		"\x2\xE8\xE9\a\x34\x2\x2\xE9*\x3\x2\x2\x2\xEA\xEB\x5\x61\x31\x2\xEB\xEC"+
		"\x5k\x36\x2\xEC\xED\x5w<\x2\xED\xEE\a\x33\x2\x2\xEE\xEF\a\x38\x2\x2\xEF"+
		",\x3\x2\x2\x2\xF0\xF1\x5u;\x2\xF1\xF2\x5\x61\x31\x2\xF2\xF3\x5k\x36\x2"+
		"\xF3\xF4\x5]/\x2\xF4\xF5\x5g\x34\x2\xF5\xF6\x5Y-\x2\xF6.\x3\x2\x2\x2\xF7"+
		"\xF8\x5[.\x2\xF8\xF9\x5g\x34\x2\xF9\xFA\x5m\x37\x2\xFA\xFB\x5Q)\x2\xFB"+
		"\xFC\x5w<\x2\xFC\x30\x3\x2\x2\x2\xFD\xFE\x5W,\x2\xFE\xFF\x5m\x37\x2\xFF"+
		"\x100\x5y=\x2\x100\x101\x5S*\x2\x101\x102\x5g\x34\x2\x102\x103\x5Y-\x2"+
		"\x103\x32\x3\x2\x2\x2\x104\x105\x5Q)\x2\x105\x106\x5W,\x2\x106\x107\x5"+
		"W,\x2\x107\x108\x5\x61\x31\x2\x108\x109\x5w<\x2\x109\x10A\x5\x61\x31\x2"+
		"\x10A\x10B\x5m\x37\x2\x10B\x10C\x5k\x36\x2\x10C\x10D\x5Q)\x2\x10D\x10E"+
		"\x5g\x34\x2\x10E\x34\x3\x2\x2\x2\x10F\x110\x5o\x38\x2\x110\x111\x5s:\x2"+
		"\x111\x112\x5m\x37\x2\x112\x113\x5o\x38\x2\x113\x114\x5Y-\x2\x114\x115"+
		"\x5s:\x2\x115\x116\x5w<\x2\x116\x117\x5\x61\x31\x2\x117\x118\x5Y-\x2\x118"+
		"\x119\x5u;\x2\x119\x36\x3\x2\x2\x2\x11A\x11B\x5\x61\x31\x2\x11B\x11C\x5"+
		"W,\x2\x11C\x11D\x5Y-\x2\x11D\x11E\x5k\x36\x2\x11E\x11F\x5w<\x2\x11F\x120"+
		"\x5\x61\x31\x2\x120\x121\x5[.\x2\x121\x122\x5\x61\x31\x2\x122\x123\x5"+
		"Y-\x2\x123\x124\x5W,\x2\x124\x38\x3\x2\x2\x2\x125\x126\x5[.\x2\x126\x127"+
		"\x5s:\x2\x127\x128\x5m\x37\x2\x128\x129\x5i\x35\x2\x129:\x3\x2\x2\x2\x12A"+
		"\x12B\x5o\x38\x2\x12B\x12C\x5Q)\x2\x12C\x12D\x5W,\x2\x12D\x12E\x5W,\x2"+
		"\x12E\x12F\x5\x61\x31\x2\x12F\x130\x5k\x36\x2\x130\x131\x5]/\x2\x131<"+
		"\x3\x2\x2\x2\x132\x133\x5w<\x2\x133\x134\x5m\x37\x2\x134>\x3\x2\x2\x2"+
		"\x135\x136\x5i\x35\x2\x136\x137\x5y=\x2\x137\x138\x5g\x34\x2\x138\x139"+
		"\x5w<\x2\x139\x13A\x5\x61\x31\x2\x13A\x13B\x5o\x38\x2\x13B\x13C\x5g\x34"+
		"\x2\x13C\x13D\x5Y-\x2\x13D@\x3\x2\x2\x2\x13E\x13F\x5m\x37\x2\x13F\x140"+
		"\x5[.\x2\x140\x42\x3\x2\x2\x2\x141\x143\t\x2\x2\x2\x142\x141\x3\x2\x2"+
		"\x2\x143\x144\x3\x2\x2\x2\x144\x142\x3\x2\x2\x2\x144\x145\x3\x2\x2\x2"+
		"\x145\x146\x3\x2\x2\x2\x146\x147\b\"\x2\x2\x147\x44\x3\x2\x2\x2\x148\x149"+
		"\a\x31\x2\x2\x149\x14A\a,\x2\x2\x14A\x14B\a,\x2\x2\x14B\x14F\x3\x2\x2"+
		"\x2\x14C\x14E\v\x2\x2\x2\x14D\x14C\x3\x2\x2\x2\x14E\x151\x3\x2\x2\x2\x14F"+
		"\x150\x3\x2\x2\x2\x14F\x14D\x3\x2\x2\x2\x150\x152\x3\x2\x2\x2\x151\x14F"+
		"\x3\x2\x2\x2\x152\x153\a,\x2\x2\x153\x154\a\x31\x2\x2\x154\x46\x3\x2\x2"+
		"\x2\x155\x156\a\x31\x2\x2\x156\x157\a,\x2\x2\x157\x15B\x3\x2\x2\x2\x158"+
		"\x15A\v\x2\x2\x2\x159\x158\x3\x2\x2\x2\x15A\x15D\x3\x2\x2\x2\x15B\x15C"+
		"\x3\x2\x2\x2\x15B\x159\x3\x2\x2\x2\x15C\x15E\x3\x2\x2\x2\x15D\x15B\x3"+
		"\x2\x2\x2\x15E\x15F\a,\x2\x2\x15F\x160\a\x31\x2\x2\x160\x161\x3\x2\x2"+
		"\x2\x161\x162\b$\x2\x2\x162H\x3\x2\x2\x2\x163\x164\a\x31\x2\x2\x164\x165"+
		"\a\x31\x2\x2\x165\x169\x3\x2\x2\x2\x166\x168\n\x3\x2\x2\x167\x166\x3\x2"+
		"\x2\x2\x168\x16B\x3\x2\x2\x2\x169\x167\x3\x2\x2\x2\x169\x16A\x3\x2\x2"+
		"\x2\x16A\x16C\x3\x2\x2\x2\x16B\x169\x3\x2\x2\x2\x16C\x16D\b%\x2\x2\x16D"+
		"J\x3\x2\x2\x2\x16E\x170\t\x4\x2\x2\x16F\x16E\x3\x2\x2\x2\x170\x171\x3"+
		"\x2\x2\x2\x171\x16F\x3\x2\x2\x2\x171\x172\x3\x2\x2\x2\x172L\x3\x2\x2\x2"+
		"\x173\x174\a\x32\x2\x2\x174\x176\t\x5\x2\x2\x175\x177\t\x6\x2\x2\x176"+
		"\x175\x3\x2\x2\x2\x177\x178\x3\x2\x2\x2\x178\x176\x3\x2\x2\x2\x178\x179"+
		"\x3\x2\x2\x2\x179N\x3\x2\x2\x2\x17A\x17E\t\a\x2\x2\x17B\x17D\t\b\x2\x2"+
		"\x17C\x17B\x3\x2\x2\x2\x17D\x180\x3\x2\x2\x2\x17E\x17C\x3\x2\x2\x2\x17E"+
		"\x17F\x3\x2\x2\x2\x17FP\x3\x2\x2\x2\x180\x17E\x3\x2\x2\x2\x181\x182\t"+
		"\t\x2\x2\x182R\x3\x2\x2\x2\x183\x184\t\n\x2\x2\x184T\x3\x2\x2\x2\x185"+
		"\x186\t\v\x2\x2\x186V\x3\x2\x2\x2\x187\x188\t\f\x2\x2\x188X\x3\x2\x2\x2"+
		"\x189\x18A\t\r\x2\x2\x18AZ\x3\x2\x2\x2\x18B\x18C\t\xE\x2\x2\x18C\\\x3"+
		"\x2\x2\x2\x18D\x18E\t\xF\x2\x2\x18E^\x3\x2\x2\x2\x18F\x190\t\x10\x2\x2"+
		"\x190`\x3\x2\x2\x2\x191\x192\t\x11\x2\x2\x192\x62\x3\x2\x2\x2\x193\x194"+
		"\t\x12\x2\x2\x194\x64\x3\x2\x2\x2\x195\x196\t\x13\x2\x2\x196\x66\x3\x2"+
		"\x2\x2\x197\x198\t\x14\x2\x2\x198h\x3\x2\x2\x2\x199\x19A\t\x15\x2\x2\x19A"+
		"j\x3\x2\x2\x2\x19B\x19C\t\x16\x2\x2\x19Cl\x3\x2\x2\x2\x19D\x19E\t\x17"+
		"\x2\x2\x19En\x3\x2\x2\x2\x19F\x1A0\t\x18\x2\x2\x1A0p\x3\x2\x2\x2\x1A1"+
		"\x1A2\t\x19\x2\x2\x1A2r\x3\x2\x2\x2\x1A3\x1A4\t\x1A\x2\x2\x1A4t\x3\x2"+
		"\x2\x2\x1A5\x1A6\t\x1B\x2\x2\x1A6v\x3\x2\x2\x2\x1A7\x1A8\t\x1C\x2\x2\x1A8"+
		"x\x3\x2\x2\x2\x1A9\x1AA\t\x1D\x2\x2\x1AAz\x3\x2\x2\x2\x1AB\x1AC\t\x1E"+
		"\x2\x2\x1AC|\x3\x2\x2\x2\x1AD\x1AE\t\x1F\x2\x2\x1AE~\x3\x2\x2\x2\x1AF"+
		"\x1B0\t\x5\x2\x2\x1B0\x80\x3\x2\x2\x2\x1B1\x1B2\t \x2\x2\x1B2\x82\x3\x2"+
		"\x2\x2\x1B3\x1B4\t!\x2\x2\x1B4\x84\x3\x2\x2\x2\f\x2\x89\x9E\x144\x14F"+
		"\x15B\x169\x171\x178\x17E\x3\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
