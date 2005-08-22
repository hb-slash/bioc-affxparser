/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class ParameterValue : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ParameterValue(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ParameterValue obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ParameterValue() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_ParameterValue(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public byte paramValueType {
    set {
      affx_fusionPINVOKE.set_ParameterValue_paramValueType(swigCPtr, value);
    } 
    get {
      byte ret = affx_fusionPINVOKE.get_ParameterValue_paramValueType(swigCPtr);
      return ret;
    } 
  }

  public int valueSize {
    set {
      affx_fusionPINVOKE.set_ParameterValue_valueSize(swigCPtr, value);
    } 
    get {
      int ret = affx_fusionPINVOKE.get_ParameterValue_valueSize(swigCPtr);
      return ret;
    } 
  }

  public ParameterDataValue paramValue {
    set {
      affx_fusionPINVOKE.set_ParameterValue_paramValue(swigCPtr, ParameterDataValue.getCPtr(value));
    } 
    get {
      IntPtr cPtr = affx_fusionPINVOKE.get_ParameterValue_paramValue(swigCPtr);
      ParameterDataValue ret = (cPtr == IntPtr.Zero) ? null : new ParameterDataValue(cPtr, false);
      return ret;
    } 
  }

  public ParameterValue() : this(affx_fusionPINVOKE.new_ParameterValue(), true) {
  }

}
