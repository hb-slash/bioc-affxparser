/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.25
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class GDACSequenceHitItemType : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GDACSequenceHitItemType(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GDACSequenceHitItemType obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GDACSequenceHitItemType() {
    Dispose();
  }

  public virtual void Dispose() {
    if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
      swigCMemOwn = false;
      affx_fusionPINVOKE.delete_GDACSequenceHitItemType(swigCPtr);
    }
    swigCPtr = new HandleRef(null, IntPtr.Zero);
    GC.SuppressFinalize(this);
  }

  public uint PMX {
    set {
      affx_fusionPINVOKE.set_GDACSequenceHitItemType_PMX(swigCPtr, value);
    } 
    get {
      uint ret = affx_fusionPINVOKE.get_GDACSequenceHitItemType_PMX(swigCPtr);
      return ret;
    } 
  }

  public uint PMY {
    set {
      affx_fusionPINVOKE.set_GDACSequenceHitItemType_PMY(swigCPtr, value);
    } 
    get {
      uint ret = affx_fusionPINVOKE.get_GDACSequenceHitItemType_PMY(swigCPtr);
      return ret;
    } 
  }

  public uint MMX {
    set {
      affx_fusionPINVOKE.set_GDACSequenceHitItemType_MMX(swigCPtr, value);
    } 
    get {
      uint ret = affx_fusionPINVOKE.get_GDACSequenceHitItemType_MMX(swigCPtr);
      return ret;
    } 
  }

  public uint MMY {
    set {
      affx_fusionPINVOKE.set_GDACSequenceHitItemType_MMY(swigCPtr, value);
    } 
    get {
      uint ret = affx_fusionPINVOKE.get_GDACSequenceHitItemType_MMY(swigCPtr);
      return ret;
    } 
  }

  public float MatchScore {
    set {
      affx_fusionPINVOKE.set_GDACSequenceHitItemType_MatchScore(swigCPtr, value);
    } 
    get {
      float ret = affx_fusionPINVOKE.get_GDACSequenceHitItemType_MatchScore(swigCPtr);
      return ret;
    } 
  }

  public uint Position {
    set {
      affx_fusionPINVOKE.set_GDACSequenceHitItemType_Position(swigCPtr, value);
    } 
    get {
      uint ret = affx_fusionPINVOKE.get_GDACSequenceHitItemType_Position(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_std__string PMProbe {
    set {
      affx_fusionPINVOKE.set_GDACSequenceHitItemType_PMProbe(swigCPtr, SWIGTYPE_p_std__string.getCPtr(value));
    } 
    get {
      IntPtr cPtr = affx_fusionPINVOKE.get_GDACSequenceHitItemType_PMProbe(swigCPtr);
      SWIGTYPE_p_std__string ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_std__string(cPtr, false);
      return ret;
    } 
  }

  public byte ProbeLength {
    set {
      affx_fusionPINVOKE.set_GDACSequenceHitItemType_ProbeLength(swigCPtr, value);
    } 
    get {
      byte ret = affx_fusionPINVOKE.get_GDACSequenceHitItemType_ProbeLength(swigCPtr);
      return ret;
    } 
  }

  public byte TopStrand {
    set {
      affx_fusionPINVOKE.set_GDACSequenceHitItemType_TopStrand(swigCPtr, value);
    } 
    get {
      byte ret = affx_fusionPINVOKE.get_GDACSequenceHitItemType_TopStrand(swigCPtr);
      return ret;
    } 
  }

  public bool _GDACSequenceHitItemType_less_than(GDACSequenceHitItemType rhs) {
    bool ret = affx_fusionPINVOKE.GDACSequenceHitItemType__GDACSequenceHitItemType_less_than(swigCPtr, GDACSequenceHitItemType.getCPtr(rhs));
    if (affx_fusionPINVOKE.SWIGPendingException.Pending) throw affx_fusionPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string PackedPMProbe {
    set {
      affx_fusionPINVOKE.set_GDACSequenceHitItemType_PackedPMProbe(swigCPtr, value);
    } 
    get {
      string ret = affx_fusionPINVOKE.get_GDACSequenceHitItemType_PackedPMProbe(swigCPtr);
      return ret;
    } 
  }

  public GDACSequenceHitItemType() : this(affx_fusionPINVOKE.new_GDACSequenceHitItemType(), true) {
  }

}
