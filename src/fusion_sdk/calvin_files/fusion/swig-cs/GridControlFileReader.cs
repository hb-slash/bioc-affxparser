/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class GridControlFileReader : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GridControlFileReader(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GridControlFileReader obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GridControlFileReader() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_GridControlFileReader(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public GridControlFileReader() : this(affx_fusionPINVOKE.new_GridControlFileReader(), true) {
  }

  public void Read(string fileName, SWIGTYPE_p_affymetrix_grid_control__GridControlData data) {
    affx_fusionPINVOKE.GridControlFileReader_Read(swigCPtr, fileName, SWIGTYPE_p_affymetrix_grid_control__GridControlData.getCPtr(data));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

}
