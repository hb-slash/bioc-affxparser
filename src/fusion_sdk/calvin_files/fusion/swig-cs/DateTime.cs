/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class DateTime : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DateTime(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DateTime obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DateTime() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_DateTime(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public DateTime() : this(affx_fusionPINVOKE.new_DateTime(), true) {
  }

  public SWIGTYPE_p_std__wstring Date() {
    SWIGTYPE_p_std__wstring ret = new SWIGTYPE_p_std__wstring(affx_fusionPINVOKE.DateTime_Date__SWIG_0(swigCPtr), true);
    return ret;
  }

  public void Date(SWIGTYPE_p_std__wstring value) {
    affx_fusionPINVOKE.DateTime_Date__SWIG_1(swigCPtr, SWIGTYPE_p_std__wstring.getCPtr(value));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__wstring Time() {
    SWIGTYPE_p_std__wstring ret = new SWIGTYPE_p_std__wstring(affx_fusionPINVOKE.DateTime_Time__SWIG_0(swigCPtr), true);
    return ret;
  }

  public void Time(SWIGTYPE_p_std__wstring value) {
    affx_fusionPINVOKE.DateTime_Time__SWIG_1(swigCPtr, SWIGTYPE_p_std__wstring.getCPtr(value));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    affx_fusionPINVOKE.DateTime_Clear(swigCPtr);
  }

  public static DateTime GetCurrentDateTime() {
    DateTime ret = new DateTime(affx_fusionPINVOKE.DateTime_GetCurrentDateTime(), true);
    return ret;
  }

  public bool IsUTC() {
    bool ret = affx_fusionPINVOKE.DateTime_IsUTC(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_std__wstring ToString() {
    SWIGTYPE_p_std__wstring ret = new SWIGTYPE_p_std__wstring(affx_fusionPINVOKE.DateTime_ToString(swigCPtr), true);
    return ret;
  }

  public static DateTime Parse(SWIGTYPE_p_std__wstring value) {
    DateTime ret = new DateTime(affx_fusionPINVOKE.DateTime_Parse(SWIGTYPE_p_std__wstring.getCPtr(value)), true);
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
