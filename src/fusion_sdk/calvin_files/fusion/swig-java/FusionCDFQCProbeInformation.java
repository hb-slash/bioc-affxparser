/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class FusionCDFQCProbeInformation {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected FusionCDFQCProbeInformation(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(FusionCDFQCProbeInformation obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public void delete() {
    if(swigCPtr != 0 && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionJNI.delete_FusionCDFQCProbeInformation(swigCPtr);
    }
    swigCPtr = 0;
  }

  public FusionCDFQCProbeInformation() {
    this(affx_fusionJNI.new_FusionCDFQCProbeInformation(), true);
  }

  public int GetX() {
    return affx_fusionJNI.FusionCDFQCProbeInformation_GetX(swigCPtr);
  }

  public int GetY() {
    return affx_fusionJNI.FusionCDFQCProbeInformation_GetY(swigCPtr);
  }

  public int GetPLen() {
    return affx_fusionJNI.FusionCDFQCProbeInformation_GetPLen(swigCPtr);
  }

  public boolean IsPerfectMatchProbe() {
    return affx_fusionJNI.FusionCDFQCProbeInformation_IsPerfectMatchProbe(swigCPtr);
  }

  public boolean IsBackgroundProbe() {
    return affx_fusionJNI.FusionCDFQCProbeInformation_IsBackgroundProbe(swigCPtr);
  }

}