/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class IFusionCHPHeaderAdapter {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected IFusionCHPHeaderAdapter(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(IFusionCHPHeaderAdapter obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_IFusionCHPHeaderAdapter(swigCPtr);
    }
    swigCPtr = 0;
  }

  public int GetCols() {
    return affx_fusionJNI.IFusionCHPHeaderAdapter_GetCols(swigCPtr);
  }

  public int GetRows() {
    return affx_fusionJNI.IFusionCHPHeaderAdapter_GetRows(swigCPtr);
  }

  public int GetNumProbeSets() {
    return affx_fusionJNI.IFusionCHPHeaderAdapter_GetNumProbeSets(swigCPtr);
  }

  public AssayType GetAssayType() {
    return AssayType.swigToEnum(affx_fusionJNI.IFusionCHPHeaderAdapter_GetAssayType(swigCPtr));
  }

  public SWIGTYPE_p_wstring GetChipType() {
    return new SWIGTYPE_p_wstring(affx_fusionJNI.IFusionCHPHeaderAdapter_GetChipType(swigCPtr), true);
  }

  public SWIGTYPE_p_wstring GetAlgName() {
    return new SWIGTYPE_p_wstring(affx_fusionJNI.IFusionCHPHeaderAdapter_GetAlgName(swigCPtr), true);
  }

  public SWIGTYPE_p_wstring GetAlgVersion() {
    return new SWIGTYPE_p_wstring(affx_fusionJNI.IFusionCHPHeaderAdapter_GetAlgVersion(swigCPtr), true);
  }

  public void GetAlgorithmParameters(SWIGTYPE_p_std__listTaffymetrix_fusion_io__FusionTagValuePairType_t values) {
    affx_fusionJNI.IFusionCHPHeaderAdapter_GetAlgorithmParameters(swigCPtr, SWIGTYPE_p_std__listTaffymetrix_fusion_io__FusionTagValuePairType_t.getCPtr(values));
  }

  public long GetAlgorithmParameterCount() {
    return affx_fusionJNI.IFusionCHPHeaderAdapter_GetAlgorithmParameterCount(swigCPtr);
  }

  public void GetSummaryParameters(SWIGTYPE_p_std__listTaffymetrix_fusion_io__FusionTagValuePairType_t values) {
    affx_fusionJNI.IFusionCHPHeaderAdapter_GetSummaryParameters(swigCPtr, SWIGTYPE_p_std__listTaffymetrix_fusion_io__FusionTagValuePairType_t.getCPtr(values));
  }

  public SWIGTYPE_p_wstring GetParentCellFile() {
    return new SWIGTYPE_p_wstring(affx_fusionJNI.IFusionCHPHeaderAdapter_GetParentCellFile(swigCPtr), true);
  }

  public SWIGTYPE_p_wstring GetProgID() {
    return new SWIGTYPE_p_wstring(affx_fusionJNI.IFusionCHPHeaderAdapter_GetProgID(swigCPtr), true);
  }

  public SWIGTYPE_p_wstring GetAlgorithmParameter(SWIGTYPE_p_wchar_t tag) {
    return new SWIGTYPE_p_wstring(affx_fusionJNI.IFusionCHPHeaderAdapter_GetAlgorithmParameter(swigCPtr, SWIGTYPE_p_wchar_t.getCPtr(tag)), true);
  }

  public SWIGTYPE_p_wstring GetSummaryParameter(SWIGTYPE_p_wchar_t tag) {
    return new SWIGTYPE_p_wstring(affx_fusionJNI.IFusionCHPHeaderAdapter_GetSummaryParameter(swigCPtr, SWIGTYPE_p_wchar_t.getCPtr(tag)), true);
  }

  public void GetBackgroundZoneInfo(BackgroundZoneInfo info) {
    affx_fusionJNI.IFusionCHPHeaderAdapter_GetBackgroundZoneInfo(swigCPtr, BackgroundZoneInfo.getCPtr(info));
  }

  public void GetBackgroundZones(SWIGTYPE_p_std__listTaffxchp___BackgroundZoneType_t zones) {
    affx_fusionJNI.IFusionCHPHeaderAdapter_GetBackgroundZones(swigCPtr, SWIGTYPE_p_std__listTaffxchp___BackgroundZoneType_t.getCPtr(zones));
  }

  public void GetBackgroundZone(BackgroundZoneType type, int x, int y) {
    affx_fusionJNI.IFusionCHPHeaderAdapter_GetBackgroundZone(swigCPtr, BackgroundZoneType.getCPtr(type), x, y);
  }

  public int GetMagic() {
    return affx_fusionJNI.IFusionCHPHeaderAdapter_GetMagic(swigCPtr);
  }

  public int GetVersion() {
    return affx_fusionJNI.IFusionCHPHeaderAdapter_GetVersion(swigCPtr);
  }

}