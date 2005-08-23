/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class CCDFProbeGroupInformation : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CCDFProbeGroupInformation(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CCDFProbeGroupInformation obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CCDFProbeGroupInformation() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_CCDFProbeGroupInformation(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public DirectionType GetDirection() {
    DirectionType ret = (DirectionType)affx_fusionPINVOKE.CCDFProbeGroupInformation_GetDirection(swigCPtr);
    return ret;
  }

  public int GetNumLists() {
    int ret = affx_fusionPINVOKE.CCDFProbeGroupInformation_GetNumLists(swigCPtr);
    return ret;
  }

  public int GetNumCells() {
    int ret = affx_fusionPINVOKE.CCDFProbeGroupInformation_GetNumCells(swigCPtr);
    return ret;
  }

  public int GetNumCellsPerList() {
    int ret = affx_fusionPINVOKE.CCDFProbeGroupInformation_GetNumCellsPerList(swigCPtr);
    return ret;
  }

  public int GetStart() {
    int ret = affx_fusionPINVOKE.CCDFProbeGroupInformation_GetStart(swigCPtr);
    return ret;
  }

  public int GetStop() {
    int ret = affx_fusionPINVOKE.CCDFProbeGroupInformation_GetStop(swigCPtr);
    return ret;
  }

  public string GetName() {
    string ret = affx_fusionPINVOKE.CCDFProbeGroupInformation_GetName(swigCPtr);
    return ret;
  }

  public void GetCell(int cell_index, CCDFProbeInformation info) {
    affx_fusionPINVOKE.CCDFProbeGroupInformation_GetCell(swigCPtr, cell_index, CCDFProbeInformation.getCPtr(info));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
  }

  public CCDFProbeGroupInformation() : this(affx_fusionPINVOKE.new_CCDFProbeGroupInformation(), true) {
  }

}