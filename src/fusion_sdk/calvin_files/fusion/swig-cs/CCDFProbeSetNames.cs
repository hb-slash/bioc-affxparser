/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CCDFProbeSetNames : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CCDFProbeSetNames(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CCDFProbeSetNames obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CCDFProbeSetNames() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_CCDFProbeSetNames(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public CCDFProbeSetNames() : this(affx_fusionPINVOKE.new_CCDFProbeSetNames(), true) {
  }

  public void Clear() {
    affx_fusionPINVOKE.CCDFProbeSetNames_Clear(swigCPtr);
  }

  public string GetName(int index) {
    string ret = affx_fusionPINVOKE.CCDFProbeSetNames_GetName(swigCPtr, index);
    return ret;
  }

}