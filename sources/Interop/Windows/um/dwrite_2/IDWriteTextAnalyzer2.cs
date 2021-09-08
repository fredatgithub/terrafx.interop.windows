// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("553A9FF3-5693-4DF7-B52B-74806F7F2EB9")]
    [NativeTypeName("struct IDWriteTextAnalyzer2 : IDWriteTextAnalyzer1")]
    [NativeInheritance("IDWriteTextAnalyzer1")]
    public unsafe partial struct IDWriteTextAnalyzer2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, uint>)(lpVtbl[1]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, uint>)(lpVtbl[2]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int AnalyzeScript(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)(lpVtbl[3]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int AnalyzeBidi(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)(lpVtbl[4]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int AnalyzeNumberSubstitution(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)(lpVtbl[5]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int AnalyzeLineBreakpoints(IDWriteTextAnalysisSource* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink* analysisSink)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource*, uint, uint, IDWriteTextAnalysisSink*, int>)(lpVtbl[6]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphs([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, IDWriteFontFace* fontFace, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, IDWriteNumberSubstitution* numberSubstitution, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("UINT16 *")] ushort* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT16 *")] ushort* glyphIndices, DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32 *")] uint* actualGlyphCount)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, ushort*, uint, IDWriteFontFace*, int, int, DWRITE_SCRIPT_ANALYSIS*, ushort*, IDWriteNumberSubstitution*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, uint, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint*, int>)(lpVtbl[7]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), textString, textLength, fontFace, isSideways, isRightToLeft, scriptAnalysis, localeName, numberSubstitution, features, featureRangeLengths, featureRanges, maxGlyphCount, clusterMap, textProps, glyphIndices, glyphProps, actualGlyphCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, DWRITE_GLYPH_OFFSET* glyphOffsets)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, ushort*, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, uint, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint, IDWriteFontFace*, float, int, int, DWRITE_SCRIPT_ANALYSIS*, ushort*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, float*, DWRITE_GLYPH_OFFSET*, int>)(lpVtbl[8]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphPlacements([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, DWRITE_SHAPING_TEXT_PROPERTIES* textProps, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProps, [NativeTypeName("UINT32")] uint glyphCount, IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("const DWRITE_TYPOGRAPHIC_FEATURES **")] DWRITE_TYPOGRAPHIC_FEATURES** features, [NativeTypeName("const UINT32 *")] uint* featureRangeLengths, [NativeTypeName("UINT32")] uint featureRanges, [NativeTypeName("FLOAT *")] float* glyphAdvances, DWRITE_GLYPH_OFFSET* glyphOffsets)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, ushort*, ushort*, DWRITE_SHAPING_TEXT_PROPERTIES*, uint, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint, IDWriteFontFace*, float, float, DWRITE_MATRIX*, int, int, int, DWRITE_SCRIPT_ANALYSIS*, ushort*, DWRITE_TYPOGRAPHIC_FEATURES**, uint*, uint, float*, DWRITE_GLYPH_OFFSET*, int>)(lpVtbl[9]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), textString, clusterMap, textProps, textLength, glyphIndices, glyphProps, glyphCount, fontFace, fontEmSize, pixelsPerDip, transform, useGdiNatural, isSideways, isRightToLeft, scriptAnalysis, localeName, features, featureRangeLengths, featureRanges, glyphAdvances, glyphOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int ApplyCharacterSpacing([NativeTypeName("FLOAT")] float leadingSpacing, [NativeTypeName("FLOAT")] float trailingSpacing, [NativeTypeName("FLOAT")] float minimumAdvanceWidth, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("FLOAT *")] float* modifiedGlyphAdvances, DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, float, float, float, uint, uint, ushort*, float*, DWRITE_GLYPH_OFFSET*, DWRITE_SHAPING_GLYPH_PROPERTIES*, float*, DWRITE_GLYPH_OFFSET*, int>)(lpVtbl[10]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), leadingSpacing, trailingSpacing, minimumAdvanceWidth, textLength, glyphCount, clusterMap, glyphAdvances, glyphOffsets, glyphProperties, modifiedGlyphAdvances, modifiedGlyphOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetBaseline(IDWriteFontFace* fontFace, DWRITE_BASELINE baseline, [NativeTypeName("BOOL")] int isVertical, [NativeTypeName("BOOL")] int isSimulationAllowed, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("INT32 *")] int* baselineCoordinate, [NativeTypeName("BOOL *")] int* exists)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, IDWriteFontFace*, DWRITE_BASELINE, int, int, DWRITE_SCRIPT_ANALYSIS, ushort*, int*, int*, int>)(lpVtbl[11]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, baseline, isVertical, isSimulationAllowed, scriptAnalysis, localeName, baselineCoordinate, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int AnalyzeVerticalGlyphOrientation(IDWriteTextAnalysisSource1* analysisSource, [NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, IDWriteTextAnalysisSink1* analysisSink)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, IDWriteTextAnalysisSource1*, uint, uint, IDWriteTextAnalysisSink1*, int>)(lpVtbl[12]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), analysisSource, textPosition, textLength, analysisSink);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("BOOL")] int isSideways, DWRITE_MATRIX* transform)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, DWRITE_GLYPH_ORIENTATION_ANGLE, int, DWRITE_MATRIX*, int>)(lpVtbl[13]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), glyphOrientationAngle, isSideways, transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetScriptProperties(DWRITE_SCRIPT_ANALYSIS scriptAnalysis, DWRITE_SCRIPT_PROPERTIES* scriptProperties)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, DWRITE_SCRIPT_ANALYSIS, DWRITE_SCRIPT_PROPERTIES*, int>)(lpVtbl[14]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), scriptAnalysis, scriptProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetTextComplexity([NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("UINT32")] uint textLength, IDWriteFontFace* fontFace, [NativeTypeName("BOOL *")] int* isTextSimple, [NativeTypeName("UINT32 *")] uint* textLengthRead, [NativeTypeName("UINT16 *")] ushort* glyphIndices)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, ushort*, uint, IDWriteFontFace*, int*, uint*, ushort*, int>)(lpVtbl[15]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), textString, textLength, fontFace, isTextSimple, textLengthRead, glyphIndices);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetJustificationOpportunities(IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const WCHAR *")] ushort* textString, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, IDWriteFontFace*, float, DWRITE_SCRIPT_ANALYSIS, uint, uint, ushort*, ushort*, DWRITE_SHAPING_GLYPH_PROPERTIES*, DWRITE_JUSTIFICATION_OPPORTUNITY*, int>)(lpVtbl[16]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, textString, clusterMap, glyphProperties, justificationOpportunities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int JustifyGlyphAdvances([NativeTypeName("FLOAT")] float lineWidth, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const DWRITE_JUSTIFICATION_OPPORTUNITY *")] DWRITE_JUSTIFICATION_OPPORTUNITY* justificationOpportunities, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("FLOAT *")] float* justifiedGlyphAdvances, DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, float, uint, DWRITE_JUSTIFICATION_OPPORTUNITY*, float*, DWRITE_GLYPH_OFFSET*, float*, DWRITE_GLYPH_OFFSET*, int>)(lpVtbl[17]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), lineWidth, glyphCount, justificationOpportunities, glyphAdvances, glyphOffsets, justifiedGlyphAdvances, justifiedGlyphOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetJustifiedGlyphs(IDWriteFontFace* fontFace, [NativeTypeName("FLOAT")] float fontEmSize, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("UINT32")] uint maxGlyphCount, [NativeTypeName("const UINT16 *")] ushort* clusterMap, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const FLOAT *")] float* justifiedGlyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* justifiedGlyphOffsets, [NativeTypeName("const DWRITE_SHAPING_GLYPH_PROPERTIES *")] DWRITE_SHAPING_GLYPH_PROPERTIES* glyphProperties, [NativeTypeName("UINT32 *")] uint* actualGlyphCount, [NativeTypeName("UINT16 *")] ushort* modifiedClusterMap, [NativeTypeName("UINT16 *")] ushort* modifiedGlyphIndices, [NativeTypeName("FLOAT *")] float* modifiedGlyphAdvances, DWRITE_GLYPH_OFFSET* modifiedGlyphOffsets)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, IDWriteFontFace*, float, DWRITE_SCRIPT_ANALYSIS, uint, uint, uint, ushort*, ushort*, float*, float*, DWRITE_GLYPH_OFFSET*, DWRITE_SHAPING_GLYPH_PROPERTIES*, uint*, ushort*, ushort*, float*, DWRITE_GLYPH_OFFSET*, int>)(lpVtbl[18]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, fontEmSize, scriptAnalysis, textLength, glyphCount, maxGlyphCount, clusterMap, glyphIndices, glyphAdvances, justifiedGlyphAdvances, justifiedGlyphOffsets, glyphProperties, actualGlyphCount, modifiedClusterMap, modifiedGlyphIndices, modifiedGlyphAdvances, modifiedGlyphOffsets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlyphOrientationTransform(DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, DWRITE_MATRIX* transform)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, DWRITE_GLYPH_ORIENTATION_ANGLE, int, float, float, DWRITE_MATRIX*, int>)(lpVtbl[19]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), glyphOrientationAngle, isSideways, originX, originY, transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypographicFeatures(IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint maxTagCount, [NativeTypeName("UINT32 *")] uint* actualTagCount, DWRITE_FONT_FEATURE_TAG* tags)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, IDWriteFontFace*, DWRITE_SCRIPT_ANALYSIS, ushort*, uint, uint*, DWRITE_FONT_FEATURE_TAG*, int>)(lpVtbl[20]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, scriptAnalysis, localeName, maxTagCount, actualTagCount, tags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int CheckTypographicFeature(IDWriteFontFace* fontFace, DWRITE_SCRIPT_ANALYSIS scriptAnalysis, [NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_FONT_FEATURE_TAG featureTag, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT8 *")] byte* featureApplies)
        {
            return ((delegate* unmanaged<IDWriteTextAnalyzer2*, IDWriteFontFace*, DWRITE_SCRIPT_ANALYSIS, ushort*, DWRITE_FONT_FEATURE_TAG, uint, ushort*, byte*, int>)(lpVtbl[21]))((IDWriteTextAnalyzer2*)Unsafe.AsPointer(ref this), fontFace, scriptAnalysis, localeName, featureTag, glyphCount, glyphIndices, featureApplies);
        }
    }
}
