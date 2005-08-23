/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class CDFData {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected CDFData(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(CDFData obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_CDFData(swigCPtr);
    }
    swigCPtr = 0;
  }

  public CDFData() {
    this(affx_fusionJNI.new_CDFData__SWIG_0(), true);
  }

  public CDFData(String filename) {
    this(affx_fusionJNI.new_CDFData__SWIG_1(filename), true);
  }

  public void Clear() {
    affx_fusionJNI.CDFData_Clear(swigCPtr);
  }

  public void SetFilename(String p) {
    affx_fusionJNI.CDFData_SetFilename(swigCPtr, p);
  }

  public String GetFilename() {
    return affx_fusionJNI.CDFData_GetFilename(swigCPtr);
  }

  public int GetProbeSetCnt() {
    return affx_fusionJNI.CDFData_GetProbeSetCnt(swigCPtr);
  }

  public void SetProbeSetCnt(long cnt, CDFDataTypeIds type) {
    affx_fusionJNI.CDFData_SetProbeSetCnt(swigCPtr, cnt, type.swigValue());
  }

  public SWIGTYPE_p_std__wstring GetProbeSetName(int index) {
    return new SWIGTYPE_p_std__wstring(affx_fusionJNI.CDFData_GetProbeSetName(swigCPtr, index), true);
  }

  public void SetArrayRows(long value) {
    affx_fusionJNI.CDFData_SetArrayRows(swigCPtr, value);
  }

  public long GetArrayRows() {
    return affx_fusionJNI.CDFData_GetArrayRows(swigCPtr);
  }

  public void SetArrayCols(long value) {
    affx_fusionJNI.CDFData_SetArrayCols(swigCPtr, value);
  }

  public long GetArrayCols() {
    return affx_fusionJNI.CDFData_GetArrayCols(swigCPtr);
  }

  public void SetRefSequence(String seq) {
    affx_fusionJNI.CDFData_SetRefSequence(swigCPtr, seq);
  }

  public String GetRefSequence() {
    return affx_fusionJNI.CDFData_GetRefSequence(swigCPtr);
  }

  public String GetDataTypeId() {
    return affx_fusionJNI.CDFData_GetDataTypeId(swigCPtr);
  }

  public FileHeader GetFileHeader() {
    long cPtr = affx_fusionJNI.CDFData_GetFileHeader(swigCPtr);
    return (cPtr == 0) ? null : new FileHeader(cPtr, false);
  }

  public GenericData GetGenericData() {
    return new GenericData(affx_fusionJNI.CDFData_GetGenericData(swigCPtr), false);
  }

  public void GetProbeSetInformation(int index, CDFProbeSetInformation info) {
    affx_fusionJNI.CDFData_GetProbeSetInformation__SWIG_0(swigCPtr, index, CDFProbeSetInformation.getCPtr(info));
  }

  public void GetProbeSetInformation(SWIGTYPE_p_std__wstring probeSetName, CDFProbeSetInformation info) {
    affx_fusionJNI.CDFData_GetProbeSetInformation__SWIG_1(swigCPtr, SWIGTYPE_p_std__wstring.getCPtr(probeSetName), CDFProbeSetInformation.getCPtr(info));
  }

  public void GetQCProbeSetInformation(int index, CDFQCProbeSetInformation info) {
    affx_fusionJNI.CDFData_GetQCProbeSetInformation__SWIG_0(swigCPtr, index, CDFQCProbeSetInformation.getCPtr(info));
  }

  public void GetQCProbeSetInformation(SWIGTYPE_p_std__wstring probeSetName, CDFQCProbeSetInformation info) {
    affx_fusionJNI.CDFData_GetQCProbeSetInformation__SWIG_1(swigCPtr, SWIGTYPE_p_std__wstring.getCPtr(probeSetName), CDFQCProbeSetInformation.getCPtr(info));
  }

}