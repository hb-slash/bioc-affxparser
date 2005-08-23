/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class CEXPFileData {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected CEXPFileData(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(CEXPFileData obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_CEXPFileData(swigCPtr);
    }
    swigCPtr = 0;
  }

  public CEXPFileData() {
    this(affx_fusionJNI.new_CEXPFileData(), true);
  }

  public void SetFileName(String name) {
    affx_fusionJNI.CEXPFileData_SetFileName(swigCPtr, name);
  }

  public String GetFileName() {
    return affx_fusionJNI.CEXPFileData_GetFileName(swigCPtr);
  }

  public String GetArrayType() {
    return affx_fusionJNI.CEXPFileData_GetArrayType(swigCPtr);
  }

  public void SetArrayType(String arrayType) {
    affx_fusionJNI.CEXPFileData_SetArrayType(swigCPtr, arrayType);
  }

  public boolean Read() {
    return affx_fusionJNI.CEXPFileData_Read(swigCPtr);
  }

  public boolean Exists() {
    return affx_fusionJNI.CEXPFileData_Exists(swigCPtr);
  }

  public void Clear() {
    affx_fusionJNI.CEXPFileData_Clear(swigCPtr);
  }

  public SWIGTYPE_p_std__listT_TagValuePairType_t GetScanParameters() {
    return new SWIGTYPE_p_std__listT_TagValuePairType_t(affx_fusionJNI.CEXPFileData_GetScanParameters(swigCPtr), false);
  }

  public SWIGTYPE_p_std__listT_TagValuePairType_t GetHybParameters() {
    return new SWIGTYPE_p_std__listT_TagValuePairType_t(affx_fusionJNI.CEXPFileData_GetHybParameters(swigCPtr), false);
  }

  public SWIGTYPE_p_std__listT_TagValuePairType_t GetSampleParameters() {
    return new SWIGTYPE_p_std__listT_TagValuePairType_t(affx_fusionJNI.CEXPFileData_GetSampleParameters(swigCPtr), false);
  }

}