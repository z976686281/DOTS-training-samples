﻿
using Unity.Entities;
using Unity.Mathematics;

public struct FingerRenderComponentData: IComponentData
{
    public Entity fingerEntity;
    public int jointIndex;
}

public struct FingerIndexComponentData: IComponentData
{
    public int value;
    
    public static implicit operator FingerIndexComponentData(int index) => new FingerIndexComponentData
    {
        value = index
    };
    
    public static implicit operator int(FingerIndexComponentData c) => c.value;
}

public struct FingerGrabTimerComponentData: IComponentData
{
    public float value;
    
    public static implicit operator FingerGrabTimerComponentData(float index) => new FingerGrabTimerComponentData
    {
        value = index
    };
    
    public static implicit operator float(FingerGrabTimerComponentData c) => c.value;
}

public struct FingerParentComponentData: IComponentData
{
    public  Entity armParentEntity; //(read-only access to arm’s hand target and GrabT, shared by all fingers) 
    
    public static implicit operator FingerParentComponentData(Entity pos) => new FingerParentComponentData
    {
        armParentEntity = pos
    };
    
    public static implicit operator Entity(FingerParentComponentData c) => c.armParentEntity;
}

public struct FingerIdleTargetComponentData: IComponentData
{
    public float3 value;
    
    public static implicit operator FingerIdleTargetComponentData(float3 pos) => new FingerIdleTargetComponentData
    {
        value = pos
    };
    
    public static implicit operator float3(FingerIdleTargetComponentData c) => c.value;
}

public struct FingerBaseIdleTargetComponentData : IComponentData
{
    public float3 value;
    
    public static implicit operator FingerBaseIdleTargetComponentData(float3 pos) => new FingerBaseIdleTargetComponentData
    {
        value = pos
    };
    
    public static implicit operator float3(FingerBaseIdleTargetComponentData c) => c.value;
}

public struct FingerIKTargetComponentData: IComponentData
{
    public float3 value;
    
    public static implicit operator FingerIKTargetComponentData(float3 pos) => new FingerIKTargetComponentData
    {
        value = pos
    };
    
    public static implicit operator float3(FingerIKTargetComponentData c) => c.value;
    
}

public struct FingerJointElementData: IBufferElementData
{
    public float3 value;
    
    public static implicit operator FingerJointElementData(float3 pos) => new FingerJointElementData
    {
        value = pos
    };
    
    public static implicit operator float3(FingerJointElementData c) => c.value;
}

