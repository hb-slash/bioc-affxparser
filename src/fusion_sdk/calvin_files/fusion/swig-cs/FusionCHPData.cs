/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class FusionCHPData : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FusionCHPData(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FusionCHPData obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FusionCHPData() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_FusionCHPData(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public FusionCHPData() : this(affx_fusionPINVOKE.new_FusionCHPData(), true) {
  }

  public bool GetExpressionResults(int index, FusionExpressionProbeSetResults result) {
    bool ret = affx_fusionPINVOKE.FusionCHPData_GetExpressionResults(swigCPtr, index, FusionExpressionProbeSetResults.getCPtr(result));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetGenotypingResults(int index, FusionGenotypeProbeSetResults result) {
    bool ret = affx_fusionPINVOKE.FusionCHPData_GetGenotypingResults(swigCPtr, index, FusionGenotypeProbeSetResults.getCPtr(result));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetUniversalResults(int index, FusionUniversalProbeSetResults result) {
    bool ret = affx_fusionPINVOKE.FusionCHPData_GetUniversalResults(swigCPtr, index, FusionUniversalProbeSetResults.getCPtr(result));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Read() {
    bool ret = affx_fusionPINVOKE.FusionCHPData_Read(swigCPtr);
    return ret;
  }

  public bool ReadHeader() {
    bool ret = affx_fusionPINVOKE.FusionCHPData_ReadHeader(swigCPtr);
    return ret;
  }

  public bool Exists() {
    bool ret = affx_fusionPINVOKE.FusionCHPData_Exists(swigCPtr);
    return ret;
  }

  public void SetFileName(string name) {
    affx_fusionPINVOKE.FusionCHPData_SetFileName(swigCPtr, name);
  }

  public string GetFileName() {
    string ret = affx_fusionPINVOKE.FusionCHPData_GetFileName(swigCPtr);
    return ret;
  }

  public void Clear() {
    affx_fusionPINVOKE.FusionCHPData_Clear(swigCPtr);
  }

  public void CheckAdapter() {
    affx_fusionPINVOKE.FusionCHPData_CheckAdapter(swigCPtr);
  }

  public void CreateAdapter() {
    affx_fusionPINVOKE.FusionCHPData_CreateAdapter(swigCPtr);
  }

  public void DeleteAdapter() {
    affx_fusionPINVOKE.FusionCHPData_DeleteAdapter(swigCPtr);
  }

  public FusionCHPHeader GetHeader() {
    FusionCHPHeader ret = new FusionCHPHeader(affx_fusionPINVOKE.FusionCHPData_GetHeader(swigCPtr), false);
    return ret;
  }

}
