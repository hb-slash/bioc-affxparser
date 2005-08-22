/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CCHPFileHeader : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CCHPFileHeader(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CCHPFileHeader obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CCHPFileHeader() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_CCHPFileHeader(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public CCHPFileHeader() : this(affx_fusionPINVOKE.new_CCHPFileHeader(), true) {
  }

  public int GetCols() {
    int ret = affx_fusionPINVOKE.CCHPFileHeader_GetCols(swigCPtr);
    return ret;
  }

  public int GetRows() {
    int ret = affx_fusionPINVOKE.CCHPFileHeader_GetRows(swigCPtr);
    return ret;
  }

  public int GetNumProbeSets() {
    int ret = affx_fusionPINVOKE.CCHPFileHeader_GetNumProbeSets(swigCPtr);
    return ret;
  }

  public CCHPFileHeader.GeneChipAssayType GetAssayType() {
    CCHPFileHeader.GeneChipAssayType ret = (CCHPFileHeader.GeneChipAssayType)affx_fusionPINVOKE.CCHPFileHeader_GetAssayType(swigCPtr);
    return ret;
  }

  public string GetChipType() {
    string ret = affx_fusionPINVOKE.CCHPFileHeader_GetChipType(swigCPtr);
    return ret;
  }

  public string GetAlgName() {
    string ret = affx_fusionPINVOKE.CCHPFileHeader_GetAlgName(swigCPtr);
    return ret;
  }

  public string GetAlgVersion() {
    string ret = affx_fusionPINVOKE.CCHPFileHeader_GetAlgVersion(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_std__listT_TagValuePairType_t AlgorithmParameters() {
    SWIGTYPE_p_std__listT_TagValuePairType_t ret = new SWIGTYPE_p_std__listT_TagValuePairType_t(affx_fusionPINVOKE.CCHPFileHeader_AlgorithmParameters(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_std__listT_TagValuePairType_t SummaryParameters() {
    SWIGTYPE_p_std__listT_TagValuePairType_t ret = new SWIGTYPE_p_std__listT_TagValuePairType_t(affx_fusionPINVOKE.CCHPFileHeader_SummaryParameters(swigCPtr), false);
    return ret;
  }

  public string GetParentCellFile() {
    string ret = affx_fusionPINVOKE.CCHPFileHeader_GetParentCellFile(swigCPtr);
    return ret;
  }

  public string GetProgID() {
    string ret = affx_fusionPINVOKE.CCHPFileHeader_GetProgID(swigCPtr);
    return ret;
  }

  public string GetAlgorithmParameter(string tag) {
    string ret = affx_fusionPINVOKE.CCHPFileHeader_GetAlgorithmParameter(swigCPtr, tag);
    return ret;
  }

  public string GetSummaryParameter(string tag) {
    string ret = affx_fusionPINVOKE.CCHPFileHeader_GetSummaryParameter(swigCPtr, tag);
    return ret;
  }

  public BackgroundZoneInfo GetBackgroundZoneInfo() {
    BackgroundZoneInfo ret = new BackgroundZoneInfo(affx_fusionPINVOKE.CCHPFileHeader_GetBackgroundZoneInfo(swigCPtr), false);
    return ret;
  }

  public SWIGTYPE_p_std__listTaffxchp___BackgroundZoneType_t GetBackgroundZones() {
    SWIGTYPE_p_std__listTaffxchp___BackgroundZoneType_t ret = new SWIGTYPE_p_std__listTaffxchp___BackgroundZoneType_t(affx_fusionPINVOKE.CCHPFileHeader_GetBackgroundZones(swigCPtr), false);
    return ret;
  }

  public BackgroundZoneType GetBackgroundZone(int x, int y) {
    BackgroundZoneType ret = new BackgroundZoneType(affx_fusionPINVOKE.CCHPFileHeader_GetBackgroundZone(swigCPtr, x, y), true);
    return ret;
  }

  public int GetMagicNumber() {
    int ret = affx_fusionPINVOKE.CCHPFileHeader_GetMagicNumber(swigCPtr);
    return ret;
  }

  public int GetVersionNumber() {
    int ret = affx_fusionPINVOKE.CCHPFileHeader_GetVersionNumber(swigCPtr);
    return ret;
  }

  public void SetCols(int n) {
    affx_fusionPINVOKE.CCHPFileHeader_SetCols(swigCPtr, n);
  }

  public void SetRows(int n) {
    affx_fusionPINVOKE.CCHPFileHeader_SetRows(swigCPtr, n);
  }

  public void SetNumProbeSets(int n) {
    affx_fusionPINVOKE.CCHPFileHeader_SetNumProbeSets(swigCPtr, n);
  }

  public void SetAssayType(CCHPFileHeader.GeneChipAssayType t) {
    affx_fusionPINVOKE.CCHPFileHeader_SetAssayType(swigCPtr, (int)t);
  }

  public void SetChipType(string s) {
    affx_fusionPINVOKE.CCHPFileHeader_SetChipType(swigCPtr, s);
  }

  public void SetAlgName(string s) {
    affx_fusionPINVOKE.CCHPFileHeader_SetAlgName(swigCPtr, s);
  }

  public void SetAlgVersion(string s) {
    affx_fusionPINVOKE.CCHPFileHeader_SetAlgVersion(swigCPtr, s);
  }

  public void SetParentCellFile(string s) {
    affx_fusionPINVOKE.CCHPFileHeader_SetParentCellFile(swigCPtr, s);
  }

  public void SetProgID(string s) {
    affx_fusionPINVOKE.CCHPFileHeader_SetProgID(swigCPtr, s);
  }

  public enum GeneChipAssayType {
    Expression,
    Genotyping,
    Resequencing,
    Universal,
    Unknown
  }

}
