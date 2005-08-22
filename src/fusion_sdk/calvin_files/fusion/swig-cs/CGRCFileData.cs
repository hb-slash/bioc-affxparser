/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CGRCFileData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CGRCFileData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CGRCFileData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CGRCFileData() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_CGRCFileData(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public CGRCFileData() : this(affx_fusionPINVOKE.new_CGRCFileData(), true) {
  }

  public void SetFileName(string name) {
    affx_fusionPINVOKE.CGRCFileData_SetFileName(swigCPtr, name);
  }

  public string GetFileName() {
    string ret = affx_fusionPINVOKE.CGRCFileData_GetFileName(swigCPtr);
    return ret;
  }

  public bool Read(SWIGTYPE_p_affymetrix_grid_control__GridControlData grid) {
    bool ret = affx_fusionPINVOKE.CGRCFileData_Read(swigCPtr, SWIGTYPE_p_affymetrix_grid_control__GridControlData.getCPtr(grid));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Exists() {
    bool ret = affx_fusionPINVOKE.CGRCFileData_Exists(swigCPtr);
    return ret;
  }

}
