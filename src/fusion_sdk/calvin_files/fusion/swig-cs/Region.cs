/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Region : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Region(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Region obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Region() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_Region(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public void Clear() {
    affx_fusionPINVOKE.Region_Clear(swigCPtr);
  }

  public SWIGTYPE_p_std__vectorTaffymetrix_calvin_utilities__Point_t pts {
    set {
      affx_fusionPINVOKE.set_Region_pts(swigCPtr, SWIGTYPE_p_std__vectorTaffymetrix_calvin_utilities__Point_t.getCPtr(value));
    } 
    get {
      IntPtr cPtr = affx_fusionPINVOKE.get_Region_pts(swigCPtr);
      SWIGTYPE_p_std__vectorTaffymetrix_calvin_utilities__Point_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorTaffymetrix_calvin_utilities__Point_t(cPtr, false);
      return ret;
    } 
  }

  public Region() : this(affx_fusionPINVOKE.new_Region(), true) {
  }

}
