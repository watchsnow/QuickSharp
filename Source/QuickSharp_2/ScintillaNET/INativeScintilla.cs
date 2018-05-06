﻿using System;
using System.ComponentModel;
namespace ScintillaNet
{
	/// <summary>
	/// Interface representing the native Scintilla Message Based API. In addition
	/// to wrappers around each of the messages I have included an additional Method
	/// named SendMessageDirect with 9 overloads. This allows you to send messages
	/// to the Scintilla DefWndProc bypassing Windows' SendMessage. Each of the other
	/// methods wrap calls to SendMessageDirect.
	/// 
	/// Scintilla explicetly implements this interface. To use these methods on 
	/// a Scintilla control Cast it as INativeScintilla or use NativeScintilla
	/// property.
	/// 
	/// The reason for this interface is to keep the "regular" interface surface
	/// area of the Scintilla control as clean and .NETish as possible. Also
	/// this means when you want a direct native interface there's no other 
	/// absracted members (Aside from SendMessageDirect ;) cluttering the native
	/// interface.
	/// </summary>
	public interface INativeScintilla
	{
		void AddRefDocument(IntPtr pDoc);
		void AddStyledText(int length, byte[] s);
		void AddText(int length, string s);
		void Allocate(int bytes);
		void AppendText(int length, string s);
		void AssignCmdKey(int keyDefinition, int sciCommand);
		bool AutoCActive();
		void AutoCCancel();
		void AutoCComplete();
		bool AutoCGetAutoHide();
		bool AutoCGetCancelAtStart();
		bool AutoCGetChooseSingle();
		int AutoCGetCurrent();
		bool AutoCGetDropRestOfWord();
		bool AutoCGetIgnoreCase();
		int AutoCGetMaxHeight();
		int AutoCGetMaxWidth();
		char AutoCGetSeparator();
		char AutoCGetTypeSeparator();
		int AutoCPosStart();
		void AutoCSelect(string select);
		event EventHandler<NativeScintillaEventArgs> AutoCSelection;
		void AutoCSetAutoHide(bool autoHide);
		void AutoCSetCancelAtStart(bool cancel);
		void AutoCSetChooseSingle(bool chooseSingle);
		void AutoCSetDropRestOfWord(bool dropRestOfWord);
		void AutoCSetFillUps(string chars);
		void AutoCSetIgnoreCase(bool ignoreCase);
		void AutoCSetMaxHeight(int rowCount);
		void AutoCSetMaxWidth(int characterCount);
		void AutoCSetSeparator(char separator);
		void AutoCSetTypeSeparator(char separatorCharacter);
		void AutoCShow(int lenEntered, string list);
		void AutoCStops(string chars);
		void BackTab();
		void BeginUndoAction();
		void BraceBadLight(int pos1);
		void BraceHighlight(int pos1, int pos2);
		int BraceMatch(int pos, int maxReStyle);
		bool CallTipActive();
		void CallTipCancel();
		event EventHandler<NativeScintillaEventArgs> CallTipClick;
		int CallTipGetPosStart();
		void CallTipSetBack(int colour);
		void CallTipSetFore(int colour);
		void CallTipSetForeHlt(int colour);
		void CallTipSetHlt(int hlStart, int hlEnd);
		void CallTipShow(int posStart, string definition);
		void CallTipUseStyle(int tabsize);
		void Cancel();
		bool CanPaste();
		bool CanRedo();
		bool CanUndo();
		event EventHandler<NativeScintillaEventArgs> Change;
		event EventHandler<NativeScintillaEventArgs> CharAdded;
		void CharLeft();
		void CharLeftExtend();
		void CharLeftRectExtend();
		void CharRight();
		void CharRightExtend();
		void CharRightRectExtend();
		void ChooseCaretX();
		void Clear();
		void ClearAll();
		void ClearAllCmdKeys();
		void ClearCmdKey(int keyDefinition);
		void ClearDocumentStyle();
		void ClearRegisteredImages();
		void Colourise(int start, int end);
		void ConvertEols(int eolMode);
		void Copy();
		void CopyRange(int start, int end);
		void CopyText(int length, string text);
		IntPtr CreateDocument();
		void Cut();
		void DeleteBack();
		void DeleteBackNotLine();
		void DelLineLeft();
		void DelLineRight();
		void DelWordLeft();
		void DelWordRight();
		int DocLineFromVisible(int displayLine);
		void DocumentEnd();
		void DocumentEndExtend();
		void DocumentStart();
		void DocumentStartExtend();
		event EventHandler<NativeScintillaEventArgs> DoubleClick;
		event EventHandler<NativeScintillaEventArgs> DwellEnd;
		event EventHandler<NativeScintillaEventArgs> DwellStart;
		void EditToggleOvertype();
		void EmptyUndoBuffer();
		int EncodeFromUtf8(string utf8, out string encoded);
		void EndUndoAction();
		void EnsureVisible(int line);
		void EnsureVisibleEnforcePolicy(int line);
		int FindColumn(int line, int column);
		int FindText(int searchFlags, ref TextToFind ttf);
		int FormatRange(bool bDraw, ref RangeToFormat pfr);
		void FormFeed();
		int GetAnchor();
		bool GetBackSpaceUnIndents();
		bool GetBufferedDraw();
		int GetCaretFore();
		int GetCaretLineBack();
		int GetCaretLineBackAlpha();
		bool GetCaretLineVisible();
		int GetCaretPeriod();
		bool GetCaretSticky();
		int GetCaretStyle();
		int GetCaretWidth();
		char GetCharAt(int position);
		int GetCodePage();
		int GetColumn(int position);
		int GetControlCharSymbol();
		int GetCurLine(int textLen, out string text);
		int GetCurrentPos();
		int GetCursor();
		IntPtr GetDirectFunction();
		IntPtr GetDirectPointer();
		IntPtr GetDocPointer();
		int GetEdgeColour();
		int GetEdgeColumn();
		int GetEdgeMode();
		bool GetEndAtLastLine();
		int GetEndStyled();
		int GetEolMode();
		int GetFirstVisibleLine();
		bool GetFocus();
		bool GetFoldExpanded(int line);
		uint GetFoldLevel(int line);
		int GetFoldParent(int line);
		int GetHighlightGuide();
		int GetHotSpotActiveBack();
		int GetHotSpotActiveFore();		
		bool GetHotSpotActiveUnderline();
		bool GetHotSpotSingleLine();
		int GetIndicatorCurrent();
		int GetIndicatorValue();
		int GetPositionCache();
		bool GetHScrollBar();
		int GetIndent();
		bool GetIndentationGuides();
		int GetLastChild(int line, int level);
		int GetLayoutCache();
		int GetLength();
		int GetLexer();
		int GetLine(int line, out string text);
		int GetLineCount();
		int GetLineEndPosition(int line);
		int GetLineIndentation(int line);
		int GetLineIndentPosition(int line);
		int GetLineSelEndPosition(int line);
		int GetLineSelStartPosition(int line);
		int GetLineState(int line);
		bool GetLineVisible(int line);
		int GetMarginLeft();
		int GetMarginMaskN(int margin);
		int GetMarginRight();
		bool GetMarginSensitiveN(int margin);
		int GetMarginTypeN(int margin);
		int GetMarginWidthN(int margin);
		int GetMaxLineState();
		int GetModEventMask();
		bool GetModify();
		bool GetMouseDownCaptures();
		int GetMouseDwellTime();
		bool GetOvertype();
		bool GetPasteConvertEndings();
		int GetPrintColourMode();
		int GetPrintMagnification();
		int GetPrintWrapMode();
		void GetProperty(string key, out string value);
		void GetPropertyExpanded(string key, out string value);
		int GetPropertyInt(string key, int @default);
		bool GetReadOnly();
		int GetScrollWidth();
		int GetSearchFlags();
		int GetSelectionEnd();
		int GetSelectionMode();
		int GetSelectionStart();
		void GetSelText(out string text);
		int GetStatus();
		byte GetStyleAt(int position);
		[Obsolete("The modern style indicators make this obsolete, this should always be 7")]
		int GetStyleBits();
		int GetStyleBitsNeeded();
		void GetStyledText(ref TextRange tr);
		bool GetTabIndents();
		int GetTabWidth();
		int GetTargetEnd();
		int GetTargetStart();
		int GetText(int length, out string text);
		int GetTextLength();
		int GetTextRange(ref TextRange tr);
		bool GetTwoPhaseDraw();
		bool GetUndoCollection();
		bool GetUsePalette();
		bool GetUseTabs();
		bool GetViewEol();
		int GetViewWS();
		bool GetVScrollBar();
		int GetWrapMode();
		int GetWrapStartIndent();
		int GetWrapVisualFlags();
		int GetWrapVisualFlagsLocation();
		int GetXOffset();
		int GetZoom();
		void GotoLine(int line);
		void GotoPos(int position);
		void GrabFocus();
		void HideLines(int lineStart, int lineEnd);
		void HideSelection(bool hide);
		void Home();
		void HomeDisplay();
		void HomeDisplayExtend();
		void HomeExtend();
		void HomeRectExtend();
		void HomeWrap();
		void HomeWrapExtend();
		event EventHandler<NativeScintillaEventArgs> HotSpotClick;
		event EventHandler<NativeScintillaEventArgs> HotSpotDoubleclick;
		uint IndicatorAllOnFor(int position);
		void IndicatorClearRange(int position, int fillLength);
		event EventHandler<NativeScintillaEventArgs> IndicatorClick;
		void IndicatorFillRange(int position, int fillLength);
		int IndicatorEnd(int indicator, int position);
		event EventHandler<NativeScintillaEventArgs> IndicatorRelease;
		int IndicatorStart(int indicator, int position);
		int IndicatorValueAt(int indicator, int position);
		int IndicGetFore(int indicatorNumber);
		int IndicGetStyle(int indicatorNumber);
		bool IndicGetUnder(int indicatorNumber);
		void IndicSetFore(int indicatorNumber, int colour);
		void IndicSetStyle(int indicatorNumber, int indicatorStyle);
		void IndicSetUnder(int indicatorNumber, bool under);
		void InsertText(int pos, string text);
		event EventHandler<NativeScintillaEventArgs> Key;
		void LineCopy();
		void LineCut();
		void LineDelete();
		void LineDown();
		void LineDownExtend();
		void LineDownRectExtend();
		void LineDuplicate();
		void LineEnd();
		void LineEndDisplay();
		void LineEndDisplayExtend();
		void LineEndExtend();
		void LineEndRectExtend();
		void LineEndWrap();
		void LineEndWrapExtend();
		int LineFromPosition(int pos);
		int LineLength(int line);
		void LineScroll(int columns, int lines);
		void LineScrollDown();
		void LineScrollUp();
		void LinesJoin();
		int LinesOnScreen();
		void LinesSplit(int pixelWidth);
		void LineTranspose();
		void LineUp();
		void LineUpExtend();
		void LineUpRectExtend();
		void LoadLexerLibrary(string path);
		void LowerCase();
		event EventHandler<NativeScintillaEventArgs> MacroRecord;
		event EventHandler<NativeScintillaEventArgs> MarginClick;
		int MarkerAdd(int line, int markerNumber);
		void MarkerAddSet(int line, uint markerMask);
		void MarkerDefine(int markerNumber, int markerSymbol);
		void MarkerDefinePixmap(int markerNumber, string xpm);
		void MarkerDelete(int line, int markerNumber);
		void MarkerDeleteAll(int markerNumber);
		void MarkerDeleteHandle(int handle);
		int MarkerGet(int line);
		int MarkerLineFromHandle(int handle);
		int MarkerNext(int lineStart, uint markerMask);
		int MarkerPrevious(int lineStart, uint markerMask);
		void MarkerSetAlpha(int markerNumber, int alpha);
		void MarkerSetBack(int markerNumber, int colour);
		void MarkerSetFore(int markerNumber, int colour);
		event EventHandler<NativeScintillaEventArgs> Modified;
		event EventHandler<NativeScintillaEventArgs> ModifyAttemptRO;
		void MoveCaretInsideView();
		event EventHandler<NativeScintillaEventArgs> NeedShown;
		void NewLine();
		void Null();
		void PageDown();
		void PageDownExtend();
		void PageDownRectExtend();
		void PageUp();
		void PageUpExtend();
		void PageUpRectExtend();
		event EventHandler<NativeScintillaEventArgs> Painted;
		void ParaDown();
		void ParaDownExtend();
		void ParaUp();
		void ParaUpExtend();
		void Paste();
		int PointXFromPosition(int position);
		int PointYFromPosition(int position);
		int PositionAfter(int position);
		int PositionBefore(int position);
		int PositionFromLine(int line);
		int PositionFromPoint(int x, int y);
		int PositionFromPointClose(int x, int y);
		void Redo();
		void RegisterImage(int type, string xpmData);
		void ReleaseDocument(IntPtr pDoc);
		void ReplaceSel(string text);
		int ReplaceTarget(int length, string text);
		int ReplaceTargetRE(int length, string text);
		event EventHandler<NativeScintillaEventArgs> SavePointLeft;
		event EventHandler<NativeScintillaEventArgs> SavePointReached;
		void ScrollCaret();
		void SearchAnchor();
		int SearchInTarget(int length, string text);
		int SearchNext(int searchFlags, string text);
		int SearchPrev(int searchFlags, string text);
		void SelectAll();
		void SelectionDuplicate();
		bool SelectionIsRectangle();
		IntPtr SendMessageDirect(uint msg, IntPtr wParam, IntPtr lParam);
		int SendMessageDirect(uint msg);
		int SendMessageDirect(uint msg, int wParam);
		int SendMessageDirect(uint msg, VOID wParam, int lParam);
		int SendMessageDirect(uint msg, VOID wParam, string lParam);
		int SendMessageDirect(uint msg, int wParam, int lParam);
		int SendMessageDirect(uint msg, int wParam, uint lParam);
		int SendMessageDirect(uint msg, bool wParam, int lParam);
		int SendMessageDirect(uint msg, int wParam, bool lParam);
		int SendMessageDirect(uint msg, string wParam);
		int SendMessageDirect(uint msg, bool wParam);
		int SendMessageDirect(uint msg, string wParam, int lParam);
		int SendMessageDirect(uint msg, int wParam, string lParam);
		int SendMessageDirect(uint msg, int wParam, out string text);
		int SendMessageDirect(uint msg, out string text);
		int SendMessageDirect(uint msg, IntPtr wParam, out string lParam, int length);
		int SendMessageDirect(uint msg, string wParam, out string lParam);
		int SendMessageDirect(uint msg, string wParam, string lParam);
		void SetAnchor(int position);
		void SetBackSpaceUnIndents(bool bsUnIndents);
		void SetBufferedDraw(bool isBuffered);
		void SetCaretFore(int alpha);
		void SetCaretLineBack(int show);
		void SetCaretLineBackAlpha(int alpha);
		void SetCaretLineVisible(bool colour);
		void SetCaretPeriod(int milliseconds);
		void SetCaretSticky(bool useCaretStickyBehaviour);
		void SetCaretStyle(int style);
		void SetCaretWidth(int pixels);
		void SetCharsDefault();
		void SetCodePage(int codePage);
		void SetControlCharSymbol(int symbol);
		void SetCurrentPos(int position);
		void SetCursor(int curType);
		void SetDocPointer(IntPtr pDoc);
		void SetEdgeColour(int colour);
		void SetEdgeColumn(int column);
		void SetEdgeMode(int mode);
		void SetEndAtLastLine(bool endAtLastLine);
		void SetEolMode(int eolMode);
		void SetFocus(bool focus);
		void SetFoldExpanded(int line, bool expanded);
		void SetFoldFlags(int flags);
		void SetFoldLevel(int line, uint level);
		void SetFoldMarginColour(bool useSetting, int colour);
		void SetFoldMarginHiColour(bool useSetting, int colour);
		void SetHighlightGuide(int column);
		void SetHotspotActiveBack(bool useHotSpotBackColour, int colour);
		void SetHotspotActiveFore(bool useHotSpotForeColour, int colour);
		void SetHotspotActiveUnderline(bool underline);
		void SetHotspotSingleLine(bool singleLine);
		void SetHScrollBar(bool visible);
		void SetIndent(int widthInChars);
		void SetIndentationGuides(bool view);
		void SetIndicatorCurrent(int indicator);
		void SetIndicatorValue(int value);
		void SetKeywords(int keywordSet, string keyWordList);
		void SetLayoutCache(int cacheMode);
		int SetLengthForEncode(int bytes);
		void SetLexer(int lexer);
		void SetLexerLanguage(string name);
		void SetLineIndentation(int line, int indentation);
		void SetLineState(int line, int value);
		void SetMarginLeft(int pixels);
		void SetMarginMaskN(int margin, int mask);
		void SetMarginRight(int pixels);
		void SetMarginSensitiveN(int margin, bool sensitive);
		void SetMarginTypeN(int margin, int type);
		void SetMarginWidthN(int margin, int pixelWidth);
		void SetModEventMask(int modEventMask);
		void SetMouseDownCaptures(bool captures);
		void SetMouseDwellTime(int mouseDwellTime);
		void SetOvertype(bool overType);
		void SetPasteConvertEndings(bool convert);
		void SetPositionCache(int size);
		void SetPrintColourMode(int mode);
		void SetPrintMagnification(int magnification);
		void SetPrintWrapMode(int wrapMode);
		void SetProperty(string key, string value);
		void SetReadOnly(bool readOnly);
		void SetSavePoint();
		void SetScrollWidth(int pixelWidth);
		void SetSearchFlags(int searchFlags);
		void SetSel(int anchorPos, int currentPos);
		void SetSelBack(bool useSelectionBackColour, int colour);
		void SetSelectionEnd(int position);
		void SetSelectionMode(int mode);
		void SetSelectionStart(int position);
		void SetSelFore(bool useSelectionForeColour, int colour);
		void SetStatus(int status);
		[Obsolete("The modern style indicators make this obsolete, this should always be 7")]
		void SetStyleBits(int bits);
		void SetStyling(int length, int style);
		void SetStylingEx(int length, string styles);
		void SetTabIndents(bool tabIndents);
		void SetTabWidth(int widthInChars);
		void SetTargetEnd(int pos);
		void SetTargetStart(int pos);
		void SetText(string text);
		void SetTwoPhaseDraw(bool twoPhase);
		void SetUndoCollection(bool collectUndo);
		void SetUsePalette(bool allowPaletteUse);
		void SetUseTabs(bool useTabs);
		void SetViewEol(bool visible);
		void SetViewWS(int wsMode);
		void SetVisiblePolicy(int visiblePolicy, int visibleSlop);
		void SetVScrollBar(bool visible);
		void SetWhitespaceBack(bool useWhitespaceForeColour, int colour);
		void SetWhitespaceChars(string chars);
		void SetWhitespaceFore(bool useWhitespaceForeColour, int colour);
		void SetWordChars(string chars);
		void SetWrapMode(int wrapMode);
		void SetWrapStartIndent(int indent);
		void SetWrapVisualFlags(int wrapVisualFlags);
		void SetWrapVisualFlagsLocation(int wrapVisualFlagsLocation);
		void SetXCaretPolicy(int caretPolicy, int caretSlop);
		void SetXOffset(int xOffset);
		void SetYCaretPolicy(int caretPolicy, int caretSlop);
		void SetZoom(int zoomInPoints);
		void ShowLines(int lineStart, int lineEnd);
		void StartRecord();
		void StartStyling(int position, int mask);
		void StopRecord();
		void StutteredPageDown();
		void StutteredPageDownExtend();
		void StutteredPageUp();
		void StutteredPageUpExtend();
		void StyleClearAll();
		event EventHandler<NativeScintillaEventArgs> StyleNeeded;
		void StyleResetDefault();
		int StyleGetBack(int styleNumber);
		bool StyleGetBold(int styleNumber);
		int StyleGetCase(int styleNumber);
		bool StyleGetChangeable(int styleNumber);
		int StyleGetCharacterSet(int styleNumber);
		bool StyleGetEOLFilled(int styleNumber);
		void StyleGetFont(int styleNumber, out string fontName);
		int StyleGetFore(int styleNumber);
		bool StyleGetHotSpot(int styleNumber);
		bool StyleGetItalic(int styleNumber);
		int StyleGetSize(int styleNumber);
		bool StyleGetUnderline(int styleNumber);
		bool StyleGetVisible(int styleNumber);
		void StyleSetBack(int styleNumber, int colour);
		void StyleSetBold(int styleNumber, bool bold);
		void StyleSetCase(int styleNumber, int caseMode);
		void StyleSetChangeable(int styleNumber, bool changeable);
		void StyleSetCharacterSet(int styleNumber, int charSet);
		void StyleSetEOLFilled(int styleNumber, bool eolFilled);
		void StyleSetFont(int styleNumber, string fontName);
		void StyleSetFore(int styleNumber, int colour);
		void StyleSetHotSpot(int styleNumber, bool hotspot);
		void StyleSetItalic(int styleNumber, bool italic);
		void StyleSetSize(int styleNumber, int sizeInPoints);
		void StyleSetUnderline(int styleNumber, bool underline);
		void StyleSetVisible(int styleNumber, bool visible);
		void Tab();
		int TargetAsUtf8(out string s);
		void TargetFromSelection();
		int TextHeight(int line);
		int TextWidth(int styleNumber, string text);
		void ToggleCaretSticky();
		void ToggleFold(int line);
		void Undo();
		event EventHandler<NativeScintillaEventArgs> UpdateUI;
		void UpperCase();
		event EventHandler<NativeScintillaEventArgs> UriDropped;
		void UsePopUp(bool bEnablePopup);
		event EventHandler<NativeScintillaEventArgs> UserListSelection;
		void UserListShow(int listType, string list);
		void VCHome();
		void VCHomeExtend();
		void VCHomeRectExtend();
		void VCHomeWrap();
		void VCHomeWrapExtend();
		int VisibleFromDocLine(int docLine);
		int WordEndPosition(int position, bool onlyWordCharacters);
		void WordLeft();
		void WordLeftEnd();
		void WordLeftEndExtend();
		void WordLeftExtend();
		void WordPartLeft();
		void WordPartLeftExtend();
		void WordPartRight();
		void WordPartRightExtend();
		void WordRight();
		void WordRightEnd();
		void WordRightEndExtend();
		void WordRightExtend();
		int WordStartPosition(int position, bool onlyWordCharacters);
		int WrapCount(int docLine);
		event EventHandler<NativeScintillaEventArgs> Zoom;
		void ZoomIn();
		void ZoomOut();
	}
}

