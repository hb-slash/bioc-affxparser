/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class FusionBaseCallType {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected FusionBaseCallType(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(FusionBaseCallType obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_FusionBaseCallType(swigCPtr);
    }
    swigCPtr = 0;
  }

  public FusionBaseCallType() {
    this(affx_fusionJNI.new_FusionBaseCallType__SWIG_0(), true);
  }

  public FusionBaseCallType(int p, char c) {
    this(affx_fusionJNI.new_FusionBaseCallType__SWIG_1(p, c), true);
  }

  public void Clear() {
    affx_fusionJNI.FusionBaseCallType_Clear(swigCPtr);
  }

  public int GetPosition() {
    return affx_fusionJNI.FusionBaseCallType_GetPosition(swigCPtr);
  }

  public char GetCall() {
    return affx_fusionJNI.FusionBaseCallType_GetCall(swigCPtr);
  }

  public void SetPosition(int p) {
    affx_fusionJNI.FusionBaseCallType_SetPosition(swigCPtr, p);
  }

  public void SetCall(char p) {
    affx_fusionJNI.FusionBaseCallType_SetCall(swigCPtr, p);
  }

}