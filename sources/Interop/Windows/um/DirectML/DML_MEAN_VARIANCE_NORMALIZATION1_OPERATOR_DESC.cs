// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DML_MEAN_VARIANCE_NORMALIZATION1_OPERATOR_DESC
    {
        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* InputTensor;

        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* ScaleTensor;

        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* BiasTensor;

        [NativeTypeName("const DML_TENSOR_DESC *")]
        public DML_TENSOR_DESC* OutputTensor;

        [NativeTypeName("UINT")]
        public uint AxisCount;

        [NativeTypeName("const UINT *")]
        public uint* Axes;

        [NativeTypeName("BOOL")]
        public int NormalizeVariance;

        [NativeTypeName("FLOAT")]
        public float Epsilon;

        [NativeTypeName("const DML_OPERATOR_DESC *")]
        public DML_OPERATOR_DESC* FusedActivation;
    }
}
