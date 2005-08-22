/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class DataGroup : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DataGroup(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DataGroup obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DataGroup() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_DataGroup(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public DataGroup(string filename, DataGroupHeader dch, SWIGTYPE_p_void handle) : this(affx_fusionPINVOKE.new_DataGroup(filename, DataGroupHeader.getCPtr(dch), SWIGTYPE_p_void.getCPtr(handle)), true) {
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public DataGroupHeader Header() {
    DataGroupHeader ret = new DataGroupHeader(affx_fusionPINVOKE.DataGroup_Header(swigCPtr), false);
    return ret;
  }

  public DataSet DataSet(uint dataSetIdx) {
    IntPtr cPtr = affx_fusionPINVOKE.DataGroup_DataSet__SWIG_0(swigCPtr, dataSetIdx);
    DataSet ret = (cPtr == IntPtr.Zero) ? null : new DataSet(cPtr, false);
    return ret;
  }

  public DataSet DataSet(SWIGTYPE_p_std__wstring dataSetName) {
    IntPtr cPtr = affx_fusionPINVOKE.DataGroup_DataSet__SWIG_1(swigCPtr, SWIGTYPE_p_std__wstring.getCPtr(dataSetName));
    DataSet ret = (cPtr == IntPtr.Zero) ? null : new DataSet(cPtr, false);
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
