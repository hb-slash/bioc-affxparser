/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class FusionCDFProbeInformation {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected FusionCDFProbeInformation(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(FusionCDFProbeInformation obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_FusionCDFProbeInformation(swigCPtr);
    }
    swigCPtr = 0;
  }

  public int GetListIndex() {
    return affx_fusionJNI.FusionCDFProbeInformation_GetListIndex(swigCPtr);
  }

  public int GetExpos() {
    return affx_fusionJNI.FusionCDFProbeInformation_GetExpos(swigCPtr);
  }

  public int GetX() {
    return affx_fusionJNI.FusionCDFProbeInformation_GetX(swigCPtr);
  }

  public int GetY() {
    return affx_fusionJNI.FusionCDFProbeInformation_GetY(swigCPtr);
  }

  public char GetPBase() {
    return affx_fusionJNI.FusionCDFProbeInformation_GetPBase(swigCPtr);
  }

  public char GetTBase() {
    return affx_fusionJNI.FusionCDFProbeInformation_GetTBase(swigCPtr);
  }

  public FusionCDFProbeInformation() {
    this(affx_fusionJNI.new_FusionCDFProbeInformation(), true);
  }

}